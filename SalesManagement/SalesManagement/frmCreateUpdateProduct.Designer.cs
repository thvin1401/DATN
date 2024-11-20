namespace SalesManagement
{
    partial class frmCreateUpdateProduct
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
            txtname = new TextBox();
            cmbprovider = new ComboBox();
            cmbcategory = new ComboBox();
            dpkimporttime = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            lbltitle = new Label();
            ckbisnewprovider = new CheckBox();
            txtquantity = new TextBox();
            txtunitpricevnd = new TextBox();
            txtnewprovidername = new TextBox();
            btnsave = new Button();
            btnback = new Button();
            label7 = new Label();
            cmbcurrencytype = new ComboBox();
            txtunitprice = new TextBox();
            label8 = new Label();
            ckbnewcategory = new CheckBox();
            txtnewcategoryname = new TextBox();
            label9 = new Label();
            txtweight = new TextBox();
            label10 = new Label();
            ckbisdeleted = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 101);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // txtname
            // 
            txtname.BorderStyle = BorderStyle.FixedSingle;
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(174, 98);
            txtname.Name = "txtname";
            txtname.Size = new Size(391, 29);
            txtname.TabIndex = 1;
            // 
            // cmbprovider
            // 
            cmbprovider.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbprovider.FormattingEnabled = true;
            cmbprovider.Location = new Point(174, 260);
            cmbprovider.Name = "cmbprovider";
            cmbprovider.Size = new Size(121, 29);
            cmbprovider.TabIndex = 2;
            // 
            // cmbcategory
            // 
            cmbcategory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbcategory.FormattingEnabled = true;
            cmbcategory.Location = new Point(174, 320);
            cmbcategory.Name = "cmbcategory";
            cmbcategory.Size = new Size(121, 29);
            cmbcategory.TabIndex = 3;
            // 
            // dpkimporttime
            // 
            dpkimporttime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpkimporttime.Location = new Point(174, 375);
            dpkimporttime.Name = "dpkimporttime";
            dpkimporttime.Size = new Size(271, 29);
            dpkimporttime.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 150);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 5;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 205);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 6;
            label3.Text = "Unit price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 263);
            label4.Name = "label4";
            label4.Size = new Size(75, 21);
            label4.TabIndex = 7;
            label4.Text = "Provider";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 323);
            label5.Name = "label5";
            label5.Size = new Size(80, 21);
            label5.TabIndex = 8;
            label5.Text = "Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(30, 381);
            label6.Name = "label6";
            label6.Size = new Size(101, 21);
            label6.TabIndex = 9;
            label6.Text = "Import time";
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(30, 23);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 31;
            lbltitle.Text = "Product creation screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbisnewprovider
            // 
            ckbisnewprovider.AutoSize = true;
            ckbisnewprovider.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbisnewprovider.Location = new Point(301, 263);
            ckbisnewprovider.Name = "ckbisnewprovider";
            ckbisnewprovider.Size = new Size(75, 25);
            ckbisnewprovider.TabIndex = 32;
            ckbisnewprovider.Text = "New ?";
            ckbisnewprovider.UseVisualStyleBackColor = true;
            ckbisnewprovider.CheckedChanged += ckbisnewprovider_CheckedChanged;
            // 
            // txtquantity
            // 
            txtquantity.BorderStyle = BorderStyle.FixedSingle;
            txtquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtquantity.Location = new Point(174, 147);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(121, 29);
            txtquantity.TabIndex = 33;
            // 
            // txtunitpricevnd
            // 
            txtunitpricevnd.BorderStyle = BorderStyle.FixedSingle;
            txtunitpricevnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtunitpricevnd.Location = new Point(382, 205);
            txtunitpricevnd.Name = "txtunitpricevnd";
            txtunitpricevnd.Size = new Size(146, 29);
            txtunitpricevnd.TabIndex = 34;
            // 
            // txtnewprovidername
            // 
            txtnewprovidername.BorderStyle = BorderStyle.FixedSingle;
            txtnewprovidername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnewprovidername.Location = new Point(382, 260);
            txtnewprovidername.Name = "txtnewprovidername";
            txtnewprovidername.Size = new Size(183, 29);
            txtnewprovidername.TabIndex = 35;
            // 
            // btnsave
            // 
            btnsave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsave.Location = new Point(382, 436);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(75, 31);
            btnsave.TabIndex = 36;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = true;
            btnsave.Click += btnsave_Click;
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(490, 436);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 31);
            btnback.TabIndex = 37;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, 219);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 38;
            label7.Text = "VND";
            // 
            // cmbcurrencytype
            // 
            cmbcurrencytype.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbcurrencytype.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbcurrencytype.FormattingEnabled = true;
            cmbcurrencytype.Location = new Point(294, 205);
            cmbcurrencytype.Name = "cmbcurrencytype";
            cmbcurrencytype.Size = new Size(58, 29);
            cmbcurrencytype.TabIndex = 39;
            cmbcurrencytype.SelectedIndexChanged += cmbcurrencytype_SelectedIndexChanged;
            // 
            // txtunitprice
            // 
            txtunitprice.BorderStyle = BorderStyle.FixedSingle;
            txtunitprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtunitprice.Location = new Point(174, 205);
            txtunitprice.Name = "txtunitprice";
            txtunitprice.Size = new Size(121, 29);
            txtunitprice.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(359, 213);
            label8.Name = "label8";
            label8.Size = new Size(15, 15);
            label8.TabIndex = 41;
            label8.Text = "=";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ckbnewcategory
            // 
            ckbnewcategory.AutoSize = true;
            ckbnewcategory.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbnewcategory.Location = new Point(301, 323);
            ckbnewcategory.Name = "ckbnewcategory";
            ckbnewcategory.Size = new Size(75, 25);
            ckbnewcategory.TabIndex = 42;
            ckbnewcategory.Text = "New ?";
            ckbnewcategory.UseVisualStyleBackColor = true;
            ckbnewcategory.CheckedChanged += ckbnewcategory_CheckedChanged;
            // 
            // txtnewcategoryname
            // 
            txtnewcategoryname.BorderStyle = BorderStyle.FixedSingle;
            txtnewcategoryname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtnewcategoryname.Location = new Point(382, 320);
            txtnewcategoryname.Name = "txtnewcategoryname";
            txtnewcategoryname.Size = new Size(183, 29);
            txtnewcategoryname.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(306, 150);
            label9.Name = "label9";
            label9.Size = new Size(66, 21);
            label9.TabIndex = 44;
            label9.Text = "Weight";
            // 
            // txtweight
            // 
            txtweight.BorderStyle = BorderStyle.FixedSingle;
            txtweight.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtweight.Location = new Point(382, 147);
            txtweight.Name = "txtweight";
            txtweight.Size = new Size(146, 29);
            txtweight.TabIndex = 45;
            txtweight.Leave += txtweight_Leave;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(534, 161);
            label10.Name = "label10";
            label10.Size = new Size(21, 15);
            label10.TabIndex = 46;
            label10.Text = "Kg";
            // 
            // ckbisdeleted
            // 
            ckbisdeleted.AutoSize = true;
            ckbisdeleted.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ckbisdeleted.Location = new Point(451, 377);
            ckbisdeleted.Name = "ckbisdeleted";
            ckbisdeleted.Size = new Size(114, 25);
            ckbisdeleted.TabIndex = 47;
            ckbisdeleted.Text = "Is deleted ?";
            ckbisdeleted.UseVisualStyleBackColor = true;
            // 
            // frmCreateUpdateProduct
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(595, 491);
            ControlBox = false;
            Controls.Add(ckbisdeleted);
            Controls.Add(label10);
            Controls.Add(txtweight);
            Controls.Add(label9);
            Controls.Add(txtnewcategoryname);
            Controls.Add(ckbnewcategory);
            Controls.Add(label8);
            Controls.Add(txtunitprice);
            Controls.Add(cmbcurrencytype);
            Controls.Add(label7);
            Controls.Add(btnback);
            Controls.Add(btnsave);
            Controls.Add(txtnewprovidername);
            Controls.Add(txtunitpricevnd);
            Controls.Add(txtquantity);
            Controls.Add(ckbisnewprovider);
            Controls.Add(lbltitle);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dpkimporttime);
            Controls.Add(cmbcategory);
            Controls.Add(cmbprovider);
            Controls.Add(txtname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCreateUpdateProduct";
            StartPosition = FormStartPosition.CenterParent;
            Load += FrmCreateUpdateProduct_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtname;
        private ComboBox cmbprovider;
        private ComboBox cmbcategory;
        private DateTimePicker dpkimporttime;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label lbltitle;
        private CheckBox ckbisnewprovider;
        private TextBox txtquantity;
        private TextBox txtunitpricevnd;
        private TextBox txtnewprovidername;
        private Button btnsave;
        private Button btnback;
        private Label label7;
        private ComboBox cmbcurrencytype;
        private TextBox txtunitprice;
        private Label label8;
        private CheckBox ckbnewcategory;
        private TextBox txtnewcategoryname;
        private Label label9;
        private TextBox txtweight;
        private Label label10;
        private CheckBox ckbisdeleted;
    }
}