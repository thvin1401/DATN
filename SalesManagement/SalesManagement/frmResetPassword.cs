using System.Text.RegularExpressions;

namespace SalesManagement
{
    public partial class frmResetPassword : Form
    {
        public static readonly log4net.ILog logger = log4net.LogManager.GetLogger(typeof(frmResetPassword));

        public frmResetPassword()
        {
            InitializeComponent();

            lblGuide.Text = "To reset password, please enter your username and email adress used to create account";
        }

        private void btnResetpw_Click(object sender, EventArgs e)
        {
            if (!checkValidInput())
                return;

            txtemail.Enabled = false;
            txtusername.Enabled = false;

            var mail = txtemail.Text.Trim();
            var subject = "Reset password";
            var body = "Your new password is";
            var content = clsUtility.GenerateRandomPassword();

            if (clsAccountDM.changePassword(txtusername.Text.Trim(), content) && clsUtility.sendMail(mail, subject, body, content))
            {
                lblGuide.Text = "Mail sent successfully";
                lblGuide.ForeColor = Color.Red;
            }
            else
            {
                MessageBox.Show("Something went wrong, please try again", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblGuide.Text = "To reset password, please enter your username and email adress used to create account";
            }

            txtemail.Enabled = true;
            txtusername.Enabled = true;
        }

        private bool checkValidInput()
        {
            var username = txtusername.Text.Trim();
            var email = txtemail.Text.Trim();

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter username", "", MessageBoxButtons.OK);
                return false;
            }
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please enter email", "", MessageBoxButtons.OK);
                return false;
            }
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Input email was incorrect, please try again", "", MessageBoxButtons.OK);
                return false;
            }
            if (!clsAccountDM.isExistedUsername(username))
            {
                MessageBox.Show("Username is not existed", "", MessageBoxButtons.OK);
                return false;
            }
            if (!clsAccountDM.isExistedEmail(email))
            {
                MessageBox.Show("Email is not existed", "", MessageBoxButtons.OK);
                return false;
            }
            if (!clsAccountDM.checkEmailUsernameConsistency(username, email))
            {
                MessageBox.Show("Input email was used by another account, please try again", "", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Dispose();

            this.Hide();
        }
    }
}
