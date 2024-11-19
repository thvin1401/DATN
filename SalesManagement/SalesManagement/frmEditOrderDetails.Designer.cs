namespace SalesManagement
{
    partial class frmEditOrderDetails
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtname = new TextBox();
            txtquantity = new TextBox();
            txtunitprice = new TextBox();
            txtdiscount = new TextBox();
            btnok = new Button();
            btnrevert = new Button();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(24, 19);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(311, 54);
            lbltitle.TabIndex = 17;
            lbltitle.Text = "Edit order details screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(24, 109);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 18;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(24, 162);
            label2.Name = "label2";
            label2.Size = new Size(77, 21);
            label2.TabIndex = 19;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 219);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 20;
            label3.Text = "Unit price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(24, 276);
            label4.Name = "label4";
            label4.Size = new Size(78, 21);
            label4.TabIndex = 21;
            label4.Text = "Discount";
            // 
            // txtname
            // 
            txtname.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtname.Location = new Point(143, 106);
            txtname.Name = "txtname";
            txtname.Size = new Size(257, 29);
            txtname.TabIndex = 22;
            // 
            // txtquantity
            // 
            txtquantity.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtquantity.Location = new Point(143, 159);
            txtquantity.Name = "txtquantity";
            txtquantity.Size = new Size(100, 29);
            txtquantity.TabIndex = 23;
            txtquantity.KeyPress += txtnumeric_KeyPress;
            // 
            // txtunitprice
            // 
            txtunitprice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtunitprice.Location = new Point(143, 216);
            txtunitprice.Name = "txtunitprice";
            txtunitprice.Size = new Size(192, 29);
            txtunitprice.TabIndex = 24;
            txtunitprice.KeyPress += txtnumeric_KeyPress;
            // 
            // txtdiscount
            // 
            txtdiscount.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtdiscount.Location = new Point(143, 273);
            txtdiscount.Name = "txtdiscount";
            txtdiscount.Size = new Size(192, 29);
            txtdiscount.TabIndex = 25;
            txtdiscount.KeyPress += txtnumeric_KeyPress;
            // 
            // btnok
            // 
            btnok.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnok.Location = new Point(325, 339);
            btnok.Name = "btnok";
            btnok.Size = new Size(75, 32);
            btnok.TabIndex = 26;
            btnok.Text = "OK";
            btnok.UseVisualStyleBackColor = true;
            btnok.Click += btnok_Click;
            // 
            // btnrevert
            // 
            btnrevert.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnrevert.Location = new Point(206, 339);
            btnrevert.Name = "btnrevert";
            btnrevert.Size = new Size(75, 32);
            btnrevert.TabIndex = 27;
            btnrevert.Text = "Revert";
            btnrevert.UseVisualStyleBackColor = true;
            btnrevert.Click += btnrevert_Click;
            // 
            // frmEditOrderDetails
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(426, 392);
            ControlBox = false;
            Controls.Add(btnrevert);
            Controls.Add(btnok);
            Controls.Add(txtdiscount);
            Controls.Add(txtunitprice);
            Controls.Add(txtquantity);
            Controls.Add(txtname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lbltitle);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmEditOrderDetails";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmEditOrderDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtname;
        private TextBox txtquantity;
        private TextBox txtunitprice;
        private TextBox txtdiscount;
        private Button btnok;
        private Button btnrevert;
    }
}