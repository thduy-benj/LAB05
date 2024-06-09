namespace lab05
{
    partial class Bai6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            btnSend = new Button();
            btnRefresh = new Button();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLogin = new Button();
            btnLogOut = new Button();
            groupBox2 = new GroupBox();
            tbSmtpPort = new TextBox();
            tbSMTP = new TextBox();
            tbImapPort = new TextBox();
            tbIMAP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            colSTT = new ColumnHeader();
            colFrom = new ColumnHeader();
            colSub = new ColumnHeader();
            colDate = new ColumnHeader();
            lvEmails = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSend);
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(tbPassword);
            groupBox1.Controls.Add(tbEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnLogin);
            groupBox1.Controls.Add(btnLogOut);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 140);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(6, 100);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 29);
            btnSend.TabIndex = 6;
            btnSend.Text = "Gửi Mail";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(106, 100);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(83, 67);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(217, 27);
            tbPassword.TabIndex = 4;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(83, 26);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(217, 27);
            tbEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Tài khoản";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(206, 100);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(206, 100);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 7;
            btnLogOut.Text = "Đăng xuất";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tbSmtpPort);
            groupBox2.Controls.Add(tbSMTP);
            groupBox2.Controls.Add(tbImapPort);
            groupBox2.Controls.Add(tbIMAP);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(336, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(452, 140);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt";
            // 
            // tbSmtpPort
            // 
            tbSmtpPort.Location = new Point(265, 67);
            tbSmtpPort.Name = "tbSmtpPort";
            tbSmtpPort.Size = new Size(125, 27);
            tbSmtpPort.TabIndex = 7;
            // 
            // tbSMTP
            // 
            tbSMTP.Location = new Point(265, 30);
            tbSMTP.Name = "tbSMTP";
            tbSMTP.Size = new Size(125, 27);
            tbSMTP.TabIndex = 6;
            // 
            // tbImapPort
            // 
            tbImapPort.Location = new Point(65, 70);
            tbImapPort.Name = "tbImapPort";
            tbImapPort.Size = new Size(125, 27);
            tbImapPort.TabIndex = 5;
            // 
            // tbIMAP
            // 
            tbIMAP.Location = new Point(65, 33);
            tbIMAP.Name = "tbIMAP";
            tbIMAP.Size = new Size(125, 27);
            tbIMAP.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(213, 74);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 3;
            label6.Text = "Port";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 74);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 2;
            label5.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(213, 33);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 1;
            label4.Text = "SMTP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 33);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 0;
            label3.Text = "IMAP";
            // 
            // colSTT
            // 
            colSTT.Text = "#";
            // 
            // colFrom
            // 
            colFrom.Text = "From";
            colFrom.Width = 239;
            // 
            // colSub
            // 
            colSub.Text = "Subjects";
            colSub.Width = 239;
            // 
            // colDate
            // 
            colDate.Text = "Datetime";
            colDate.Width = 239;
            // 
            // lvEmails
            // 
            lvEmails.Columns.AddRange(new ColumnHeader[] { colSTT, colFrom, colSub, colDate });
            lvEmails.Location = new Point(12, 158);
            lvEmails.Name = "lvEmails";
            lvEmails.Size = new Size(776, 449);
            lvEmails.TabIndex = 2;
            lvEmails.UseCompatibleStateImageBehavior = false;
            lvEmails.View = View.Details;
            lvEmails.MouseDoubleClick += lvEmails_MouseDoubleClick;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 619);
            Controls.Add(lvEmails);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Label label2;
        private Label label1;
        private Button btnLogin;
        private Button btnSend;
        private Button btnRefresh;
        private TextBox tbSmtpPort;
        private TextBox tbSMTP;
        private TextBox tbImapPort;
        private TextBox tbIMAP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnLogOut;
        private ColumnHeader colSTT;
        private ColumnHeader colFrom;
        private ColumnHeader colSub;
        private ColumnHeader colDate;
        private ListView lvEmails;
    }
}