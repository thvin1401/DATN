namespace SalesManagement
{
    partial class frmCreateUpdateUserinfo
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
            txtaddress = new TextBox();
            txtphone = new TextBox();
            txtemail = new TextBox();
            txtpoint = new TextBox();
            cmbrank = new ComboBox();
            cmbtype = new ComboBox();
            cmbisactive = new ComboBox();
            btnsave = new Button();
            btnback = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            dpkbirthday = new DateTimePicker();
            lbltitle = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(44, 105);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtfullname
            // 
            txtfullname.BorderStyle = BorderStyle.FixedSingle;
            txtfullname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtfullname.Location = new Point(141, 103);
            txtfullname.Margin = new Padding(4, 2, 4, 2);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(277, 29);
            txtfullname.TabIndex = 9;
            // 
            // txtaddress
            // 
            txtaddress.BorderStyle = BorderStyle.FixedSingle;
            txtaddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtaddress.Location = new Point(141, 169);
            txtaddress.Margin = new Padding(4, 2, 4, 2);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(277, 29);
            txtaddress.TabIndex = 10;
            // 
            // txtphone
            // 
            txtphone.BorderStyle = BorderStyle.FixedSingle;
            txtphone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtphone.Location = new Point(141, 238);
            txtphone.Margin = new Padding(4, 2, 4, 2);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(277, 29);
            txtphone.TabIndex = 11;
            txtphone.KeyPress += txtphone_KeyPress;
            // 
            // txtemail
            // 
            txtemail.BorderStyle = BorderStyle.FixedSingle;
            txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.Location = new Point(141, 311);
            txtemail.Margin = new Padding(4, 2, 4, 2);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(277, 29);
            txtemail.TabIndex = 12;
            // 
            // txtpoint
            // 
            txtpoint.BorderStyle = BorderStyle.FixedSingle;
            txtpoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpoint.Location = new Point(590, 103);
            txtpoint.Margin = new Padding(4, 2, 4, 2);
            txtpoint.Name = "txtpoint";
            txtpoint.Size = new Size(171, 29);
            txtpoint.TabIndex = 14;
            // 
            // cmbrank
            // 
            cmbrank.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbrank.FlatStyle = FlatStyle.Flat;
            cmbrank.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbrank.FormattingEnabled = true;
            cmbrank.Location = new Point(590, 168);
            cmbrank.Margin = new Padding(4, 2, 4, 2);
            cmbrank.Name = "cmbrank";
            cmbrank.Size = new Size(171, 29);
            cmbrank.TabIndex = 15;
            // 
            // cmbtype
            // 
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtype.FlatStyle = FlatStyle.Flat;
            cmbtype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtype.FormattingEnabled = true;
            cmbtype.Location = new Point(590, 237);
            cmbtype.Margin = new Padding(4, 2, 4, 2);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(171, 29);
            cmbtype.TabIndex = 16;
            // 
            // cmbisactive
            // 
            cmbisactive.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbisactive.FlatStyle = FlatStyle.Flat;
            cmbisactive.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbisactive.FormattingEnabled = true;
            cmbisactive.Location = new Point(590, 310);
            cmbisactive.Margin = new Padding(4, 2, 4, 2);
            cmbisactive.Name = "cmbisactive";
            cmbisactive.Size = new Size(171, 29);
            cmbisactive.TabIndex = 17;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(495, 393);
            btnsave.Margin = new Padding(4, 2, 4, 2);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 34);
            btnsave.TabIndex = 18;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(686, 393);
            btnback.Margin = new Padding(4, 2, 4, 2);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 34);
            btnback.TabIndex = 19;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(44, 171);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 20;
            label2.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(44, 240);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(59, 21);
            label3.TabIndex = 21;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(44, 313);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(53, 21);
            label4.TabIndex = 22;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(44, 399);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 23;
            label5.Text = "Birthday";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(496, 105);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 21);
            label6.TabIndex = 24;
            label6.Text = "Point";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(496, 171);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(48, 21);
            label7.TabIndex = 25;
            label7.Text = "Rank";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(496, 240);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(46, 21);
            label8.TabIndex = 26;
            label8.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(496, 313);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(74, 21);
            label9.TabIndex = 27;
            label9.Text = "Is Active";
            // 
            // dpkbirthday
            // 
            dpkbirthday.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbirthday.Location = new Point(141, 393);
            dpkbirthday.Margin = new Padding(4, 2, 4, 2);
            dpkbirthday.Name = "dpkbirthday";
            dpkbirthday.Size = new Size(277, 29);
            dpkbirthday.TabIndex = 28;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(44, 24);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(291, 50);
            lbltitle.TabIndex = 29;
            lbltitle.Text = "User update screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmCreateUpdateUserinfo
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(788, 447);
            ControlBox = false;
            Controls.Add(lbltitle);
            Controls.Add(dpkbirthday);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(cmbisactive);
            Controls.Add(cmbtype);
            Controls.Add(cmbrank);
            Controls.Add(txtpoint);
            Controls.Add(txtemail);
            Controls.Add(txtphone);
            Controls.Add(txtaddress);
            Controls.Add(txtfullname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateUpdateUserinfo";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Load += frmCreateUpdateUserinfo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtfullname;
        private TextBox txtaddress;
        private TextBox txtphone;
        private TextBox txtemail;
        private TextBox txtpoint;
        private ComboBox cmbrank;
        private ComboBox cmbtype;
        private ComboBox cmbisactive;
        private Button btnsave;
        private Button btnback;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private DateTimePicker dpkbirthday;
        private Label lbltitle;
    }
}