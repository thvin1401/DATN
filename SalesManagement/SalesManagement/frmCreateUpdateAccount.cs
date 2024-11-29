using SalesManagement.model;

namespace SalesManagement
{
    public partial class frmCreateUpdateAccount : Form
    {
        public bool isEdit = false;

        public string username = string.Empty;

        public Guid userid;

        public bool isAvatarClick = false;

        public List<mdlUserInfo> listUserAvailable;

        public frmCreateUpdateAccount()
        {
            InitializeComponent();

            cmbtype.Items.Clear();
            cmbtype.Items.Add("Owner");
            cmbtype.Items.Add("Manager");

            cmbisactive.Items.Clear();
            cmbisactive.Items.Add("Inactive");
            cmbisactive.Items.Add("Active");

            listUserAvailable = clsController.getAllUserCanCreateAccount();

            cmbuserinfo.Items.Clear();
            cmbuserinfo.Items.Add("");

            foreach (var item in listUserAvailable)
            {
                cmbuserinfo.Items.Add(new ComboBoxItem()
                {
                    Name = clsUtility.getUserTypeString(item.type) + item.name + " - " + item.phone + " - " + item.address,
                    Value = item.id.ToString()
                });
            }

            cmbuserinfo.DisplayMember = "Name";
            cmbuserinfo.ValueMember = "Value";

            cmbuserinfo.SelectedIndex = 0;
            cmbtype.SelectedIndex = 0;
            cmbisactive.SelectedIndex = 1;

            cmbuserinfo.Enabled = false;
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
                    txtpassword2.Text = accountInfo.password;
                    dpkbirthday.Value = Convert.ToDateTime(accountInfo.birthday);
                    txtphone.Text = accountInfo.phone;
                    txtaddress.Text = accountInfo.address;
                    cmbisactive.SelectedIndex = accountInfo.isenabled == false ? 0 : 1;
                    cmbtype.SelectedIndex = accountInfo.accounttype;
                    userid = accountInfo.id;
                }

                txtusername.Enabled = false;

                ckbhaveinfo.Visible = false;
                cmbuserinfo.Visible = false;

                if (!isAvatarClick)
                {
                    txtpassword.Enabled = false;

                    label4.Visible = false;
                    txtpassword2.Visible = false;
                }

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
            else if ((isAvatarClick || !isEdit) && string.IsNullOrEmpty(txtpassword.Text))
            {
                MessageBox.Show("Please enter password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((isAvatarClick || !isEdit) && string.IsNullOrEmpty(txtpassword2.Text))
            {
                MessageBox.Show("Please enter password again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if ((isAvatarClick || !isEdit) && txtpassword.Text.Trim() != txtpassword2.Text.Trim())
            {
                MessageBox.Show("Re-enter password is not correct, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (!isEdit && clsAccountDM.isExistedUsername(txtusername.Text.Trim()))
            {
                MessageBox.Show("Username is existed, please enter another one", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (clsAccountDM.isExistedEmail(txtemail.Text.Trim(), txtusername.Text.Trim()))
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

                    if (isAvatarClick)
                    {
                        clsController.updateAccount(account, userinfo, true);
                    }
                    else
                    {
                        clsController.updateAccount(account, userinfo, false);
                    }

                    mdlMain.updateMDIMainMessage(clsConfig.messageUpdateSuccessfully, Color.LimeGreen);
                }
                else
                {
                    if (cmbuserinfo.SelectedIndex != 0)
                    {
                        userinfo.id = Guid.Parse(((ComboBoxItem)cmbuserinfo.SelectedItem).Value);

                        clsController.createAccount(account, userinfo, true);
                    }
                    else
                    {
                        clsController.createAccount(account, userinfo, false);
                    }

                    mdlMain.updateMDIMainMessage(clsConfig.messageCreateSuccessfully, Color.LimeGreen);
                }

                this.Close();
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show(ex.Message, clsConfig.messageErrorTryAgain, MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    if (isEdit)
                    {
                        FrmCreateUpdateAccount_Load(sender, e);
                    }
                    else
                    {
                        clearColtrols();
                    }
                }
                else
                {
                    mdlMain.log(ex.Message, ex);
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                    this.Close();
                }
            }
        }

        private void clearColtrols()
        {
            ckbhaveinfo.Checked = false;

            cmbuserinfo.SelectedIndex = 0;
            cmbtype.SelectedIndex = 0;
            cmbisactive.SelectedIndex = 1;

            txtfullname.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtusername.Clear();
            txtpassword.Clear();
            txtpassword2.Clear();
            txtphone.Clear();
            dpkbirthday.Value = DateTime.Now;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbhaveinfo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbhaveinfo.Checked)
            {
                cmbuserinfo.Enabled = true;
                txtfullname.ReadOnly = true;
                txtemail.ReadOnly = true;
                txtphone.ReadOnly = true;
                txtaddress.ReadOnly = true;
                dpkbirthday.Enabled = false;
                cmbtype.Enabled = false;
            }
            else
            {
                clearColtrols();

                cmbuserinfo.Enabled = false;
                txtfullname.ReadOnly = false;
                txtemail.ReadOnly = false;
                txtphone.ReadOnly = false;
                txtaddress.ReadOnly = false;
                dpkbirthday.Enabled = false;
            }
        }

        private void cmbuserinfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbuserinfo.SelectedIndex != 0)
            {
                var userInfo = listUserAvailable.First(x => x.id == Guid.Parse(((ComboBoxItem)cmbuserinfo.SelectedItem).Value));

                txtfullname.Text = userInfo.name;
                txtemail.Text = userInfo.email;
                txtaddress.Text = userInfo.address;
                txtphone.Text = userInfo.phone;
                dpkbirthday.Value = userInfo.birthday;
                cmbtype.SelectedIndex = userInfo.type;
            }
        }

        private void txtnonspace_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
    }
}
