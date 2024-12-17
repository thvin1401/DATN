namespace SalesManagement
{
    partial class frmSearchBillJournal
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
            grdbillheader = new DataGridView();
            grdbilldata = new DataGridView();
            dpkbillto = new DateTimePicker();
            dpkbillfrom = new DateTimePicker();
            txtcostto = new TextBox();
            txtcostfrom = new TextBox();
            txtreceiptnumber = new TextBox();
            cmbtype = new ComboBox();
            grdproducts = new DataGridView();
            grdpayment = new DataGridView();
            btnclear = new Button();
            lbltitle = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnsearch = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lbltotalamount = new Label();
            lblunpaidamount = new Label();
            lblpaidamount = new Label();
            label11 = new Label();
            lblstatus = new Label();
            ((System.ComponentModel.ISupportInitialize)grdbillheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdbilldata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdproducts).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdpayment).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1151, 621);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 30);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // grdbillheader
            // 
            grdbillheader.AllowUserToAddRows = false;
            grdbillheader.AllowUserToDeleteRows = false;
            grdbillheader.AllowUserToResizeColumns = false;
            grdbillheader.AllowUserToResizeRows = false;
            grdbillheader.BackgroundColor = SystemColors.Window;
            grdbillheader.BorderStyle = BorderStyle.Fixed3D;
            grdbillheader.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdbillheader.ColumnHeadersVisible = false;
            grdbillheader.Location = new Point(28, 177);
            grdbillheader.Name = "grdbillheader";
            grdbillheader.RowHeadersVisible = false;
            grdbillheader.RowTemplate.Height = 25;
            grdbillheader.Size = new Size(697, 35);
            grdbillheader.TabIndex = 1;
            // 
            // grdbilldata
            // 
            grdbilldata.AllowUserToAddRows = false;
            grdbilldata.AllowUserToDeleteRows = false;
            grdbilldata.AllowUserToResizeColumns = false;
            grdbilldata.AllowUserToResizeRows = false;
            grdbilldata.BackgroundColor = SystemColors.Window;
            grdbilldata.BorderStyle = BorderStyle.Fixed3D;
            grdbilldata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdbilldata.ColumnHeadersVisible = false;
            grdbilldata.Location = new Point(28, 209);
            grdbilldata.Name = "grdbilldata";
            grdbilldata.RowHeadersVisible = false;
            grdbilldata.RowTemplate.Height = 25;
            grdbilldata.Size = new Size(697, 395);
            grdbilldata.TabIndex = 2;
            grdbilldata.CellDoubleClick += grdbilldata_CellDoubleClick;
            // 
            // dpkbillto
            // 
            dpkbillto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbillto.Format = DateTimePickerFormat.Short;
            dpkbillto.Location = new Point(328, 91);
            dpkbillto.Name = "dpkbillto";
            dpkbillto.Size = new Size(160, 29);
            dpkbillto.TabIndex = 3;
            dpkbillto.ValueChanged += dpkbillto_ValueChanged;
            // 
            // dpkbillfrom
            // 
            dpkbillfrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkbillfrom.Format = DateTimePickerFormat.Short;
            dpkbillfrom.Location = new Point(116, 91);
            dpkbillfrom.Name = "dpkbillfrom";
            dpkbillfrom.Size = new Size(160, 29);
            dpkbillfrom.TabIndex = 4;
            dpkbillfrom.ValueChanged += dpkbillfrom_ValueChanged;
            // 
            // txtcostto
            // 
            txtcostto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcostto.Location = new Point(328, 132);
            txtcostto.Name = "txtcostto";
            txtcostto.Size = new Size(160, 29);
            txtcostto.TabIndex = 5;
            txtcostto.KeyPress += txtnumeric_KeyPress;
            txtcostto.Leave += txtcostto_Leave;
            // 
            // txtcostfrom
            // 
            txtcostfrom.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtcostfrom.Location = new Point(116, 132);
            txtcostfrom.Name = "txtcostfrom";
            txtcostfrom.Size = new Size(160, 29);
            txtcostfrom.TabIndex = 6;
            txtcostfrom.KeyPress += txtnumeric_KeyPress;
            txtcostfrom.Leave += txtcostfrom_Leave;
            // 
            // txtreceiptnumber
            // 
            txtreceiptnumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtreceiptnumber.Location = new Point(494, 132);
            txtreceiptnumber.Name = "txtreceiptnumber";
            txtreceiptnumber.Size = new Size(150, 29);
            txtreceiptnumber.TabIndex = 7;
            txtreceiptnumber.KeyPress += txtnumeric_KeyPress;
            // 
            // cmbtype
            // 
            cmbtype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbtype.FlatStyle = FlatStyle.Flat;
            cmbtype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbtype.FormattingEnabled = true;
            cmbtype.Location = new Point(494, 91);
            cmbtype.Name = "cmbtype";
            cmbtype.Size = new Size(231, 29);
            cmbtype.TabIndex = 8;
            cmbtype.SelectedIndexChanged += cmbtype_SelectedIndexChanged;
            // 
            // grdproducts
            // 
            grdproducts.AllowUserToAddRows = false;
            grdproducts.AllowUserToDeleteRows = false;
            grdproducts.AllowUserToResizeColumns = false;
            grdproducts.AllowUserToResizeRows = false;
            grdproducts.BackgroundColor = SystemColors.Window;
            grdproducts.BorderStyle = BorderStyle.Fixed3D;
            grdproducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdproducts.ColumnHeadersVisible = false;
            grdproducts.Location = new Point(731, 26);
            grdproducts.Name = "grdproducts";
            grdproducts.RowHeadersVisible = false;
            grdproducts.RowTemplate.Height = 25;
            grdproducts.Size = new Size(495, 207);
            grdproducts.TabIndex = 9;
            // 
            // grdpayment
            // 
            grdpayment.AllowUserToAddRows = false;
            grdpayment.AllowUserToDeleteRows = false;
            grdpayment.AllowUserToResizeColumns = false;
            grdpayment.AllowUserToResizeRows = false;
            grdpayment.BackgroundColor = SystemColors.Window;
            grdpayment.BorderStyle = BorderStyle.Fixed3D;
            grdpayment.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdpayment.ColumnHeadersVisible = false;
            grdpayment.Location = new Point(731, 262);
            grdpayment.Name = "grdpayment";
            grdpayment.RowHeadersVisible = false;
            grdpayment.RowTemplate.Height = 25;
            grdpayment.Size = new Size(495, 316);
            grdpayment.TabIndex = 10;
            // 
            // btnclear
            // 
            btnclear.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnclear.Location = new Point(1036, 621);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(75, 30);
            btnclear.TabIndex = 11;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(28, 26);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 31;
            lbltitle.Text = "Search bill journal screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 135);
            label1.Name = "label1";
            label1.Size = new Size(82, 21);
            label1.TabIndex = 32;
            label1.Text = "Cost From";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(288, 135);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 33;
            label2.Text = "To";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(28, 97);
            label3.Name = "label3";
            label3.Size = new Size(47, 21);
            label3.TabIndex = 34;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(288, 94);
            label4.Name = "label4";
            label4.Size = new Size(25, 21);
            label4.TabIndex = 35;
            label4.Text = "To";
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(650, 132);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 30);
            btnsearch.TabIndex = 36;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(731, 582);
            label5.Name = "label5";
            label5.Size = new Size(39, 21);
            label5.TabIndex = 37;
            label5.Text = "Paid";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(970, 582);
            label6.Name = "label6";
            label6.Size = new Size(60, 21);
            label6.TabIndex = 38;
            label6.Text = "Unpaid";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(731, 237);
            label7.Name = "label7";
            label7.Size = new Size(42, 21);
            label7.TabIndex = 39;
            label7.Text = "Total";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotalamount
            // 
            lbltotalamount.BorderStyle = BorderStyle.FixedSingle;
            lbltotalamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbltotalamount.Location = new Point(776, 236);
            lbltotalamount.Name = "lbltotalamount";
            lbltotalamount.Size = new Size(188, 23);
            lbltotalamount.TabIndex = 40;
            lbltotalamount.Text = "0";
            lbltotalamount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblunpaidamount
            // 
            lblunpaidamount.BorderStyle = BorderStyle.FixedSingle;
            lblunpaidamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblunpaidamount.Location = new Point(1036, 581);
            lblunpaidamount.Name = "lblunpaidamount";
            lblunpaidamount.Size = new Size(190, 23);
            lblunpaidamount.TabIndex = 41;
            lblunpaidamount.Text = "0";
            lblunpaidamount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblpaidamount
            // 
            lblpaidamount.BorderStyle = BorderStyle.FixedSingle;
            lblpaidamount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblpaidamount.Location = new Point(776, 581);
            lblpaidamount.Name = "lblpaidamount";
            lblpaidamount.Size = new Size(188, 23);
            lblpaidamount.TabIndex = 42;
            lblpaidamount.Text = "0";
            lblpaidamount.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(1052, 236);
            label11.Name = "label11";
            label11.Size = new Size(59, 21);
            label11.TabIndex = 43;
            label11.Text = "Status :";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblstatus
            // 
            lblstatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblstatus.ForeColor = Color.Red;
            lblstatus.Location = new Point(1117, 236);
            lblstatus.Name = "lblstatus";
            lblstatus.Size = new Size(109, 21);
            lblstatus.TabIndex = 44;
            lblstatus.Text = "Unpaid";
            lblstatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSearchBillJournal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(lblstatus);
            Controls.Add(label11);
            Controls.Add(lblpaidamount);
            Controls.Add(lblunpaidamount);
            Controls.Add(lbltotalamount);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnsearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltitle);
            Controls.Add(btnclear);
            Controls.Add(grdpayment);
            Controls.Add(grdproducts);
            Controls.Add(cmbtype);
            Controls.Add(txtreceiptnumber);
            Controls.Add(txtcostfrom);
            Controls.Add(txtcostto);
            Controls.Add(dpkbillfrom);
            Controls.Add(dpkbillto);
            Controls.Add(grdbilldata);
            Controls.Add(grdbillheader);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSearchBillJournal";
            StartPosition = FormStartPosition.Manual;
            Text = "frmSearchBillJournal";
            ((System.ComponentModel.ISupportInitialize)grdbillheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdbilldata).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdproducts).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdpayment).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private DataGridView grdbillheader;
        private DataGridView grdbilldata;
        private DateTimePicker dpkbillto;
        private DateTimePicker dpkbillfrom;
        private TextBox txtcostto;
        private TextBox txtcostfrom;
        private TextBox txtreceiptnumber;
        private ComboBox cmbtype;
        private DataGridView grdproducts;
        private DataGridView grdpayment;
        private Button btnclear;
        private Label lbltitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnsearch;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lbltotalamount;
        private Label lblunpaidamount;
        private Label lblpaidamount;
        private Label label11;
        private Label lblstatus;
    }
}