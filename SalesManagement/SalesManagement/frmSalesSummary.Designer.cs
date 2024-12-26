namespace SalesManagement
{
    partial class frmSalesSummary
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
            btnback = new Button();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            dpktimeto = new DateTimePicker();
            txttotaldebt = new Label();
            txttotalpayment = new Label();
            txttotalbanking = new Label();
            txttotalcash = new Label();
            txttotalsales = new Label();
            txttotalasset = new Label();
            label19 = new Label();
            txttotalassetsales = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label29 = new Label();
            label30 = new Label();
            label31 = new Label();
            txttotalloan = new Label();
            txttotalrevenue = new Label();
            SuspendLayout();
            // 
            // lbltitle
            // 
            lbltitle.BackColor = Color.Blue;
            lbltitle.Font = new Font("Segoe UI", 15.57F, FontStyle.Bold, GraphicsUnit.Point);
            lbltitle.ForeColor = Color.Aqua;
            lbltitle.Location = new Point(29, 20);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(322, 50);
            lbltitle.TabIndex = 31;
            lbltitle.Text = "Sales summary screen";
            lbltitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 127);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 32;
            label1.Text = "Total asset";
            // 
            // btnback
            // 
            btnback.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnback.Location = new Point(312, 491);
            btnback.Name = "btnback";
            btnback.Size = new Size(75, 34);
            btnback.TabIndex = 33;
            btnback.Text = "Back";
            btnback.UseVisualStyleBackColor = true;
            btnback.Click += btnback_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 196);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 34;
            label2.Text = "Total sales";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 356);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 36;
            label4.Text = "Total debt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(29, 236);
            label5.Name = "label5";
            label5.Size = new Size(70, 21);
            label5.TabIndex = 37;
            label5.Text = "Payment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(29, 447);
            label6.Name = "label6";
            label6.Size = new Size(153, 21);
            label6.TabIndex = 38;
            label6.Text = "Total revenue (Temp)";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(65, 276);
            label9.Name = "label9";
            label9.Size = new Size(44, 21);
            label9.TabIndex = 41;
            label9.Text = "Cash";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(65, 314);
            label10.Name = "label10";
            label10.Size = new Size(66, 21);
            label10.TabIndex = 42;
            label10.Text = "Banking";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(30, 401);
            label11.Name = "label11";
            label11.Size = new Size(76, 21);
            label11.TabIndex = 43;
            label11.Text = "Total loan";
            // 
            // dpktimeto
            // 
            dpktimeto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dpktimeto.Location = new Point(135, 95);
            dpktimeto.Name = "dpktimeto";
            dpktimeto.Size = new Size(252, 29);
            dpktimeto.TabIndex = 44;
            // 
            // txttotaldebt
            // 
            txttotaldebt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotaldebt.Location = new Point(198, 356);
            txttotaldebt.Name = "txttotaldebt";
            txttotaldebt.Size = new Size(153, 21);
            txttotaldebt.TabIndex = 45;
            txttotaldebt.Text = "0";
            txttotaldebt.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalpayment
            // 
            txttotalpayment.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalpayment.Location = new Point(198, 236);
            txttotalpayment.Name = "txttotalpayment";
            txttotalpayment.Size = new Size(153, 21);
            txttotalpayment.TabIndex = 46;
            txttotalpayment.Text = "0";
            txttotalpayment.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalbanking
            // 
            txttotalbanking.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalbanking.Location = new Point(197, 314);
            txttotalbanking.Name = "txttotalbanking";
            txttotalbanking.Size = new Size(153, 21);
            txttotalbanking.TabIndex = 47;
            txttotalbanking.Text = "0";
            txttotalbanking.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalcash
            // 
            txttotalcash.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalcash.Location = new Point(197, 276);
            txttotalcash.Name = "txttotalcash";
            txttotalcash.Size = new Size(153, 21);
            txttotalcash.TabIndex = 48;
            txttotalcash.Text = "0";
            txttotalcash.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalsales
            // 
            txttotalsales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalsales.Location = new Point(197, 196);
            txttotalsales.Name = "txttotalsales";
            txttotalsales.Size = new Size(153, 21);
            txttotalsales.TabIndex = 50;
            txttotalsales.Text = "0";
            txttotalsales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalasset
            // 
            txttotalasset.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalasset.Location = new Point(197, 127);
            txttotalasset.Name = "txttotalasset";
            txttotalasset.Size = new Size(153, 21);
            txttotalasset.TabIndex = 51;
            txttotalasset.Text = "0";
            txttotalasset.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(28, 162);
            label19.Name = "label19";
            label19.Size = new Size(119, 21);
            label19.TabIndex = 52;
            label19.Text = "Total sales asset";
            // 
            // txttotalassetsales
            // 
            txttotalassetsales.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalassetsales.Location = new Point(197, 162);
            txttotalassetsales.Name = "txttotalassetsales";
            txttotalassetsales.Size = new Size(153, 21);
            txttotalassetsales.TabIndex = 53;
            txttotalassetsales.Text = "0";
            txttotalassetsales.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(29, 97);
            label21.Name = "label21";
            label21.Size = new Size(59, 21);
            label21.TabIndex = 54;
            label21.Text = "To date";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(356, 133);
            label22.Name = "label22";
            label22.Size = new Size(31, 15);
            label22.TabIndex = 55;
            label22.Text = "VND";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(356, 168);
            label23.Name = "label23";
            label23.Size = new Size(31, 15);
            label23.TabIndex = 56;
            label23.Text = "VND";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label24.Location = new Point(356, 202);
            label24.Name = "label24";
            label24.Size = new Size(31, 15);
            label24.TabIndex = 57;
            label24.Text = "VND";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label25.Location = new Point(356, 241);
            label25.Name = "label25";
            label25.Size = new Size(31, 15);
            label25.TabIndex = 58;
            label25.Text = "VND";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label26.Location = new Point(356, 282);
            label26.Name = "label26";
            label26.Size = new Size(31, 15);
            label26.TabIndex = 59;
            label26.Text = "VND";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label27.Location = new Point(356, 320);
            label27.Name = "label27";
            label27.Size = new Size(31, 15);
            label27.TabIndex = 60;
            label27.Text = "VND";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label29.Location = new Point(357, 361);
            label29.Name = "label29";
            label29.Size = new Size(31, 15);
            label29.TabIndex = 62;
            label29.Text = "VND";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label30.Location = new Point(357, 406);
            label30.Name = "label30";
            label30.Size = new Size(31, 15);
            label30.TabIndex = 63;
            label30.Text = "VND";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label31.Location = new Point(357, 453);
            label31.Name = "label31";
            label31.Size = new Size(31, 15);
            label31.TabIndex = 64;
            label31.Text = "VND";
            // 
            // txttotalloan
            // 
            txttotalloan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalloan.Location = new Point(197, 400);
            txttotalloan.Name = "txttotalloan";
            txttotalloan.Size = new Size(153, 21);
            txttotalloan.TabIndex = 65;
            txttotalloan.Text = "0";
            txttotalloan.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txttotalrevenue
            // 
            txttotalrevenue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txttotalrevenue.Location = new Point(198, 447);
            txttotalrevenue.Name = "txttotalrevenue";
            txttotalrevenue.Size = new Size(153, 21);
            txttotalrevenue.TabIndex = 66;
            txttotalrevenue.Text = "0";
            txttotalrevenue.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmSalesSummary
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(409, 537);
            ControlBox = false;
            Controls.Add(txttotalrevenue);
            Controls.Add(txttotalloan);
            Controls.Add(label31);
            Controls.Add(label30);
            Controls.Add(label29);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(label21);
            Controls.Add(txttotalassetsales);
            Controls.Add(label19);
            Controls.Add(txttotalasset);
            Controls.Add(txttotalsales);
            Controls.Add(txttotalcash);
            Controls.Add(txttotalbanking);
            Controls.Add(txttotalpayment);
            Controls.Add(txttotaldebt);
            Controls.Add(dpktimeto);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(btnback);
            Controls.Add(label1);
            Controls.Add(lbltitle);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSalesSummary";
            StartPosition = FormStartPosition.CenterParent;
            Load += frmSalesSummary_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbltitle;
        private Label label1;
        private Button btnback;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private DateTimePicker dpktimeto;
        private Label txttotaldebt;
        private Label txttotalbanking;
        private Label txttotalcash;
        private Label txttotalpayment;
        private Label txttotalsales;
        private Label txttotalasset;
        private Label label19;
        private Label txttotalassetsales;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
        private Label label29;
        private Label label30;
        private Label label31;
        private Label txttotalloan;
        private Label txttotalrevenue;
    }
}