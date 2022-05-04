namespace WebTextFinder
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.textBox_conHide = new System.Windows.Forms.TextBox();
            this.textBox_conShow = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton_start = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.numericUpDown_interval = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.button_test = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.radioButton_stop = new System.Windows.Forms.RadioButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.textBox_pw = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_uri = new System.Windows.Forms.TextBox();
            this.button_go = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_lastFind = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_lastFindOk = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 139);
            this.panel1.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.checkBox2);
            this.panel8.Controls.Add(this.checkBox1);
            this.panel8.Controls.Add(this.textBox_conHide);
            this.panel8.Controls.Add(this.textBox_conShow);
            this.panel8.Controls.Add(this.pictureBox1);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 92);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel8.Size = new System.Drawing.Size(1184, 46);
            this.panel8.TabIndex = 9;
            // 
            // textBox_conHide
            // 
            this.textBox_conHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_conHide.Location = new System.Drawing.Point(787, 13);
            this.textBox_conHide.MaxLength = 15;
            this.textBox_conHide.Name = "textBox_conHide";
            this.textBox_conHide.Size = new System.Drawing.Size(138, 21);
            this.textBox_conHide.TabIndex = 5;
            this.textBox_conHide.Text = "예) 예약 대기";
            // 
            // textBox_conShow
            // 
            this.textBox_conShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_conShow.Location = new System.Drawing.Point(373, 13);
            this.textBox_conShow.MaxLength = 15;
            this.textBox_conShow.Name = "textBox_conShow";
            this.textBox_conShow.Size = new System.Drawing.Size(138, 21);
            this.textBox_conShow.TabIndex = 5;
            this.textBox_conShow.Text = "예) 1차 합격";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::WebTextFinder.Properties.Resources.search2;
            this.pictureBox1.Location = new System.Drawing.Point(1082, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Location = new System.Drawing.Point(10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 46);
            this.label4.TabIndex = 3;
            this.label4.Text = "알림 규칙";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radioButton_start);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.button_test);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.radioButton_stop);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 46);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(10);
            this.panel4.Size = new System.Drawing.Size(1184, 46);
            this.panel4.TabIndex = 8;
            // 
            // radioButton_start
            // 
            this.radioButton_start.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_start.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_start.Enabled = false;
            this.radioButton_start.ForeColor = System.Drawing.Color.Black;
            this.radioButton_start.Location = new System.Drawing.Point(990, 10);
            this.radioButton_start.Margin = new System.Windows.Forms.Padding(0);
            this.radioButton_start.Name = "radioButton_start";
            this.radioButton_start.Size = new System.Drawing.Size(92, 26);
            this.radioButton_start.TabIndex = 3;
            this.radioButton_start.Text = "스캔 시작";
            this.radioButton_start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_start.UseVisualStyleBackColor = true;
            this.radioButton_start.Click += new System.EventHandler(this.radioButton_start_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.numericUpDown_interval);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(916, 10);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.panel7.Size = new System.Drawing.Size(68, 26);
            this.panel7.TabIndex = 8;
            // 
            // numericUpDown_interval
            // 
            this.numericUpDown_interval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown_interval.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numericUpDown_interval.Location = new System.Drawing.Point(10, 2);
            this.numericUpDown_interval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDown_interval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_interval.Name = "numericUpDown_interval";
            this.numericUpDown_interval.Size = new System.Drawing.Size(48, 21);
            this.numericUpDown_interval.TabIndex = 5;
            this.numericUpDown_interval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Location = new System.Drawing.Point(784, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 7;
            this.label6.Text = "새로고침 간격(초)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_test
            // 
            this.button_test.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_test.Location = new System.Drawing.Point(689, 10);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(95, 26);
            this.button_test.TabIndex = 6;
            this.button_test.Text = "알림 전송";
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(556, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 26);
            this.label5.TabIndex = 6;
            this.label5.Text = "테스트 메일 (필수)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButton_stop
            // 
            this.radioButton_stop.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton_stop.Checked = true;
            this.radioButton_stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_stop.Dock = System.Windows.Forms.DockStyle.Right;
            this.radioButton_stop.Enabled = false;
            this.radioButton_stop.Location = new System.Drawing.Point(1082, 10);
            this.radioButton_stop.Name = "radioButton_stop";
            this.radioButton_stop.Size = new System.Drawing.Size(92, 26);
            this.radioButton_stop.TabIndex = 3;
            this.radioButton_stop.TabStop = true;
            this.radioButton_stop.Text = "스캔 정지";
            this.radioButton_stop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton_stop.UseVisualStyleBackColor = true;
            this.radioButton_stop.Click += new System.EventHandler(this.radioButton_stop_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.textBox_pw);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(429, 10);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.panel6.Size = new System.Drawing.Size(127, 26);
            this.panel6.TabIndex = 5;
            // 
            // textBox_pw
            // 
            this.textBox_pw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_pw.Location = new System.Drawing.Point(10, 2);
            this.textBox_pw.Name = "textBox_pw";
            this.textBox_pw.PasswordChar = '*';
            this.textBox_pw.Size = new System.Drawing.Size(107, 21);
            this.textBox_pw.TabIndex = 0;
            this.textBox_pw.Text = "password";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(329, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "메일 암호";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.textBox_id);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(110, 10);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.panel5.Size = new System.Drawing.Size(219, 26);
            this.panel5.TabIndex = 3;
            // 
            // textBox_id
            // 
            this.textBox_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_id.Location = new System.Drawing.Point(10, 2);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(199, 21);
            this.textBox_id.TabIndex = 0;
            this.textBox_id.Text = "xxxxxx@naver.com";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(10, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "알림 받을 메일";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.button_go);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(1184, 46);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.textBox_uri);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(110, 10);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            this.panel3.Size = new System.Drawing.Size(962, 26);
            this.panel3.TabIndex = 3;
            // 
            // textBox_uri
            // 
            this.textBox_uri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_uri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_uri.Location = new System.Drawing.Point(10, 2);
            this.textBox_uri.MaxLength = 5000;
            this.textBox_uri.Name = "textBox_uri";
            this.textBox_uri.Size = new System.Drawing.Size(942, 21);
            this.textBox_uri.TabIndex = 0;
            this.textBox_uri.Text = "http://naver.com";
            this.textBox_uri.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_uri_KeyUp);
            // 
            // button_go
            // 
            this.button_go.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_go.Location = new System.Drawing.Point(1072, 10);
            this.button_go.Name = "button_go";
            this.button_go.Size = new System.Drawing.Size(102, 26);
            this.button_go.TabIndex = 2;
            this.button_go.Text = "이동";
            this.button_go.UseVisualStyleBackColor = true;
            this.button_go.Click += new System.EventHandler(this.button_go_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "주소";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_lastFind,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel_lastFindOk});
            this.statusStrip1.Location = new System.Drawing.Point(0, 640);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1184, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "마지막 검색 시각 :";
            // 
            // toolStripStatusLabel_lastFind
            // 
            this.toolStripStatusLabel_lastFind.Name = "toolStripStatusLabel_lastFind";
            this.toolStripStatusLabel_lastFind.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel_lastFind.Text = "0000-00-00 00:00:00";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(27, 17);
            this.toolStripStatusLabel3.Text = "     ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(134, 17);
            this.toolStripStatusLabel4.Text = "마지막 검색 성공 시각 :";
            // 
            // toolStripStatusLabel_lastFindOk
            // 
            this.toolStripStatusLabel_lastFindOk.Name = "toolStripStatusLabel_lastFindOk";
            this.toolStripStatusLabel_lastFindOk.Size = new System.Drawing.Size(125, 17);
            this.toolStripStatusLabel_lastFindOk.Text = "0000-00-00 00:00:00";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel9.Controls.Add(this.webBrowser1);
            this.panel9.Location = new System.Drawing.Point(0, 139);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(749, 501);
            this.panel9.TabIndex = 3;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(3, 4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(747, 497);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(755, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(429, 496);
            this.listBox1.TabIndex = 4;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(122, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(236, 16);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "페이지 새로고침 후 이 단어가 나타나면";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(537, 16);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(236, 16);
            this.checkBox2.TabIndex = 7;
            this.checkBox2.Text = "페이지 새로고침 후 이 단어가 사라지면";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 662);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "웹사이트 변경 알리미";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_interval)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton_stop;
        private System.Windows.Forms.RadioButton radioButton_start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_uri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown_interval;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_lastFind;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_lastFindOk;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_go;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox_pw;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox textBox_conHide;
        private System.Windows.Forms.TextBox textBox_conShow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

