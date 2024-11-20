namespace SalesManagement
{
    partial class frmResetPassword
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
            txtusername = new TextBox();
            btnResetpw = new Button();
            btnBack = new Button();
            txtemail = new TextBox();
            lblGuide = new Label();
            lbltitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 116);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(77, 198);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // txtusername
            // 
            txtusername.BorderStyle = BorderStyle.FixedSingle;
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(196, 114);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(238, 29);
            txtusername.TabIndex = 2;
            // 
            // btnResetpw
            // 
            btnResetpw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetpw.Location = new Point(77, 337);
            btnResetpw.Name = "btnResetpw";
            btnResetpw.Size = new Size(75, 37);
            btnResetpw.TabIndex = 3;
            btnResetpw.Text = "Reset";
            btnResetpw.UseVisualStyleBackColor = true;
            btnResetpw.Click += btnResetpw_Click;
            // 
            // btnBack
            // 
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.Location = new Point(359, 337);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 37);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(196, 190);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(238, 29);
            txtemail.TabIndex = 5;
            // 
            // lblGuide
            // 
            lblGuide.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lblGuide.Location = new Point(31, 295);
            lblGuide.Name = "lblGuide";
            lblGuide.Size = new Size(465, 15);
            lblGuide.TabIndex = 6;
            lblGuide.Text = "To reset password, please enter your username and email adress used to create account";
            lblGuide.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(31, 28);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 32;
            lbltitle.Text = "Reset password screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmResetPassword
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(526, 404);
            ControlBox = false;
            Controls.Add(lbltitle);
            Controls.Add(lblGuide);
            Controls.Add(txtemail);
            Controls.Add(btnBack);
            Controls.Add(btnResetpw);
            Controls.Add(txtusername);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResetPassword";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtusername;
        private Button btnResetpw;
        private Button btnBack;
        private TextBox txtemail;
        private Label lblGuide;
        private Label lbltitle;
    }
}