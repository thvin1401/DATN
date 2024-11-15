namespace SalesManagement
{
    partial class frmCreateUpdateAccount
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
            txtfullname = new TextBox();
            btnsave = new Button();
            dpkbirthday = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            lbltitle = new Label();
            txtemail = new TextBox();
            txtusername = new TextBox();
            txtpassword = new TextBox();
            txtpassword2 = new TextBox();
            txtphone = new TextBox();
            cmbisactive = new ComboBox();
            cmbtype = new ComboBox();
            btnback = new Button();
            label13 = new Label();
            txtaddress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 134);
            label1.Name = "label1";
            label1.Size = new Size(166, 21);
            label1.TabIndex = 0;
            label1.Text = "Full name (required)";
            // 
            // txtfullname
            // 
            txtfullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfullname.Location = new Point(383, 127);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(276, 29);
            txtfullname.TabIndex = 1;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(914, 590);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(86, 32);
            btnsave.TabIndex = 2;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // dpkbirthday
            // 
            dpkbirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbirthday.Location = new Point(914, 127);
            dpkbirthday.Name = "dpkbirthday";
            dpkbirthday.Size = new Size(276, 29);
            dpkbirthday.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(52, 265);
            label2.Name = "label2";
            label2.Size = new Size(168, 21);
            label2.TabIndex = 5;
            label2.Text = "Username (required)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(52, 336);
            label3.Name = "label3";
            label3.Size = new Size(163, 21);
            label3.TabIndex = 6;
            label3.Text = "Password (required)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(52, 408);
            label4.Name = "label4";
            label4.Size = new Size(254, 21);
            label4.TabIndex = 7;
            label4.Text = "Enter password again (required)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(52, 199);
            label5.Name = "label5";
            label5.Size = new Size(134, 21);
            label5.TabIndex = 8;
            label5.Text = "Email (required)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(740, 408);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 9;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(740, 199);
            label7.Name = "label7";
            label7.Size = new Size(59, 21);
            label7.TabIndex = 10;
            label7.Text = "Phone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(740, 134);
            label8.Name = "label8";
            label8.Size = new Size(75, 21);
            label8.TabIndex = 11;
            label8.Text = "Birthday";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(740, 336);
            label10.Name = "label10";
            label10.Size = new Size(72, 21);
            label10.TabIndex = 13;
            label10.Text = "Is active";
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(52, 35);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(311, 54);
            lbltitle.TabIndex = 15;
            lbltitle.Text = "Update account screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(383, 192);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(276, 29);
            txtemail.TabIndex = 16;
            // 
            // txtusername
            // 
            txtusername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtusername.Location = new Point(383, 258);
            txtusername.Name = "txtusername";
            txtusername.Size = new Size(276, 29);
            txtusername.TabIndex = 17;
            // 
            // txtpassword
            // 
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.Location = new Point(383, 329);
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '●';
            txtpassword.Size = new Size(276, 29);
            txtpassword.TabIndex = 18;
            // 
            // txtpassword2
            // 
            txtpassword2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword2.Location = new Point(383, 401);
            txtpassword2.Name = "txtpassword2";
            txtpassword2.PasswordChar = '●';
            txtpassword2.Size = new Size(276, 29);
            txtpassword2.TabIndex = 19;
            // 
            // txtphone
            // 
            txtphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtphone.Location = new Point(914, 192);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(276, 29);
            txtphone.TabIndex = 20;
            // 
            // cmbisactive
            // 
            cmbisactive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbisactive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbisactive.FormattingEnabled = true;
            cmbisactive.Location = new Point(914, 329);
            cmbisactive.Name = "cmbisactive";
            cmbisactive.Size = new Size(132, 29);
            cmbisactive.TabIndex = 21;
            // 
            // cmbtype
            // 
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtype.FormattingEnabled = true;
            cmbtype.Location = new Point(914, 400);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(132, 29);
            cmbtype.TabIndex = 23;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1075, 590);
            btnback.Name = "btnback";
            btnback.Size = new Size(82, 32);
            btnback.TabIndex = 24;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(740, 265);
            label13.Name = "label13";
            label13.Size = new Size(70, 21);
            label13.TabIndex = 26;
            label13.Text = "Address";
            // 
            // txtaddress
            // 
            txtaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(914, 258);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(276, 29);
            txtaddress.TabIndex = 27;
            // 
            // frmCreateUpdateAccount
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1258, 676);
            Controls.Add(txtaddress);
            Controls.Add(label13);
            Controls.Add(btnback);
            Controls.Add(cmbtype);
            Controls.Add(cmbisactive);
            Controls.Add(txtphone);
            Controls.Add(txtpassword2);
            Controls.Add(txtpassword);
            Controls.Add(txtusername);
            Controls.Add(txtemail);
            Controls.Add(lbltitle);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dpkbirthday);
            Controls.Add(btnsave);
            Controls.Add(txtfullname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateUpdateAccount";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "frmCreateUpdateAccount";
            Load += FrmCreateUpdateAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfullname;
        private Button btnsave;
        private DateTimePicker dpkbirthday;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label lbltitle;
        private TextBox txtemail;
        private TextBox txtusername;
        private TextBox txtpassword;
        private TextBox txtpassword2;
        private TextBox txtphone;
        private ComboBox cmbisactive;
        private ComboBox cmbtype;
        private Button btnback;
        private Label label13;
        private TextBox txtaddress;
    }
}