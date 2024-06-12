namespace lab05
{
    partial class Bai2
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
            label1 = new Label();
            label2 = new Label();
            txtEmail = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            lstView = new ListView();
            lbTotal = new Label();
            lbRecent = new Label();
            dataGridView1 = new DataGridView();
            Email = new DataGridViewTextBoxColumn();
            From = new DataGridViewTextBoxColumn();
            Time = new DataGridViewTextBoxColumn();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 34);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 0;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 70);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 1;
            label2.Text = "Password:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(129, 27);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(345, 27);
            txtEmail.TabIndex = 4;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(129, 60);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(345, 27);
            txtPass.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(585, 34);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(177, 51);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lstView
            // 
            lstView.Location = new Point(778, 404);
            lstView.Name = "lstView";
            lstView.Size = new Size(10, 34);
            lstView.TabIndex = 7;
            lstView.UseCompatibleStateImageBehavior = false;
            // 
            // lbTotal
            // 
            lbTotal.AutoSize = true;
            lbTotal.Location = new Point(15, 112);
            lbTotal.Name = "lbTotal";
            lbTotal.Size = new Size(45, 20);
            lbTotal.TabIndex = 8;
            lbTotal.Text = "Total:";
            // 
            // lbRecent
            // 
            lbRecent.AutoSize = true;
            lbRecent.Location = new Point(302, 112);
            lbRecent.Name = "lbRecent";
            lbRecent.Size = new Size(57, 20);
            lbRecent.TabIndex = 9;
            lbRecent.Text = "Recent:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Email, From, Time });
            dataGridView1.Location = new Point(15, 153);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(757, 285);
            dataGridView1.TabIndex = 10;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 300;
            // 
            // From
            // 
            From.HeaderText = "From";
            From.MinimumWidth = 6;
            From.Name = "From";
            From.Width = 200;
            // 
            // Time
            // 
            Time.HeaderText = "Time";
            Time.MinimumWidth = 6;
            Time.Name = "Time";
            Time.Width = 200;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(326, 448);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(148, 42);
            btnExit.TabIndex = 11;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(779, 502);
            Controls.Add(btnExit);
            Controls.Add(dataGridView1);
            Controls.Add(lbRecent);
            Controls.Add(lbTotal);
            Controls.Add(lstView);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "bai2";
            Text = "bai2";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPass;
        private Button btnLogin;
        private ListView lstView;
        private Label lbTotal;
        private Label lbRecent;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn Time;
        private Button btnExit;
    }
}