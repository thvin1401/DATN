using SalesManagement.model;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SalesManagement
{
    public partial class frmCreateUpdateUserinfo : Form
    {
        public bool isEdit = false;

        public string userId = string.Empty;

        public frmCreateUpdateUserinfo()
        {
            InitializeComponent();

            cmbisactive.Items.Clear();
            cmbisactive.Items.Add("Inactive");
            cmbisactive.Items.Add("Active");

            cmbrank.Items.Clear();

            var rankData = mdlMain.App.ranks;
            foreach (var rank in rankData)
            {
                cmbrank.Items.Add(new ComboBoxItem()
                {
                    Name = rank.name,
                    Value = rank.id.ToString()
                });
            }

            cmbrank.DisplayMember = "Name";
            cmbrank.ValueMember = "Value";

            cmbtype.Items.Clear();

            cmbtype.Items.Add("Owner");
            cmbtype.Items.Add("Manager");
            cmbtype.Items.Add("Customer");
            cmbtype.Items.Add("Provider");
            cmbtype.Items.Add("Debt owner");

            cmbisactive.SelectedIndex = 1;
            cmbrank.SelectedIndex = 0;
            cmbtype.SelectedIndex = 2;

            txtpoint.Text = "0";
            txtpoint.ReadOnly = true;
            cmbrank.Enabled = false;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool checkInputData()
        {
            if (string.IsNullOrEmpty(txtfullname.Text.Trim()))
            {
                MessageBox.Show("Please enter fullname", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtemail.Text.Trim()))
            {
                MessageBox.Show("Please enter email", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!Regex.IsMatch(txtemail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Input email was incorrect, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(isEdit && clsController.checkExistEmail(txtemail.Text.Trim(), userId))
            {
                MessageBox.Show("Email is existed, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!isEdit && clsController.checkExistEmail(txtemail.Text.Trim()))
            {
                MessageBox.Show("Email is existed, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void clearControls()
        {
            txtfullname.Clear();
            txtaddress.Clear();
            txtemail.Clear();
            txtphone.Clear();
            txtpoint.Clear();
            txtpoint.Text = "0";

            cmbrank.SelectedIndex = 0;
            cmbisactive.SelectedIndex = 1;
            cmbtype.SelectedIndex = 3;

            dpkbirthday.Value = DateTime.Now;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
            {
                return;
            }

            var creationTime = DateTime.Now;

            mdlUserInfo user = new mdlUserInfo();
            user.id = Guid.NewGuid();
            user.name = txtfullname.Text.Trim();
            user.address = txtaddress.Text.Trim();
            user.phone = txtphone.Text.Trim();
            user.email = txtemail.Text.Trim();
            user.rankid = Guid.Parse(((ComboBoxItem)cmbrank.SelectedItem).Value.ToString());
            user.isactive = Convert.ToBoolean(cmbisactive.SelectedIndex);
            user.point = Convert.ToInt32(txtpoint.Text);
            user.type = cmbtype.SelectedIndex;
            user.birthday = dpkbirthday.Value;
            user.createdatetime = creationTime;
            user.updatedatetime = creationTime;

            if (isEdit)
            {
                user.id = Guid.Parse(userId);

                if (clsController.updateUser(user))
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageUpdateSuccessfully, Color.LimeGreen);
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(clsConfig.messageErrorTryAgain, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        bindUserData(userId);
                    }
                    else
                    {
                        mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                        this.Close();
                    }
                }
            }
            else
            {
                if (clsController.createUser(user))
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageCreateSuccessfully, Color.LimeGreen);
                    this.Close();
                }
                else
                {
                    DialogResult result = MessageBox.Show(clsConfig.messageErrorTryAgain, "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        clearControls();
                    }
                    else
                    {
                        mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                        this.Close();
                    }
                }
            }
        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void frmCreateUpdateUserinfo_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                lbltitle.Text = "User update screen";

                bindUserData(userId);
            }
            else
            {
                lbltitle.Text = "User create screen";
            }
        }

        private void bindUserData(string userId)
        {
            var user = clsController.getUserInfoById(userId);

            txtfullname.Text = user.name;
            txtaddress.Text = user.address;
            txtphone.Text = user.phone;
            txtemail.Text = user.email;
            txtpoint.Text = user.point.ToString("N0", CultureInfo.CurrentCulture);

            dpkbirthday.Value = user.birthday;
            cmbrank.SelectedIndex = getCmbSelectedIndexByValue(cmbrank, user.rankid.ToString());

            cmbtype.SelectedIndex = user.type;
            cmbisactive.SelectedIndex = user.isactive ? 1 : 0;
        }

        private int getCmbSelectedIndexByValue(ComboBox cmb, string value)
        {
            foreach(var item in cmb.Items)
            {
                if(((ComboBoxItem)item).Value == value)
                {
                    return cmb.Items.IndexOf(item);
                }
            }

            return 0;
        }
    }
}
