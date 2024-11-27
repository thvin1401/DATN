namespace SalesManagement
{
    partial class frmCreateDebt
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
            txtamount = new TextBox();
            cmbactor = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnback = new Button();
            cmbstatus = new ComboBox();
            ckbisloan = new CheckBox();
            dpkprocessedtime = new DateTimePicker();
            dpkpaidtime = new DateTimePicker();
            ckbcircleinterest = new CheckBox();
            label6 = new Label();
            label7 = new Label();
            txtcircle = new TextBox();
            txtinterest = new TextBox();
            btnreset = new Button();
            btnsave = new Button();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtpaidafter = new TextBox();
            label11 = new Label();
            label12 = new Label();
            cmbpaymentmethod = new ComboBox();
            lblfullpaid = new Label();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(26, 22);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(291, 50);
            lbltitle.TabIndex = 30;
            lbltitle.Text = "Debt create screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(26, 99);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 31;
            label1.Text = "Actor";
            // 
            // txtamount
            // 
            txtamount.BorderStyle = BorderStyle.FixedSingle;
            txtamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtamount.Location = new Point(125, 153);
            txtamount.Name = "txtamount";
            txtamount.Size = new Size(182, 29);
            txtamount.TabIndex = 32;
            txtamount.KeyPress += txtnumeric_KeyPress;
            txtamount.Leave += txtamount_Leave;
            // 
            // cmbactor
            // 
            cmbactor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbactor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbactor.FormattingEnabled = true;
            cmbactor.Location = new Point(125, 96);
            cmbactor.Name = "cmbactor";
            cmbactor.Size = new Size(221, 29);
            cmbactor.TabIndex = 33;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(26, 262);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 34;
            label2.Text = "Circle";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(26, 155);
            label3.Name = "label3";
            label3.Size = new Size(72, 21);
            label3.TabIndex = 35;
            label3.Text = "Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(26, 323);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 36;
            label4.Text = "Interest";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(373, 99);
            label5.Name = "label5";
            label5.Size = new Size(57, 21);
            label5.TabIndex = 37;
            label5.Text = "Status";
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(660, 321);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 34);
            btnback.TabIndex = 38;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // cmbstatus
            // 
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(535, 96);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(200, 29);
            cmbstatus.TabIndex = 39;
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
            // 
            // ckbisloan
            // 
            ckbisloan.AutoSize = true;
            ckbisloan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbisloan.Location = new Point(373, 207);
            ckbisloan.Name = "ckbisloan";
            ckbisloan.Size = new Size(90, 25);
            ckbisloan.TabIndex = 40;
            ckbisloan.Text = "Is loan ?";
            ckbisloan.UseVisualStyleBackColor = true;
            // 
            // dpkprocessedtime
            // 
            dpkprocessedtime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkprocessedtime.Location = new Point(535, 153);
            dpkprocessedtime.Name = "dpkprocessedtime";
            dpkprocessedtime.Size = new Size(200, 29);
            dpkprocessedtime.TabIndex = 41;
            // 
            // dpkpaidtime
            // 
            dpkpaidtime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkpaidtime.Location = new Point(535, 260);
            dpkpaidtime.Name = "dpkpaidtime";
            dpkpaidtime.Size = new Size(200, 29);
            dpkpaidtime.TabIndex = 42;
            // 
            // ckbcircleinterest
            // 
            ckbcircleinterest.AutoSize = true;
            ckbcircleinterest.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbcircleinterest.Location = new Point(26, 207);
            ckbcircleinterest.Name = "ckbcircleinterest";
            ckbcircleinterest.Size = new Size(152, 25);
            ckbcircleinterest.TabIndex = 44;
            ckbcircleinterest.Text = "Circle/ Interest ?";
            ckbcircleinterest.UseVisualStyleBackColor = true;
            ckbcircleinterest.CheckedChanged += ckbcircleinterest_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(373, 155);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 45;
            label6.Text = "Processed Time";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(373, 262);
            label7.Name = "label7";
            label7.Size = new Size(86, 21);
            label7.TabIndex = 46;
            label7.Text = "Paid Time";
            // 
            // txtcircle
            // 
            txtcircle.BorderStyle = BorderStyle.FixedSingle;
            txtcircle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcircle.Location = new Point(125, 260);
            txtcircle.Name = "txtcircle";
            txtcircle.Size = new Size(182, 29);
            txtcircle.TabIndex = 47;
            txtcircle.KeyPress += txtnumeric_KeyPress;
            // 
            // txtinterest
            // 
            txtinterest.BorderStyle = BorderStyle.FixedSingle;
            txtinterest.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtinterest.Location = new Point(125, 321);
            txtinterest.Name = "txtinterest";
            txtinterest.Size = new Size(182, 29);
            txtinterest.TabIndex = 48;
            txtinterest.KeyPress += txtnumeric_KeyPress;
            // 
            // btnreset
            // 
            btnreset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnreset.Location = new Point(545, 321);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(75, 34);
            btnreset.TabIndex = 49;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(426, 321);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 34);
            btnsave.TabIndex = 50;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(313, 167);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 51;
            label8.Text = "VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(313, 274);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 52;
            label9.Text = "Days";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(313, 335);
            label10.Name = "label10";
            label10.Size = new Size(17, 15);
            label10.TabIndex = 53;
            label10.Text = "%";
            // 
            // txtpaidafter
            // 
            txtpaidafter.BorderStyle = BorderStyle.FixedSingle;
            txtpaidafter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpaidafter.Location = new Point(268, 203);
            txtpaidafter.Name = "txtpaidafter";
            txtpaidafter.Size = new Size(39, 29);
            txtpaidafter.TabIndex = 54;
            txtpaidafter.KeyPress += txtnumeric_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(313, 217);
            label11.Name = "label11";
            label11.Size = new Size(33, 15);
            label11.TabIndex = 55;
            label11.Text = "Days";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(178, 208);
            label12.Name = "label12";
            label12.Size = new Size(84, 21);
            label12.TabIndex = 56;
            label12.Text = "Paid after";
            // 
            // cmbpaymentmethod
            // 
            cmbpaymentmethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpaymentmethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbpaymentmethod.FormattingEnabled = true;
            cmbpaymentmethod.Location = new Point(618, 202);
            cmbpaymentmethod.Name = "cmbpaymentmethod";
            cmbpaymentmethod.Size = new Size(117, 29);
            cmbpaymentmethod.TabIndex = 57;
            // 
            // lblfullpaid
            // 
            lblfullpaid.AutoSize = true;
            lblfullpaid.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblfullpaid.ForeColor = Color.LimeGreen;
            lblfullpaid.Location = new Point(535, 205);
            lblfullpaid.Name = "lblfullpaid";
            lblfullpaid.Size = new Size(76, 21);
            lblfullpaid.TabIndex = 58;
            lblfullpaid.Text = "Full paid";
            // 
            // frmCreateDebt
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(758, 373);
            ControlBox = false;
            Controls.Add(lblfullpaid);
            Controls.Add(cmbpaymentmethod);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(txtpaidafter);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(btnsave);
            Controls.Add(btnreset);
            Controls.Add(txtinterest);
            Controls.Add(txtcircle);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(ckbcircleinterest);
            Controls.Add(dpkpaidtime);
            Controls.Add(dpkprocessedtime);
            Controls.Add(ckbisloan);
            Controls.Add(cmbstatus);
            Controls.Add(btnback);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbactor);
            Controls.Add(txtamount);
            Controls.Add(label1);
            Controls.Add(lbltitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateDebt";
            StartPosition = FormStartPosition.CenterParent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label label1;
        private TextBox txtamount;
        private ComboBox cmbactor;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnback;
        private ComboBox cmbstatus;
        private CheckBox ckbisloan;
        private DateTimePicker dpkprocessedtime;
        private DateTimePicker dpkpaidtime;
        private CheckBox ckbcircleinterest;
        private Label label6;
        private Label label7;
        private TextBox txtcircle;
        private TextBox txtinterest;
        private Button btnreset;
        private Button btnsave;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtpaidafter;
        private Label label11;
        private Label label12;
        private ComboBox cmbpaymentmethod;
        private Label lblfullpaid;
    }
}