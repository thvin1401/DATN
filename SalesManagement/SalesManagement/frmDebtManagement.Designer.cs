namespace SalesManagement
{
    partial class frmDebtManagement
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
            lbltitle = new Label();
            grdheader = new DataGridView();
            grddata = new DataGridView();
            btnadd = new Button();
            btnpay = new Button();
            btnexcelreport = new Button();
            dpkprocessedtimefrom = new DateTimePicker();
            dpkprocessedtimeto = new DateTimePicker();
            txtreceiptnumber = new TextBox();
            btnsearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            grdheader1 = new DataGridView();
            grdoverviewdata = new DataGridView();
            lbltype = new Label();
            btndelete = new Button();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdheader1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdoverviewdata).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(437, 621);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 30);
            btnback.TabIndex = 0;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(27, 22);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 32;
            lbltitle.Text = "Debt management screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
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
            grdheader.Location = new Point(561, 87);
            grdheader.Margin = new Padding(0);
            grdheader.Name = "grdheader";
            grdheader.ReadOnly = true;
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(666, 30);
            grdheader.TabIndex = 33;
            // 
            // grddata
            // 
            grddata.AllowUserToAddRows = false;
            grddata.AllowUserToDeleteRows = false;
            grddata.AllowUserToResizeColumns = false;
            grddata.AllowUserToResizeRows = false;
            grddata.BackgroundColor = SystemColors.Control;
            grddata.BorderStyle = BorderStyle.Fixed3D;
            grddata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grddata.ColumnHeadersVisible = false;
            grddata.Location = new Point(561, 115);
            grddata.Margin = new Padding(0);
            grddata.Name = "grddata";
            grddata.ReadOnly = true;
            grddata.RowHeadersVisible = false;
            grddata.RowTemplate.Height = 25;
            grddata.Size = new Size(666, 536);
            grddata.TabIndex = 34;
            grddata.CellContentClick += grddata_CellContentClick;
            grddata.CellDoubleClick += grddata_CellDoubleClick;
            grddata.CellPainting += grddata_CellPainting;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(154, 621);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 30);
            btnadd.TabIndex = 35;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnpay
            // 
            btnpay.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnpay.Location = new Point(251, 621);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(75, 30);
            btnpay.TabIndex = 36;
            btnpay.Text = "Pay";
            btnpay.UseVisualStyleBackColor = true;
            btnpay.Click += btnpay_Click;
            // 
            // btnexcelreport
            // 
            btnexcelreport.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnexcelreport.Location = new Point(27, 621);
            btnexcelreport.Name = "btnexcelreport";
            btnexcelreport.Size = new Size(103, 30);
            btnexcelreport.TabIndex = 37;
            btnexcelreport.Text = "Excel report";
            btnexcelreport.UseVisualStyleBackColor = true;
            // 
            // dpkprocessedtimefrom
            // 
            dpkprocessedtimefrom.Location = new Point(422, 49);
            dpkprocessedtimefrom.Name = "dpkprocessedtimefrom";
            dpkprocessedtimefrom.Size = new Size(208, 23);
            dpkprocessedtimefrom.TabIndex = 39;
            // 
            // dpkprocessedtimeto
            // 
            dpkprocessedtimeto.Location = new Point(678, 49);
            dpkprocessedtimeto.Name = "dpkprocessedtimeto";
            dpkprocessedtimeto.Size = new Size(206, 23);
            dpkprocessedtimeto.TabIndex = 40;
            // 
            // txtreceiptnumber
            // 
            txtreceiptnumber.BorderStyle = BorderStyle.FixedSingle;
            txtreceiptnumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtreceiptnumber.Location = new Point(1003, 48);
            txtreceiptnumber.Name = "txtreceiptnumber";
            txtreceiptnumber.PlaceholderText = "Receipt number";
            txtreceiptnumber.Size = new Size(143, 29);
            txtreceiptnumber.TabIndex = 42;
            // 
            // btnsearch
            // 
            btnsearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsearch.Location = new Point(1152, 48);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 29);
            btnsearch.TabIndex = 43;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(358, 50);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 44;
            label1.Text = "From : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(636, 50);
            label2.Name = "label2";
            label2.Size = new Size(36, 21);
            label2.TabIndex = 45;
            label2.Text = "To : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(900, 50);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 46;
            label3.Text = "Type : ";
            // 
            // grdheader1
            // 
            grdheader1.AllowUserToAddRows = false;
            grdheader1.AllowUserToDeleteRows = false;
            grdheader1.AllowUserToResizeColumns = false;
            grdheader1.AllowUserToResizeRows = false;
            grdheader1.BackgroundColor = SystemColors.Control;
            grdheader1.BorderStyle = BorderStyle.Fixed3D;
            grdheader1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdheader1.ColumnHeadersVisible = false;
            grdheader1.Location = new Point(27, 87);
            grdheader1.Margin = new Padding(0);
            grdheader1.Name = "grdheader1";
            grdheader1.ReadOnly = true;
            grdheader1.RowHeadersVisible = false;
            grdheader1.RowTemplate.Height = 25;
            grdheader1.Size = new Size(528, 30);
            grdheader1.TabIndex = 47;
            // 
            // grdoverviewdata
            // 
            grdoverviewdata.AllowUserToAddRows = false;
            grdoverviewdata.AllowUserToDeleteRows = false;
            grdoverviewdata.AllowUserToResizeColumns = false;
            grdoverviewdata.AllowUserToResizeRows = false;
            grdoverviewdata.BackgroundColor = SystemColors.Control;
            grdoverviewdata.BorderStyle = BorderStyle.Fixed3D;
            grdoverviewdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdoverviewdata.ColumnHeadersVisible = false;
            grdoverviewdata.Location = new Point(27, 115);
            grdoverviewdata.Margin = new Padding(0);
            grdoverviewdata.Name = "grdoverviewdata";
            grdoverviewdata.ReadOnly = true;
            grdoverviewdata.RowHeadersVisible = false;
            grdoverviewdata.RowTemplate.Height = 25;
            grdoverviewdata.Size = new Size(528, 484);
            grdoverviewdata.TabIndex = 48;
            grdoverviewdata.CellDoubleClick += grdoverviewdata_CellDoubleClick;
            // 
            // lbltype
            // 
            lbltype.AutoSize = true;
            lbltype.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltype.ForeColor = Color.LimeGreen;
            lbltype.Location = new Point(950, 52);
            lbltype.Name = "lbltype";
            lbltype.Size = new Size(47, 21);
            lbltype.TabIndex = 49;
            lbltype.Text = "Lend";
            // 
            // btndelete
            // 
            btndelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btndelete.Location = new Point(343, 621);
            btndelete.Name = "btndelete";
            btndelete.Size = new Size(75, 30);
            btndelete.TabIndex = 50;
            btndelete.Text = "Delete";
            btndelete.UseVisualStyleBackColor = true;
            btndelete.Click += btndelete_Click;
            // 
            // frmDebtManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(btndelete);
            Controls.Add(lbltype);
            Controls.Add(grdoverviewdata);
            Controls.Add(grdheader1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsearch);
            Controls.Add(txtreceiptnumber);
            Controls.Add(dpkprocessedtimeto);
            Controls.Add(dpkprocessedtimefrom);
            Controls.Add(btnexcelreport);
            Controls.Add(btnpay);
            Controls.Add(btnadd);
            Controls.Add(grddata);
            Controls.Add(grdheader);
            Controls.Add(lbltitle);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmDebtManagement";
            StartPosition = FormStartPosition.Manual;
            Text = "frmDebtManagement";
            ((System.ComponentModel.ISupportInitialize)grdheader).EndInit();
            ((System.ComponentModel.ISupportInitialize)grddata).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdheader1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdoverviewdata).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnback;
        private Label lbltitle;
        private DataGridView grdheader;
        private DataGridView grddata;
        private Button btnadd;
        private Button btnpay;
        private Button btnexcelreport;
        private DateTimePicker dpkprocessedtimefrom;
        private DateTimePicker dpkprocessedtimeto;
        private TextBox txtreceiptnumber;
        private Button btnsearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView grdheader1;
        private DataGridView grdoverviewdata;
        private Label lbltype;
        private Button btndelete;
    }
}