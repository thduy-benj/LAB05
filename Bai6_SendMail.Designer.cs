namespace lab05
{
    partial class Bai6_SendMail
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbFrom = new TextBox();
            tbName = new TextBox();
            tbTo = new TextBox();
            tbSub = new TextBox();
            content = new TextBox();
            cbHTML = new CheckBox();
            label6 = new Label();
            tbFilePath = new TextBox();
            btnBrowse = new Button();
            btnSend = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 19);
            label1.Name = "label1";
            label1.Size = new Size(49, 23);
            label1.TabIndex = 0;
            label1.Text = "From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 64);
            label2.Name = "label2";
            label2.Size = new Size(56, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 109);
            label3.Name = "label3";
            label3.Size = new Size(27, 23);
            label3.TabIndex = 2;
            label3.Text = "To";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 153);
            label4.Name = "label4";
            label4.Size = new Size(66, 23);
            label4.TabIndex = 3;
            label4.Text = "Subject";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 206);
            label5.Name = "label5";
            label5.Size = new Size(48, 23);
            label5.TabIndex = 4;
            label5.Text = "Body";
            // 
            // tbFrom
            // 
            tbFrom.Location = new Point(122, 12);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(428, 30);
            tbFrom.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(122, 58);
            tbName.Name = "tbName";
            tbName.Size = new Size(428, 30);
            tbName.TabIndex = 6;
            // 
            // tbTo
            // 
            tbTo.Location = new Point(122, 103);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(428, 30);
            tbTo.TabIndex = 7;
            // 
            // tbSub
            // 
            tbSub.Location = new Point(122, 147);
            tbSub.Name = "tbSub";
            tbSub.Size = new Size(428, 30);
            tbSub.TabIndex = 8;
            // 
            // content
            // 
            content.BorderStyle = BorderStyle.FixedSingle;
            content.Location = new Point(122, 257);
            content.Multiline = true;
            content.Name = "content";
            content.Size = new Size(428, 338);
            content.TabIndex = 10;
            // 
            // cbHTML
            // 
            cbHTML.AutoSize = true;
            cbHTML.Location = new Point(122, 206);
            cbHTML.Name = "cbHTML";
            cbHTML.Size = new Size(76, 27);
            cbHTML.TabIndex = 11;
            cbHTML.Text = "HTML";
            cbHTML.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 607);
            label6.Name = "label6";
            label6.Size = new Size(100, 23);
            label6.TabIndex = 12;
            label6.Text = "Attachment";
            // 
            // tbFilePath
            // 
            tbFilePath.Location = new Point(151, 601);
            tbFilePath.Name = "tbFilePath";
            tbFilePath.Size = new Size(281, 30);
            tbFilePath.TabIndex = 13;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(438, 601);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(112, 34);
            btnBrowse.TabIndex = 14;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnSend
            // 
            btnSend.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnSend.Location = new Point(396, 650);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(154, 34);
            btnSend.TabIndex = 15;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // Bai6_SendMail
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(571, 699);
            Controls.Add(btnSend);
            Controls.Add(btnBrowse);
            Controls.Add(tbFilePath);
            Controls.Add(label6);
            Controls.Add(cbHTML);
            Controls.Add(content);
            Controls.Add(tbSub);
            Controls.Add(tbTo);
            Controls.Add(tbName);
            Controls.Add(tbFrom);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Bai6_SendMail";
            Text = "Bai6_SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbFrom;
        private TextBox tbName;
        private TextBox tbTo;
        private TextBox tbSub;
        private TextBox content;
        private CheckBox cbHTML;
        private Label label6;
        private TextBox tbFilePath;
        private Button btnBrowse;
        private Button btnSend;
    }
}