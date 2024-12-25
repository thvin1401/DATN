namespace SalesManagement
{
    partial class frmPayDebt
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
            lbltitle = new Label();
            label1 = new Label();
            ckbisfullpaid = new CheckBox();
            cmbpaymentmethod = new ComboBox();
            txttotal = new TextBox();
            btnback = new Button();
            cmbpayee = new ComboBox();
            txtbankingamount = new TextBox();
            txtcashamount = new TextBox();
            btnpay = new Button();
            dpkpaidtime = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblstatus = new Label();
            label7 = new Label();
            label8 = new Label();
            btnreset = new Button();
            lbltype = new Label();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(28, 24);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 33;
            lbltitle.Text = "Debt adjustment screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 197);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 34;
            label1.Text = "Cash";
            // 
            // ckbisfullpaid
            // 
            ckbisfullpaid.AutoSize = true;
            ckbisfullpaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbisfullpaid.Location = new Point(387, 197);
            ckbisfullpaid.Name = "ckbisfullpaid";
            ckbisfullpaid.Size = new Size(120, 25);
            ckbisfullpaid.TabIndex = 35;
            ckbisfullpaid.Text = "Is full paid ?";
            ckbisfullpaid.UseVisualStyleBackColor = true;
            ckbisfullpaid.CheckedChanged += ckbisfullpaid_CheckedChanged;
            // 
            // cmbpaymentmethod
            // 
            cmbpaymentmethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpaymentmethod.FlatStyle = FlatStyle.Flat;
            cmbpaymentmethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbpaymentmethod.FormattingEnabled = true;
            cmbpaymentmethod.Location = new Point(131, 302);
            cmbpaymentmethod.Name = "cmbpaymentmethod";
            cmbpaymentmethod.Size = new Size(113, 29);
            cmbpaymentmethod.TabIndex = 36;
            cmbpaymentmethod.SelectedIndexChanged += cmbpaymentmethod_SelectedIndexChanged;
            // 
            // txttotal
            // 
            txttotal.BorderStyle = BorderStyle.FixedSingle;
            txttotal.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotal.Location = new Point(131, 250);
            txttotal.Name = "txttotal";
            txttotal.ReadOnly = true;
            txttotal.Size = new Size(219, 29);
            txttotal.TabIndex = 37;
            txttotal.KeyPress += txtnumeric_KeyPress;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(583, 291);
            btnback.Name = "btnback";
            btnback.Size = new Size(93, 36);
            btnback.TabIndex = 38;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // cmbpayee
            // 
            cmbpayee.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpayee.FlatStyle = FlatStyle.Flat;
            cmbpayee.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbpayee.FormattingEnabled = true;
            cmbpayee.Location = new Point(131, 92);
            cmbpayee.Name = "cmbpayee";
            cmbpayee.Size = new Size(545, 29);
            cmbpayee.TabIndex = 39;
            // 
            // txtbankingamount
            // 
            txtbankingamount.BorderStyle = BorderStyle.FixedSingle;
            txtbankingamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtbankingamount.Location = new Point(131, 141);
            txtbankingamount.Name = "txtbankingamount";
            txtbankingamount.Size = new Size(219, 29);
            txtbankingamount.TabIndex = 40;
            txtbankingamount.TextChanged += txtbankingamount_TextChanged;
            txtbankingamount.KeyPress += txtnumeric_KeyPress;
            txtbankingamount.Leave += txtbankingamount_Leave;
            // 
            // txtcashamount
            // 
            txtcashamount.BorderStyle = BorderStyle.FixedSingle;
            txtcashamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcashamount.Location = new Point(131, 195);
            txtcashamount.Name = "txtcashamount";
            txtcashamount.Size = new Size(219, 29);
            txtcashamount.TabIndex = 41;
            txtcashamount.TextChanged += txtcashamount_TextChanged;
            txtcashamount.KeyPress += txtnumeric_KeyPress;
            txtcashamount.Leave += txtcashamount_Leave;
            // 
            // btnpay
            // 
            btnpay.BackColor = Color.OrangeRed;
            btnpay.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnpay.Location = new Point(387, 243);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(180, 88);
            btnpay.TabIndex = 42;
            btnpay.Text = "Pay";
            btnpay.UseVisualStyleBackColor = false;
            btnpay.Click += btnpay_Click;
            // 
            // dpkpaidtime
            // 
            dpkpaidtime.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkpaidtime.Location = new Point(476, 143);
            dpkpaidtime.Name = "dpkpaidtime";
            dpkpaidtime.Size = new Size(200, 23);
            dpkpaidtime.TabIndex = 43;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 143);
            label2.Name = "label2";
            label2.Size = new Size(73, 21);
            label2.TabIndex = 44;
            label2.Text = "Banking";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 252);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 45;
            label3.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(513, 198);
            label4.Name = "label4";
            label4.Size = new Size(65, 21);
            label4.TabIndex = 46;
            label4.Text = "Status :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(387, 144);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 47;
            label5.Text = "Paid time";
            // 
            // lblstatus
            // 
            lblstatus.AutoSize = true;
            lblstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblstatus.Location = new Point(583, 198);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(93, 21);
            lblstatus.TabIndex = 48;
            lblstatus.Text = "Partly paid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(28, 95);
            label7.Name = "label7";
            label7.Size = new Size(56, 21);
            label7.TabIndex = 49;
            label7.Text = "Payee";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(28, 305);
            label8.Name = "label8";
            label8.Size = new Size(70, 21);
            label8.TabIndex = 50;
            label8.Text = "Method";
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnreset.Location = new Point(583, 243);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(93, 36);
            btnreset.TabIndex = 51;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltype.Location = new Point(624, 53);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(52, 21);
            lbltype.TabIndex = 52;
            lbltype.Text = "LEND";
            // 
            // frmPayDebt
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(695, 351);
            ControlBox = false;
            Controls.Add(lbltype);
            Controls.Add(btnreset);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lblstatus);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dpkpaidtime);
            Controls.Add(btnpay);
            Controls.Add(txtcashamount);
            Controls.Add(txtbankingamount);
            Controls.Add(cmbpayee);
            Controls.Add(btnback);
            Controls.Add(txttotal);
            Controls.Add(cmbpaymentmethod);
            Controls.Add(ckbisfullpaid);
            Controls.Add(label1);
            Controls.Add(lbltitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPayDebt";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmPayDebt_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label label1;
        private CheckBox ckbisfullpaid;
        private ComboBox cmbpaymentmethod;
        private TextBox txttotal;
        private Button btnback;
        private ComboBox cmbpayee;
        private TextBox txtbankingamount;
        private TextBox txtcashamount;
        private Button btnpay;
        private DateTimePicker dpkpaidtime;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblstatus;
        private Label label7;
        private Label label8;
        private Button btnreset;
        private Label lbltype;
    }
}