namespace lab05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbMail = new TextBox();
            tbPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnRead = new Button();
            dataGridView1 = new DataGridView();
            column_email = new DataGridViewTextBoxColumn();
            column_from = new DataGridViewTextBoxColumn();
            column_time = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tbMail
            // 
            tbMail.Location = new Point(138, 51);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(416, 39);
            tbMail.TabIndex = 0;
            tbMail.Text = "bintrunglong@gmail.com";
            // 
            // tbPass
            // 
            tbPass.Location = new Point(138, 138);
            tbPass.Name = "tbPass";
            tbPass.PasswordChar = '*';
            tbPass.Size = new Size(416, 39);
            tbPass.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 54);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 2;
            label1.Text = "Mail:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 138);
            label2.Name = "label2";
            label2.Size = new Size(116, 32);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(581, 77);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(174, 75);
            btnRead.TabIndex = 4;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { column_email, column_from, column_time });
            dataGridView1.Location = new Point(39, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(683, 471);
            dataGridView1.TabIndex = 5;
            // 
            // column_email
            // 
            column_email.HeaderText = "Email";
            column_email.MinimumWidth = 10;
            column_email.Name = "column_email";
            column_email.ReadOnly = true;
            column_email.Resizable = DataGridViewTriState.False;
            column_email.Width = 200;
            // 
            // column_from
            // 
            column_from.HeaderText = "From";
            column_from.MinimumWidth = 10;
            column_from.Name = "column_from";
            column_from.ReadOnly = true;
            column_from.Resizable = DataGridViewTriState.False;
            column_from.Width = 200;
            // 
            // column_time
            // 
            column_time.HeaderText = "Time";
            column_time.MinimumWidth = 10;
            column_time.Name = "column_time";
            column_time.ReadOnly = true;
            column_time.Resizable = DataGridViewTriState.False;
            column_time.Width = 200;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 740);
            Controls.Add(dataGridView1);
            Controls.Add(btnRead);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPass);
            Controls.Add(tbMail);
            Name = "Form1";
            Text = "Bai3";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbMail;
        private TextBox tbPass;
        private Label label1;
        private Label label2;
        private Button btnRead;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn column_email;
        private DataGridViewTextBoxColumn column_from;
        private DataGridViewTextBoxColumn column_time;
    }
}
