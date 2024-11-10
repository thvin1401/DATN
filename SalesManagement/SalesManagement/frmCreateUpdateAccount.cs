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
    public partial class frmCreateUpdateAccount : Form
    {
        public frmCreateUpdateAccount()
        {
            InitializeComponent();

            cmbtype.DataSource = new List<string>() { "Owner", "Manager", "Customer", "Provider"};
            cmbtype.DisplayMember = "Name";
        }

        private bool checkInputData()
        {
            if (string.IsNullOrEmpty(txtfullname.Text))
            {
                MessageBox.Show("Please enter full name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtemail.Text))
            {
                MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtusername.Text))
            {
                MessageBox.Show("Please enter username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (string.IsNullOrEmpty(txtpassword2.Text))
            {
                MessageBox.Show("Please enter password again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (txtpassword.Text.Trim() != txtpassword2.Text.Trim())
            {
                MessageBox.Show("Re-enter password is not correct, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (clsAccountDM.isExistedUsername(txtusername.Text.Trim()))
            {
                MessageBox.Show("Username is existed, please enter another one", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (clsAccountDM.isExistedEmail(txtemail.Text.Trim()))
            {
                MessageBox.Show("Email is used by another account, please enter another one", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
            {
                return;
            }

            mdlAccount account = new mdlAccount();
            account.username = txtusername.Text.Trim();
            account.password = txtpassword.Text.Trim();
            account.isenabled = true;

            mdlUserInfo userinfo = new mdlUserInfo();
            userinfo.id = Guid.NewGuid();
            userinfo.name = txtfullname.Text.Trim();
            userinfo.email = txtemail.Text.Trim();
            userinfo.address = txtaddress.Text.Trim();
            userinfo.phone = txtphone.Text.Trim();
            userinfo.birthday = dpkbirthday.Value;
            userinfo.rankid = Guid.NewGuid();
            userinfo.isactive = true;
            userinfo.point = Convert.ToInt32(txtpoint.Text);
            userinfo.type = cmbtype.SelectedIndex;

            try
            {
                clsAccountDM.createAccount(account, userinfo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
