namespace lab05
{
    partial class Bai6_ViewMessage
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
            webView = new Microsoft.Web.WebView2.WinForms.WebView2();
            lable = new Label();
            label = new Label();
            tbFrom = new TextBox();
            tbTo = new TextBox();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)webView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // webView
            // 
            webView.AllowExternalDrop = true;
            webView.CreationProperties = null;
            webView.DefaultBackgroundColor = Color.White;
            webView.Dock = DockStyle.Fill;
            webView.Location = new Point(0, 88);
            webView.Name = "webView";
            webView.Size = new Size(800, 362);
            webView.TabIndex = 3;
            webView.ZoomFactor = 1D;
            // 
            // lable
            // 
            lable.AutoSize = true;
            lable.Location = new Point(11, 20);
            lable.Name = "lable";
            lable.Size = new Size(53, 23);
            lable.TabIndex = 0;
            lable.Text = "From:";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(11, 49);
            label.Name = "label";
            label.Size = new Size(30, 23);
            label.TabIndex = 1;
            label.Text = "to:";
            // 
            // tbFrom
            // 
            tbFrom.BackColor = SystemColors.Control;
            tbFrom.BorderStyle = BorderStyle.None;
            tbFrom.Location = new Point(90, 17);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(462, 23);
            tbFrom.TabIndex = 2;
            // 
            // tbTo
            // 
            tbTo.BackColor = SystemColors.Control;
            tbTo.BorderStyle = BorderStyle.None;
            tbTo.Location = new Point(90, 46);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(517, 23);
            tbTo.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbTo);
            groupBox1.Controls.Add(tbFrom);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(lable);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(800, 88);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // Bai6_ViewMessage
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webView);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Bai6_ViewMessage";
            Text = "Bai6_ViewMessage";
            ((System.ComponentModel.ISupportInitialize)webView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Microsoft.Web.WebView2.WinForms.WebView2 webView;
        private Label lable;
        private Label label;
        private TextBox tbFrom;
        private TextBox tbTo;
        private GroupBox groupBox1;
    }
}