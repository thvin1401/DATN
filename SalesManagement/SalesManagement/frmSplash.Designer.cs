namespace SalesManagement
{
    partial class frmSplash
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
            picSplash = new Panel();
            label1 = new Label();
            ltlTitle = new Label();
            lblMessage = new Label();
            picSplash.SuspendLayout();
            SuspendLayout();
            // 
            // picSplash
            // 
            picSplash.BackColor = Color.SkyBlue;
            picSplash.Controls.Add(label1);
            picSplash.Controls.Add(ltlTitle);
            picSplash.Location = new Point(-1, -1);
            picSplash.Name = "picSplash";
            picSplash.Size = new Size(481, 227);
            picSplash.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Gothic", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(353, 25);
            label1.Name = "label1";
            label1.Size = new Size(101, 24);
            label1.TabIndex = 1;
            label1.Text = "Ver 1.0";
            // 
            // ltlTitle
            // 
            ltlTitle.AutoSize = true;
            ltlTitle.Font = new Font("MS Gothic", 30F, FontStyle.Bold);
            ltlTitle.ForeColor = SystemColors.ButtonHighlight;
            ltlTitle.Location = new Point(63, 92);
            ltlTitle.Name = "ltlTitle";
            ltlTitle.Size = new Size(353, 40);
            ltlTitle.TabIndex = 0;
            ltlTitle.Text = "Sales Management";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("MS Gothic", 12F);
            lblMessage.Location = new Point(22, 240);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(135, 16);
            lblMessage.TabIndex = 1;
            lblMessage.Text = "label message...";
            // 
            // frmSplash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 274);
            Controls.Add(lblMessage);
            Controls.Add(picSplash);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSplash";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmSplash";
            picSplash.ResumeLayout(false);
            picSplash.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Panel picSplash;
        public Label lblMessage;
        public Label ltlTitle;
        public Label label1;
    }
}