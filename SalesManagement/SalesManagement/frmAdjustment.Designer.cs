namespace SalesManagement
{
    partial class frmAdjustment
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
            btnback = new Button();
            grdsales = new DataGridView();
            grdheader = new DataGridView();
            grdproduct = new DataGridView();
            lbltitle = new Label();
            txtcashamount = new TextBox();
            txtotherspayamount = new TextBox();
            cmbpaymentmethod = new ComboBox();
            btnadjustment = new Button();
            txttotalprice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtchange = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cmbpaymenttype = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtreceiptnumber = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            txttype = new TextBox();
            label21 = new Label();
            label20 = new Label();
            button2 = new Button();
            dpkbirthday = new DateTimePicker();
            txtrank = new TextBox();
            label19 = new Label();
            label18 = new Label();
            txtpoint = new TextBox();
            txtemail = new TextBox();
            txtphone = new TextBox();
            txtaddress = new TextBox();
            txtfullname = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            cmbuserinfoname = new ComboBox();
            btnsearch = new Button();
            label12 = new Label();
            txtsearch = new TextBox();
            btncanceltrans = new Button();
            btnclear = new Button();
            ((System.ComponentModel.ISupportInitialize)grdsales).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdproduct).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1164, 608);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 31);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // grdsales
            // 
            grdsales.AllowUserToAddRows = false;
            grdsales.AllowUserToDeleteRows = false;
            grdsales.AllowUserToResizeColumns = false;
            grdsales.AllowUserToResizeRows = false;
            grdsales.BackgroundColor = SystemColors.Control;
            grdsales.BorderStyle = BorderStyle.Fixed3D;
            grdsales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdsales.ColumnHeadersVisible = false;
            grdsales.Location = new Point(23, 120);
            grdsales.Margin = new Padding(0);
            grdsales.Name = "grdsales";
            grdsales.ReadOnly = true;
            grdsales.RowHeadersVisible = false;
            grdsales.RowTemplate.Height = 25;
            grdsales.Size = new Size(712, 246);
            grdsales.TabIndex = 1;
            grdsales.CellContentClick += grdsales_CellContentClick;
            grdsales.CellDoubleClick += grdsales_CellDoubleClick;
            grdsales.CellMouseEnter += grdsales_CellMouseEnter;
            grdsales.CellMouseLeave += grdsales_CellMouseLeave;
            grdsales.CellPainting += grdsales_CellPainting;
            grdsales.CellValueChanged += grdsales_CellValueChanged;
            grdsales.RowsAdded += grdsales_RowsAdded;
            grdsales.RowsRemoved += grdsales_RowsRemoved;
            // 
            // grdheader
            // 
            grdheader.AllowUserToAddRows = false;
            grdheader.AllowUserToDeleteRows = false;
            grdheader.AllowUserToResizeColumns = false;
            grdheader.AllowUserToResizeRows = false;
            grdheader.BackgroundColor = SystemColors.Control;
            grdheader.BorderStyle = BorderStyle.Fixed3D;
            grdheader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdheader.ColumnHeadersVisible = false;
            grdheader.Location = new Point(23, 90);
            grdheader.Margin = new Padding(0);
            grdheader.Name = "grdheader";
            grdheader.ReadOnly = true;
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(712, 32);
            grdheader.TabIndex = 2;
            // 
            // grdproduct
            // 
            grdproduct.AllowUserToAddRows = false;
            grdproduct.AllowUserToDeleteRows = false;
            grdproduct.AllowUserToResizeColumns = false;
            grdproduct.AllowUserToResizeRows = false;
            grdproduct.BackgroundColor = SystemColors.Control;
            grdproduct.BorderStyle = BorderStyle.Fixed3D;
            grdproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdproduct.ColumnHeadersVisible = false;
            grdproduct.Location = new Point(741, 372);
            grdproduct.Margin = new Padding(0);
            grdproduct.Name = "grdproduct";
            grdproduct.ReadOnly = true;
            grdproduct.RowHeadersVisible = false;
            grdproduct.RowTemplate.Height = 25;
            grdproduct.Size = new Size(498, 210);
            grdproduct.TabIndex = 3;
            grdproduct.CellDoubleClick += grdproduct_CellDoubleClick;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(23, 19);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(311, 54);
            lbltitle.TabIndex = 16;
            lbltitle.Text = "Adjustment screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtcashamount
            // 
            txtcashamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcashamount.Location = new Point(120, 63);
            txtcashamount.Name = "txtcashamount";
            txtcashamount.Size = new Size(340, 29);
            txtcashamount.TabIndex = 17;
            // 
            // txtotherspayamount
            // 
            txtotherspayamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtotherspayamount.Location = new Point(120, 16);
            txtotherspayamount.Name = "txtotherspayamount";
            txtotherspayamount.Size = new Size(340, 29);
            txtotherspayamount.TabIndex = 18;
            // 
            // cmbpaymentmethod
            // 
            cmbpaymentmethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpaymentmethod.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbpaymentmethod.FormattingEnabled = true;
            cmbpaymentmethod.Location = new Point(120, 206);
            cmbpaymentmethod.Name = "cmbpaymentmethod";
            cmbpaymentmethod.Size = new Size(121, 29);
            cmbpaymentmethod.TabIndex = 19;
            // 
            // btnadjustment
            // 
            btnadjustment.BackColor = Color.OrangeRed;
            btnadjustment.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnadjustment.ForeColor = SystemColors.ControlText;
            btnadjustment.Location = new Point(272, 206);
            btnadjustment.Name = "btnadjustment";
            btnadjustment.Size = new Size(225, 107);
            btnadjustment.TabIndex = 20;
            btnadjustment.Text = "Adjustment";
            btnadjustment.UseVisualStyleBackColor = false;
            btnadjustment.Click += btnadjustment_Click;
            // 
            // txttotalprice
            // 
            txttotalprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalprice.Location = new Point(120, 111);
            txttotalprice.Name = "txttotalprice";
            txttotalprice.Size = new Size(340, 29);
            txttotalprice.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 21);
            label1.TabIndex = 22;
            label1.Text = "Others";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(22, 66);
            label2.Name = "label2";
            label2.Size = new Size(44, 21);
            label2.TabIndex = 23;
            label2.Text = "Cash";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(24, 114);
            label3.Name = "label3";
            label3.Size = new Size(42, 21);
            label3.TabIndex = 24;
            label3.Text = "Total";
            // 
            // txtchange
            // 
            txtchange.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtchange.Location = new Point(120, 159);
            txtchange.Name = "txtchange";
            txtchange.Size = new Size(340, 29);
            txtchange.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(22, 162);
            label4.Name = "label4";
            label4.Size = new Size(63, 21);
            label4.TabIndex = 26;
            label4.Text = "Change";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(22, 209);
            label5.Name = "label5";
            label5.Size = new Size(64, 21);
            label5.TabIndex = 27;
            label5.Text = "Method";
            // 
            // cmbpaymenttype
            // 
            cmbpaymenttype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbpaymenttype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbpaymenttype.FormattingEnabled = true;
            cmbpaymenttype.Location = new Point(120, 254);
            cmbpaymenttype.Name = "cmbpaymenttype";
            cmbpaymenttype.Size = new Size(121, 29);
            cmbpaymenttype.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(22, 257);
            label6.Name = "label6";
            label6.Size = new Size(42, 21);
            label6.TabIndex = 29;
            label6.Text = "Type";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 30);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 30;
            label7.Text = "VND";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 82);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 31;
            label8.Text = "VND";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(466, 130);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 32;
            label9.Text = "VND";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 173);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 33;
            label10.Text = "VND";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(391, 50);
            label11.Name = "label11";
            label11.Size = new Size(120, 21);
            label11.TabIndex = 34;
            label11.Text = "Receipt number";
            // 
            // txtreceiptnumber
            // 
            txtreceiptnumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtreceiptnumber.Location = new Point(517, 47);
            txtreceiptnumber.Name = "txtreceiptnumber";
            txtreceiptnumber.Size = new Size(218, 29);
            txtreceiptnumber.TabIndex = 35;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtotherspayamount);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnadjustment);
            panel1.Controls.Add(cmbpaymenttype);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(cmbpaymentmethod);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(txtcashamount);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(txtchange);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txttotalprice);
            panel1.Location = new Point(741, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(502, 319);
            panel1.TabIndex = 36;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(txttype);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(dpkbirthday);
            panel2.Controls.Add(txtrank);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txtpoint);
            panel2.Controls.Add(txtemail);
            panel2.Controls.Add(txtphone);
            panel2.Controls.Add(txtaddress);
            panel2.Controls.Add(txtfullname);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label13);
            panel2.Controls.Add(cmbuserinfoname);
            panel2.Controls.Add(btnsearch);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(txtsearch);
            panel2.Location = new Point(23, 372);
            panel2.Name = "panel2";
            panel2.Size = new Size(712, 210);
            panel2.TabIndex = 37;
            // 
            // txttype
            // 
            txttype.Location = new Point(368, 159);
            txttype.Name = "txttype";
            txttype.Size = new Size(200, 23);
            txttype.TabIndex = 58;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(289, 162);
            label21.Name = "label21";
            label21.Size = new Size(31, 15);
            label21.TabIndex = 57;
            label21.Text = "Type";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label20.Location = new Point(597, 56);
            label20.Name = "label20";
            label20.Size = new Size(51, 15);
            label20.TabIndex = 56;
            label20.Text = "Is new ?";
            // 
            // button2
            // 
            button2.BackColor = Color.OrangeRed;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(597, 86);
            button2.Name = "button2";
            button2.Size = new Size(102, 96);
            button2.TabIndex = 55;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // dpkbirthday
            // 
            dpkbirthday.Location = new Point(368, 121);
            dpkbirthday.Name = "dpkbirthday";
            dpkbirthday.Size = new Size(200, 23);
            dpkbirthday.TabIndex = 54;
            // 
            // txtrank
            // 
            txtrank.Location = new Point(368, 86);
            txtrank.Name = "txtrank";
            txtrank.Size = new Size(156, 23);
            txtrank.TabIndex = 52;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(289, 124);
            label19.Name = "label19";
            label19.Size = new Size(51, 15);
            label19.TabIndex = 51;
            label19.Text = "Birthday";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(289, 89);
            label18.Name = "label18";
            label18.Size = new Size(33, 15);
            label18.TabIndex = 50;
            label18.Text = "Rank";
            // 
            // txtpoint
            // 
            txtpoint.Location = new Point(368, 53);
            txtpoint.Name = "txtpoint";
            txtpoint.Size = new Size(100, 23);
            txtpoint.TabIndex = 49;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(77, 159);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(175, 23);
            txtemail.TabIndex = 48;
            // 
            // txtphone
            // 
            txtphone.Location = new Point(77, 121);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(175, 23);
            txtphone.TabIndex = 47;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(77, 86);
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(175, 23);
            txtaddress.TabIndex = 46;
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(77, 53);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(175, 23);
            txtfullname.TabIndex = 45;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(289, 56);
            label17.Name = "label17";
            label17.Size = new Size(35, 15);
            label17.TabIndex = 44;
            label17.Text = "Point";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(12, 162);
            label16.Name = "label16";
            label16.Size = new Size(36, 15);
            label16.TabIndex = 43;
            label16.Text = "Email";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(12, 124);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 42;
            label15.Text = "Phone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 89);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 41;
            label14.Text = "Adress";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 56);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 40;
            label13.Text = "Full name";
            // 
            // cmbuserinfoname
            // 
            cmbuserinfoname.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbuserinfoname.FormattingEnabled = true;
            cmbuserinfoname.Location = new Point(193, 12);
            cmbuserinfoname.Name = "cmbuserinfoname";
            cmbuserinfoname.Size = new Size(234, 23);
            cmbuserinfoname.TabIndex = 39;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(624, 11);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 24);
            btnsearch.TabIndex = 38;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(12, 12);
            label12.Name = "label12";
            label12.Size = new Size(167, 22);
            label12.TabIndex = 1;
            label12.Text = "Customer info";
            label12.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(433, 12);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search name, email, phone..";
            txtsearch.Size = new Size(185, 23);
            txtsearch.TabIndex = 0;
            // 
            // btncanceltrans
            // 
            btncanceltrans.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btncanceltrans.Location = new Point(968, 608);
            btncanceltrans.Name = "btncanceltrans";
            btncanceltrans.Size = new Size(157, 31);
            btncanceltrans.TabIndex = 38;
            btncanceltrans.Text = "Cancel transaction";
            btncanceltrans.UseVisualStyleBackColor = true;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(848, 608);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 31);
            btnclear.TabIndex = 39;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            // 
            // frmAdjustment
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1252, 670);
            ControlBox = false;
            Controls.Add(btnclear);
            Controls.Add(btncanceltrans);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtreceiptnumber);
            Controls.Add(label11);
            Controls.Add(lbltitle);
            Controls.Add(grdproduct);
            Controls.Add(grdheader);
            Controls.Add(grdsales);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmAdjustment";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)grdsales).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdproduct).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private DataGridView grdsales;
        private DataGridView grdheader;
        private DataGridView grdproduct;
        private Label lbltitle;
        private TextBox txtcashamount;
        private TextBox txtotherspayamount;
        private ComboBox cmbpaymentmethod;
        private Button btnadjustment;
        private TextBox txttotalprice;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtchange;
        private Label label4;
        private Label label5;
        private ComboBox cmbpaymenttype;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox txtreceiptnumber;
        private Panel panel1;
        private Panel panel2;
        private Label label12;
        private TextBox txtsearch;
        private Button btnsearch;
        private ComboBox cmbuserinfoname;
        private TextBox txtpoint;
        private TextBox txtemail;
        private TextBox txtphone;
        private TextBox txtaddress;
        private TextBox txtfullname;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label19;
        private Label label18;
        private TextBox txtrank;
        private DateTimePicker dpkbirthday;
        private Label label20;
        private Button button2;
        private TextBox txttype;
        private Label label21;
        private Button btncanceltrans;
        private Button btnclear;
    }
}