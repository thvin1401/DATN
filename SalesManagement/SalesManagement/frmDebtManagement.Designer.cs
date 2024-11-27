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
            cmbstatus = new ComboBox();
            txtreceiptnumber = new TextBox();
            btnsearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Location = new Point(1152, 621);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 23);
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
            grdheader.Location = new Point(27, 87);
            grdheader.Margin = new Padding(0);
            grdheader.Name = "grdheader";
            grdheader.ReadOnly = true;
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(1200, 30);
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
            grddata.Location = new Point(27, 115);
            grddata.Margin = new Padding(0);
            grddata.Name = "grddata";
            grddata.ReadOnly = true;
            grddata.RowHeadersVisible = false;
            grddata.RowTemplate.Height = 25;
            grddata.Size = new Size(1200, 475);
            grddata.TabIndex = 34;
            grddata.CellClick += grddata_CellClick;
            grddata.CellDoubleClick += grddata_CellDoubleClick;
            grddata.CellPainting += grddata_CellPainting;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(956, 621);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 23);
            btnadd.TabIndex = 35;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // btnpay
            // 
            btnpay.Location = new Point(1055, 621);
            btnpay.Name = "btnpay";
            btnpay.Size = new Size(75, 23);
            btnpay.TabIndex = 36;
            btnpay.Text = "Pay";
            btnpay.UseVisualStyleBackColor = true;
            // 
            // btnexcelreport
            // 
            btnexcelreport.Location = new Point(27, 621);
            btnexcelreport.Name = "btnexcelreport";
            btnexcelreport.Size = new Size(83, 23);
            btnexcelreport.TabIndex = 37;
            btnexcelreport.Text = "Excel report";
            btnexcelreport.UseVisualStyleBackColor = true;
            // 
            // dpkprocessedtimefrom
            // 
            dpkprocessedtimefrom.Location = new Point(410, 49);
            dpkprocessedtimefrom.Name = "dpkprocessedtimefrom";
            dpkprocessedtimefrom.Size = new Size(145, 23);
            dpkprocessedtimefrom.TabIndex = 39;
            // 
            // dpkprocessedtimeto
            // 
            dpkprocessedtimeto.Location = new Point(595, 49);
            dpkprocessedtimeto.Name = "dpkprocessedtimeto";
            dpkprocessedtimeto.Size = new Size(145, 23);
            dpkprocessedtimeto.TabIndex = 40;
            // 
            // cmbstatus
            // 
            cmbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbstatus.FormattingEnabled = true;
            cmbstatus.Location = new Point(843, 50);
            cmbstatus.Name = "cmbstatus";
            cmbstatus.Size = new Size(121, 23);
            cmbstatus.TabIndex = 41;
            cmbstatus.SelectedIndexChanged += cmbstatus_SelectedIndexChanged;
            // 
            // txtreceiptnumber
            // 
            txtreceiptnumber.BorderStyle = BorderStyle.FixedSingle;
            txtreceiptnumber.Location = new Point(986, 50);
            txtreceiptnumber.Name = "txtreceiptnumber";
            txtreceiptnumber.PlaceholderText = "Receipt number";
            txtreceiptnumber.Size = new Size(160, 23);
            txtreceiptnumber.TabIndex = 42;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(1152, 51);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 23);
            btnsearch.TabIndex = 43;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(360, 55);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 44;
            label1.Text = "From : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(561, 55);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 45;
            label2.Text = "To : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(789, 55);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 46;
            label3.Text = "Status : ";
            // 
            // frmDebtManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnsearch);
            Controls.Add(txtreceiptnumber);
            Controls.Add(cmbstatus);
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
        private ComboBox cmbstatus;
        private TextBox txtreceiptnumber;
        private Button btnsearch;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}