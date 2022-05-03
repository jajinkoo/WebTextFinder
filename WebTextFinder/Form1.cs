using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net.Mail;
                


namespace WebTextFinder
{
    public partial class Form1 : Form
    {
        string saveURL = "";

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.ShowInTaskbar = false;
            this.MinimumSize = new Size(1200, 700);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox_uri.Text);
            pictureBox1.Image = null;
            
        }

        private void radioButton_start_Click(object sender, EventArgs e)
        {
            MessageBox.Show("모니터링을 시작합니다.\n\n부하를 줄이기 위해 웹브라우져는 숨깁니다.\n\n(만약, 로그인 중이라면 로그인이 풀릴 가능성도 있습니다. 로그인이 풀리면 스캔이 중단됩니다. 그리고 실패 알림을 발송합니다.)", "웹사이트 변경 알리미");

            pictureBox1.Image = global::WebTextFinder.Properties.Resources.search2;
            numericUpDown_interval.Enabled = false;
            textBox_uri.Enabled = false;
            button_go.Enabled = false;
            textBox_id.Enabled = false;
            textBox_pw.Enabled = false;
            webBrowser1.Visible = false;
            button_test.Enabled = false;

            radioButton_conShow.Enabled = false;
            radioButton_conHide.Enabled = false;
            textBox_conShow.Enabled = false;
            textBox_conHide.Enabled = false;

            toolStripStatusLabel_lastFindOk.Text = "0000-00-00 00:00:00";
            toolStripStatusLabel_lastFind.Text = "0000-00-00 00:00:00";

            saveURL = webBrowser1.Url.ToString();//새로고침 후 다른 페이지 넘어가는지 감시

            timer1_Tick(null,null);

            timer1.Interval = (int)numericUpDown_interval.Value * 60000;
            timer1.Start();
        }

        private void radioButton_stop_Click(object sender, EventArgs e)
        {
            textBox_uri.Enabled = true;
            webBrowser1.Visible = true;
            button_go.Enabled = true;
            textBox_id.Enabled = true;
            textBox_pw.Enabled = true;
            button_test.Enabled = true;
            numericUpDown_interval.Enabled = true;

            radioButton_conShow.Enabled = true;
            radioButton_conHide.Enabled = true;
            textBox_conShow.Enabled = true;
            textBox_conHide.Enabled = true;

            pictureBox1.Image = null;
            timer1.Stop();
        }

        System.Text.Encoding euckr = System.Text.Encoding.GetEncoding(51949);


        private void timer1_Tick(object sender, EventArgs e)
        {
            webBrowser1.Refresh();

            if (saveURL != webBrowser1.Url.ToString())
            {
                radioButton_stop_Click(null, null);
                sendMail("[오류발생] 웹사이트 변경 알리미", "알 수 없는 이유로 검색 중인 페이지를 벗어나서 검사를 중단합니다.");
                MessageBox.Show("알 수 없는 이유로 검색 중인 페이지를 벗어나서 검사를 중단합니다.\n\n오류 시각:" + getNowTimeString(), "웹사이트 변경 알리미");
                return;
            }

            string htmlBody;

            htmlBody = webBrowser1.DocumentText.ToLower();

            if(htmlBody.Contains("euc-kr")){
                StreamReader sr = new StreamReader(webBrowser1.DocumentStream, euckr);
                htmlBody = sr.ReadToEnd().ToLower();
                sr.Close();
            }

            toolStripStatusLabel_lastFind.Text = getNowTimeString();

            if (radioButton_conShow.Checked)
            {
                if (htmlBody.Contains(textBox_conShow.Text.ToLower()) == true)
                {
                    toolStripStatusLabel_lastFindOk.Text = getNowTimeString();
                    sendMail("[성공] 웹사이트 변경 알리미", textBox_conShow.Text + "  단어 출현 발생\n\n검사를 성공하여 이제 웹사이트 변경 알리미 프로그램은 중단합니다.");
                    radioButton_stop_Click(null, null);
                    MessageBox.Show("갱신 중인 페이지에서 단어 출현을 감지했습니다.\n\n스캔을 중단합니다.\n\n알림 이메일 발송 완료\n\n검사 성공 시각:" + getNowTimeString(), "웹사이트 변경 알리미");
                }
            }
            else if (radioButton_conHide.Checked)
            {
                if (htmlBody.Contains(textBox_conHide.Text.ToLower()) == false)
                {
                    toolStripStatusLabel_lastFindOk.Text = getNowTimeString();
                    sendMail("[성공] 웹사이트 변경 알리미", textBox_conHide.Text + "  단어 사라짐 발생\n\n검사를 성공하여 이제 웹사이트 변경 알리미 프로그램은 중단합니다.");
                    radioButton_stop_Click(null, null);
                    MessageBox.Show("갱신 중인 페이지에서 단어 사라짐을 감지했습니다.\n\n스캔을 중단합니다.\n\n알림 이메일 발송 완료\n\n검사 성공 시각:" + getNowTimeString(), "웹사이트 변경 알리미");
                }
            }
        }

        private bool sendMail(string title, string body, bool test = false)
        {
            try
            {
                string SMTP_SERVER = "smtp.naver.com"; // SMTP 서버 주소
                int SMTP_PORT = 587; // SMTP 포트

                string MAIL_ID = textBox_id.Text.ToLower(); // 보내는 사람의 이메일
                string MAIL_ID_NAME = MAIL_ID.Replace("@naver.com", ""); // 보내는사람 계정 ( 네이버 로그인 아이디 ) 
                string MAIL_PW = textBox_pw.Text;  // 보내는사람 패스워드 ( 네이버 로그인 패스워드 )

                MailAddress mailFrom = new MailAddress(MAIL_ID, MAIL_ID_NAME, Encoding.UTF8); // 보내는사람의 정보를 생성
                MailAddress mailTo = new MailAddress(MAIL_ID); // 받는사람의 정보를 생성
                SmtpClient client = new SmtpClient(SMTP_SERVER, SMTP_PORT); // smtp 서버 정보를 생성
                MailMessage message = new MailMessage(mailFrom, mailTo);

                message.Subject = title;; // 메일 제목 프로퍼티
                message.Body = body; // 메일의 몸체 메세지 프로퍼티
                message.BodyEncoding = Encoding.UTF8; // 메세지 인코딩 형식
                message.SubjectEncoding = Encoding.UTF8; // 제목 인코딩 형식


                client.EnableSsl = true; // SSL 사용 유무 (네이버는 SSL을 사용합니다. )
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.Credentials = new System.Net.NetworkCredential(MAIL_ID, MAIL_PW); // 보안인증 ( 로그인 )
                client.Send(message);  //메일 전송 
            }
            catch(Exception e)
            {
                if (test)
                {
                    return false;
                }
                else
                {
                    timer1.Stop();
                    radioButton_stop.Checked = true;
                    MessageBox.Show("통신 상태가 좋지 않아 프로그램을 종료합니다.", "웹사이트 변경 알리미");

                    this.Close();
                    return false;
                }
            }

            return true;
        }

        private string getNowTimeString()
        {
            return DateTime.Now.ToString("yyyy-MM-dd tt hh:mm");
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text.ToLower().EndsWith("@naver.com") == false)
            {
                MessageBox.Show("[실패]\n\n알림을 받을 수 있는 메일은 네이버 메일만 가능합니다.\n\n다시 메일을 작성해주세요.", "웹사이트 변경 알리미");
                return;
            }
            else
            {
                bool result;

                result = sendMail("[테스트메일] 웹사이트 변경 알리미", "정상적으로 작동합니다.", true);
                if (result)
                {
                    MessageBox.Show("[테스트 알림 발송 완료]\n\n이제부터 스캔 기능을 사용할 수 있습니다.\n\n(실시간으로 메일을 확인하고 싶다면 스마트폰에 네이버메일 어플을 설치하세요)", "웹사이트 변경 알리미");
                    radioButton_start.Enabled = true;
                    radioButton_stop.Enabled = true;
                    label5.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("[실패]\n\n1. 아이디, 암호가 틀렸거나\n\n2. 네이버 메일 환경설정에서 [IMAP/SMTP] 설정을 활성화 시켜주세요.\n\n그리고 다시 테스트를 시도해주세요.", "웹사이트 변경 알리미");
                }
            }
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            textBox_uri.Text = e.Url.ToString();
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("[주의]\n\n이미지 글자는 검색되지 않습니다.\n\n순수 글자만 스캔가능합니다.\n\n검색 글자가 현재 페이지에서 유일한 글자이여야 규칙이 정상작동합니다.", "웹사이트 변경 알리미");
        }

        private void button_go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox_uri.Text);
        }

        private void textBox_uri_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_go_Click(null, null);
            }
        }


    }
}

//commit1