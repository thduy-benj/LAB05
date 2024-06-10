namespace lab05
{
    partial class Bai5
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
            btnLoad = new Button();
            btnAdd = new Button();
            lvMonAn = new ListView();
            label1 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            tbEmail = new TextBox();
            btnSignIn = new Button();
            btnRandom = new Button();
            SuspendLayout();
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(12, 93);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 1;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(112, 93);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lvMonAn
            // 
            lvMonAn.Location = new Point(12, 128);
            lvMonAn.Name = "lvMonAn";
            lvMonAn.Size = new Size(607, 310);
            lvMonAn.TabIndex = 3;
            lvMonAn.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 43);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(93, 36);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(203, 27);
            tbPassword.TabIndex = 6;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(93, 6);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(203, 27);
            tbEmail.TabIndex = 7;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(302, 8);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(94, 55);
            btnSignIn.TabIndex = 8;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnRandom
            // 
            btnRandom.Location = new Point(212, 93);
            btnRandom.Name = "btnRandom";
            btnRandom.Size = new Size(94, 29);
            btnRandom.TabIndex = 9;
            btnRandom.Text = "Random";
            btnRandom.UseVisualStyleBackColor = true;
            btnRandom.Click += btnRandom_Click;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 450);
            Controls.Add(btnRandom);
            Controls.Add(btnSignIn);
            Controls.Add(tbEmail);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lvMonAn);
            Controls.Add(btnAdd);
            Controls.Add(btnLoad);
            Name = "Bai5";
            Text = "Bai5";
            Load += Bai5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnLoad;
        private Button btnAdd;
        private ListView lvMonAn;
        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbEmail;
        private Button btnSignIn;
        private Button btnRandom;
    }
}