using SalesManagement.model;

namespace SalesManagement
{
    public partial class frmCreateUpdateAccount : Form
    {
        public bool isEdit = false;

        public string username = string.Empty;

        public Guid userid;

        public bool isAvatarClick = false;

        public frmCreateUpdateAccount()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            cmbtype.DataSource = new List<string>() { "Owner", "Manager" };
            cmbtype.DisplayMember = "Name";

            cmbisactive.DataSource = new List<string>() { "Inactive", "Active" };
            cmbisactive.DisplayMember = "Name";
        }

        private void FrmCreateUpdateAccount_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                var accountInfo = clsController.getAccountInfoByUsername(username);

                if (accountInfo != DBNull.Value)
                {
                    txtfullname.Text = accountInfo.name;
                    txtemail.Text = accountInfo.email;
                    txtusername.Text = accountInfo.username;
                    txtpassword.Text = accountInfo.password;
                    dpkbirthday.Value = Convert.ToDateTime(accountInfo.birthday);
                    txtphone.Text = accountInfo.phone;
                    txtaddress.Text = accountInfo.address;
                    cmbisactive.SelectedIndex = accountInfo.isenabled == false ? 0 : 1;
                    cmbtype.SelectedIndex = accountInfo.accounttype;
                    userid = accountInfo.id;
                }

                txtusername.Enabled = false;
                txtpassword.Enabled = false;

                label4.Visible = false;
                txtpassword2.Visible = false;

                lbltitle.Text = "Update account screen";
            }

            lbltitle.Text = "Create account screen";
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
            else if (!isEdit && string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isEdit && string.IsNullOrEmpty(txtpassword2.Text))
            {
                MessageBox.Show("Please enter password again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isEdit && txtpassword.Text.Trim() != txtpassword2.Text.Trim())
            {
                MessageBox.Show("Re-enter password is not correct, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isEdit && clsAccountDM.isExistedUsername(txtusername.Text.Trim()))
            {
                MessageBox.Show("Username is existed, please enter another one", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isEdit && clsAccountDM.isExistedEmail(txtemail.Text.Trim()))
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

            var initCreateUpdateTime = DateTime.Now;

            mdlAccount account = new mdlAccount();
            account.username = txtusername.Text.Trim();
            account.password = txtpassword.Text.Trim();
            account.isenabled = Convert.ToBoolean(cmbisactive.SelectedIndex);
            account.accounttype = cmbtype.SelectedIndex;
            account.createdatetime = initCreateUpdateTime;
            account.updatedatetime = initCreateUpdateTime;

            mdlUserInfo userinfo = new mdlUserInfo();
            userinfo.id = Guid.NewGuid();
            userinfo.name = txtfullname.Text.Trim();
            userinfo.email = txtemail.Text.Trim();
            userinfo.address = txtaddress.Text.Trim();
            userinfo.phone = txtphone.Text.Trim();
            userinfo.birthday = dpkbirthday.Value;
            userinfo.rankid = Guid.NewGuid();
            userinfo.isactive = Convert.ToBoolean(cmbisactive.SelectedIndex);
            userinfo.point = 0;
            userinfo.type = cmbtype.SelectedIndex;
            userinfo.createdatetime = initCreateUpdateTime;
            userinfo.updatedatetime = initCreateUpdateTime;

            try
            {
                if (isEdit)
                {
                    userinfo.id = userid;
                    clsController.updateAccount(account, userinfo);
                    mdlMain.updateMDIMainMessage("Updated successfully!", Color.LimeGreen);
                    return;
                }
                clsController.createAccount(account, userinfo);
                mdlMain.updateMDIMainMessage("Created successfully!", Color.LimeGreen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mdlMain.updateMDIMainMessage("Process failed!", Color.Red);
                return;
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (isAvatarClick)
            {
                mdlMain.App.frmMainMenu.Show();
            }
            else
            {
                frmAccountManagement frm = new frmAccountManagement();
                frm.Show();
            }
            this.Hide();
        }
    }
}
