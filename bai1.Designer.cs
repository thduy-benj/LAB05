namespace lab05
{
    partial class Bai1
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
            btnSend = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtSubject = new TextBox();
            rtbBody = new RichTextBox();
            label5 = new Label();
            textBox1 = new TextBox();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Location = new Point(12, 26);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(84, 56);
            btnSend.TabIndex = 0;
            btnSend.Text = "SEND";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(135, 26);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 1;
            label1.Text = "From:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(135, 62);
            label2.Name = "label2";
            label2.Size = new Size(28, 20);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 3;
            label3.Text = "Subject:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 166);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 4;
            label4.Text = "Body:";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(214, 19);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(290, 27);
            txtFrom.TabIndex = 5;
         
            // 
            // txtTo
            // 
            txtTo.Location = new Point(214, 55);
            txtTo.Name = "txtTo";
            txtTo.Size = new Size(290, 27);
            txtTo.TabIndex = 6;
           
            // 
            // txtSubject
            // 
            txtSubject.Location = new Point(94, 133);
            txtSubject.Name = "txtSubject";
            txtSubject.Size = new Size(694, 27);
            txtSubject.TabIndex = 7;
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(94, 166);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(694, 272);
            rtbBody.TabIndex = 8;
            rtbBody.Text = "";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(135, 98);
            label5.Name = "label5";
            label5.Size = new Size(30, 20);
            label5.TabIndex = 9;
            label5.Text = "AP:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(214, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(290, 27);
            textBox1.TabIndex = 10;
        
            // 
            // btnExit
            // 
            btnExit.Location = new Point(392, 444);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(102, 44);
            btnExit.TabIndex = 11;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(849, 490);
            Controls.Add(btnExit);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(rtbBody);
            Controls.Add(txtSubject);
            Controls.Add(txtTo);
            Controls.Add(txtFrom);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSend);
            Name = "bai1";
            Text = "bai1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtSubject;
        private RichTextBox rtbBody;
        private Label label5;
        private TextBox textBox1;
        private Button btnExit;
    }
}