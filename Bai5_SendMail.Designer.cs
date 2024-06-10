namespace lab05
{
    partial class Bai5_SendMail
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
            rtbBody = new RichTextBox();
            label3 = new Label();
            btnSend = new Button();
            tbTo = new TextBox();
            tbFrom = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            tbName = new TextBox();
            SuspendLayout();
            // 
            // rtbBody
            // 
            rtbBody.Location = new Point(88, 130);
            rtbBody.Name = "rtbBody";
            rtbBody.Size = new Size(519, 308);
            rtbBody.TabIndex = 13;
            rtbBody.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 130);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 12;
            label3.Text = "Body";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(342, 59);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(94, 65);
            btnSend.TabIndex = 11;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbTo
            // 
            tbTo.Location = new Point(89, 95);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(247, 27);
            tbTo.TabIndex = 10;
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(89, 57);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(247, 27);
            tbFrom.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 98);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 8;
            label2.Text = "To";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 59);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 7;
            label1.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 20);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 14;
            label4.Text = "Name";
            // 
            // tbName
            // 
            tbName.Location = new Point(89, 20);
            tbName.Name = "tbName";
            tbName.Size = new Size(247, 27);
            tbName.TabIndex = 15;
            // 
            // Bai5_SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 450);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(rtbBody);
            Controls.Add(label3);
            Controls.Add(btnSend);
            Controls.Add(tbTo);
            Controls.Add(tbFrom);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Bai5_SendMail";
            Text = "Bai5_SendMail";
            Load += Bai5_SendMail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox rtbBody;
        private Label label3;
        private Button btnSend;
        private TextBox tbTo;
        private TextBox tbFrom;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox tbName;
    }
}