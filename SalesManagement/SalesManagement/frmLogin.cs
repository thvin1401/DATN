using SalesManagement.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) || string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Username or password is empty, please enter", "", MessageBoxButtons.OK);
                return;
            }

            if (!clsAccountDM.getAccountLoggedIn(txtusername.Text.Trim(), txtpassword.Text.Trim()))
            {
                MessageBox.Show("Username or password is not correct, please try again", "", MessageBoxButtons.OK);
                return;
            }

            mdlMain.updateMDIMainMessage("Logged in successfully!", Color.LimeGreen);

            frmMainMenu frm = new frmMainMenu();
            frm.MdiParent = mdlMain.frmMDIMain;
            frm.Show();

            this.Hide();
        }

        private void btnforgetpw_Click(object sender, EventArgs e)
        {
            frmResetPassword frm = new frmResetPassword();
            frm.MdiParent = mdlMain.frmMDIMain;
            frm.Show();
        }
    }
}
