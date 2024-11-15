using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace SalesManagement
{
    public partial class frmMainMenu : Form
    {
        private System.Windows.Forms.Timer clockTimer;

        public frmMainMenu()
        {
            InitializeComponent();

            btnproductmanagement.Enter += control_Hover;
            btnproductmanagement.Leave += control_Leave;

            btnusermanagement.Enter += control_Hover;
            btnusermanagement.Leave += control_Leave;

            btndebtmanagement.Enter += control_Hover;
            btndebtmanagement.Leave += control_Leave;

            btnsearchbilljournal.Enter += control_Hover;
            btnsearchbilljournal.Leave += control_Leave;

            btnsettings.Enter += control_Hover;
            btnsettings.Leave += control_Leave;

            clockTimer = new System.Windows.Forms.Timer
            {
                Interval = 1000
            };

            clockTimer.Tick += ClockTimer_Tick;
            clockTimer.Start();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            var currentUser = mdlMain.App.currentUser;
            CreateCircularButton(currentUser.username);
            lblaccounttype.Text = currentUser.accounttype == 0 ? "Owner" : "Manager";
        }

        private void CreateCircularButton(string username)
        {
            CircularButton btnavatar = new CircularButton
            {
                Initial = username.Substring(0, 1).ToUpper(),
                Width = 50,
                Height = 50,
                Location = new Point(20, 18),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnavatar.FlatAppearance.BorderSize = 0;
            btnavatar.Cursor = Cursors.Hand;
            btnavatar.Click += new EventHandler(btnavatar_Click);

            panel2.Controls.Add(btnavatar);
        }

        private void btnavatar_Click(object sender, EventArgs eventArgs)
        {
            
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString("ddd, dd MMMM yyyy");
            lbltime.Text = DateTime.Now.ToString("HH:mm");
        }

        private void control_Hover(object sender, EventArgs e)
        {
            if (sender is Control)
            {
                ((Control)sender).BackColor = Color.LightSkyBlue;
            }
        }

        private void control_Leave(object sender, EventArgs e)
        {
            if (sender is Control)
            {
                ((Control)sender).BackColor = Color.LightGray;
            }
        }

        private void btnproductmanagement_Click(object sender, EventArgs e)
        {
            frmProductManagement frm = new frmProductManagement();
            frm.Show();

            this.Hide();
        }

        private void btnusermanagement_Click(object sender, EventArgs e)
        {
            frmUserManagement frm = new frmUserManagement();
            frm.Show();

            this.Hide();
        }

        private void btndebtmanagement_Click(object sender, EventArgs e)
        {
            frmDebtManagement frm = new frmDebtManagement();
            frm.Show();

            this.Hide();
        }

        private void btnsearchbilljournal_Click(object sender, EventArgs e)
        {
            frmSearchBillJournal frm = new frmSearchBillJournal();
            frm.Show();

            this.Hide();
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            frmSettings frm = new frmSettings();
            frm.Show();

            this.Hide();
        }

        private void btnaccountmanagement_Click(object sender, EventArgs e)
        {
            frmAccountManagement frm = new frmAccountManagement();

            frm.Show();

            this.Hide();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
