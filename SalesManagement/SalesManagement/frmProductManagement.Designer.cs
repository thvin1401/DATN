namespace SalesManagement
{
    partial class frmProductManagement
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
            dpkarriveddatefrom = new DateTimePicker();
            dpkarriveddateto = new DateTimePicker();
            btnsearch = new Button();
            txtsearch = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btnadd = new Button();
            btnviewdeleteditems = new Button();
            lbldeletedstatus = new Label();
            ((System.ComponentModel.ISupportInitialize)grdheader).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grddata).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(1150, 623);
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
            lbltitle.Location = new Point(31, 26);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 30;
            lbltitle.Text = "Product management screen";
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
            grdheader.Location = new Point(31, 98);
            grdheader.Margin = new Padding(0);
            grdheader.Name = "grdheader";
            grdheader.ReadOnly = true;
            grdheader.RowHeadersVisible = false;
            grdheader.RowTemplate.Height = 25;
            grdheader.Size = new Size(1194, 30);
            grdheader.TabIndex = 31;
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
            grddata.Location = new Point(31, 123);
            grddata.Name = "grddata";
            grddata.ReadOnly = true;
            grddata.RowHeadersVisible = false;
            grddata.RowTemplate.Height = 25;
            grddata.Size = new Size(1194, 480);
            grddata.TabIndex = 32;
            grddata.CellClick += grddata_CellClick;
            grddata.CellDoubleClick += grddata_CellDoubleClick;
            grddata.CellPainting += grddata_CellPainting;
            // 
            // dpkarriveddatefrom
            // 
            dpkarriveddatefrom.Location = new Point(498, 53);
            dpkarriveddatefrom.Name = "dpkarriveddatefrom";
            dpkarriveddatefrom.Size = new Size(200, 23);
            dpkarriveddatefrom.TabIndex = 33;
            dpkarriveddatefrom.ValueChanged += dpkarriveddatefrom_ValueChanged;
            // 
            // dpkarriveddateto
            // 
            dpkarriveddateto.Location = new Point(735, 53);
            dpkarriveddateto.Name = "dpkarriveddateto";
            dpkarriveddateto.Size = new Size(200, 23);
            dpkarriveddateto.TabIndex = 34;
            dpkarriveddateto.ValueChanged += dpkarriveddateto_ValueChanged;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(1150, 53);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(75, 23);
            btnsearch.TabIndex = 35;
            btnsearch.Text = "Search";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.BorderStyle = BorderStyle.FixedSingle;
            txtsearch.Location = new Point(941, 53);
            txtsearch.Name = "txtsearch";
            txtsearch.PlaceholderText = "Search name";
            txtsearch.Size = new Size(203, 23);
            txtsearch.TabIndex = 36;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 59);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 38;
            label2.Text = "Arrived date - From :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(704, 59);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 39;
            label3.Text = "To :";
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnadd.Location = new Point(860, 623);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(75, 30);
            btnadd.TabIndex = 40;
            btnadd.Text = "Add";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // btnviewdeleteditems
            // 
            btnviewdeleteditems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnviewdeleteditems.Location = new Point(981, 623);
            btnviewdeleteditems.Name = "btnviewdeleteditems";
            btnviewdeleteditems.Size = new Size(113, 30);
            btnviewdeleteditems.TabIndex = 42;
            btnviewdeleteditems.Text = "Deleted Items";
            btnviewdeleteditems.UseVisualStyleBackColor = true;
            btnviewdeleteditems.Click += btnviewdeleteditems_Click;
            // 
            // lbldeletedstatus
            // 
            lbldeletedstatus.BorderStyle = BorderStyle.Fixed3D;
            lbldeletedstatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbldeletedstatus.Location = new Point(1091, 624);
            lbldeletedstatus.Name = "lbldeletedstatus";
            lbldeletedstatus.Size = new Size(31, 28);
            lbldeletedstatus.TabIndex = 43;
            lbldeletedstatus.Text = "D";
            lbldeletedstatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmProductManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1258, 676);
            Controls.Add(lbldeletedstatus);
            Controls.Add(btnviewdeleteditems);
            Controls.Add(btnadd);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtsearch);
            Controls.Add(btnsearch);
            Controls.Add(dpkarriveddateto);
            Controls.Add(dpkarriveddatefrom);
            Controls.Add(grddata);
            Controls.Add(grdheader);
            Controls.Add(lbltitle);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmProductManagement";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "frmProductManagement";
            Load += frmProductManagement_Load;
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
        private DateTimePicker dpkarriveddatefrom;
        private DateTimePicker dpkarriveddateto;
        private Button btnsearch;
        private TextBox txtsearch;
        private Label label2;
        private Label label3;
        private Button btnadd;
        private Button btnviewdeleteditems;
        private Label lbldeletedstatus;
    }
}