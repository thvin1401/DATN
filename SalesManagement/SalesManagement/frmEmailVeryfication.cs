namespace SalesManagement
{
    public partial class frmEmailVeryfication : Form
    {
        public int code = 0;
        public int resendCode = 0;
        public string txtEmail = "";
        public string message = "";
        public frmEmailVeryfication()
        {
            InitializeComponent();
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcode.Text))
            {
                lblmessage.Text = "Please enter code";
                lblmessage.ForeColor = Color.Red;

                return;
            }

            var enterCode = Convert.ToInt32(txtcode.Text);

            if (enterCode == code || enterCode == resendCode)
            {
                this.DialogResult = DialogResult.OK;
                mdlMain.updateMDIMainMessage("Verify successfully!", Color.LimeGreen);
                this.Close();
            }
            else
            {
                lblmessage.Text = "Incorrect code, please try again!";
                lblmessage.ForeColor = Color.Red;

                txtcode.Clear();

                txtcode.Focus();
            }
        }

        private void btnresend_Click(object sender, EventArgs e)
        {
            txtcode.Clear();

            txtcode.Focus();

            Random random = new Random();

            resendCode = random.Next(1000, 10000);

            if (clsUtility.sendMail(txtEmail.Trim(), "Verification Code", "Your code is: ", "" + resendCode))
            {
                lblmessage.Text = "Email sent";
                lblmessage.ForeColor = Color.LimeGreen;
            }
            else
            {
                lblmessage.Text = "Email sent failed";
                lblmessage.ForeColor = Color.Red;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmailVeryfication_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(message))
            {
                lblmessage.Text = message;
                lblmessage.ForeColor = Color.LimeGreen;
            }
        }
    }
}
