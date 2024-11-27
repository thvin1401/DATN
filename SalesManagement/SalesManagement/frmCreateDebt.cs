using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmCreateDebt : Form
    {
        public frmCreateDebt()
        {
            InitializeComponent();

            cmbactor.Items.Clear();
            cmbactor.Items.Add("");

            var listUserInfo = clsController.getUserByNameAndType();

            foreach (var item in listUserInfo)
            {
                ComboBoxItem cmbItem = new ComboBoxItem();
                cmbItem.Name = item.name + " - " + item.phone + " - " + item.address;
                cmbItem.Value = item.id.ToString();
                cmbactor.Items.Add(cmbItem);
            }

            cmbactor.DisplayMember = "Name";
            cmbactor.ValueMember = "Value";

            cmbstatus.Items.Clear();
            cmbstatus.Items.Add("Unpaid");
            cmbstatus.Items.Add("Partly paid");
            cmbstatus.Items.Add("Full paid");
            cmbstatus.Items.Add("Deleted");

            cmbpaymentmethod.Items.Clear();
            cmbpaymentmethod.Items.Add("CASH");
            cmbpaymentmethod.Items.Add("BANKING");

            cmbactor.SelectedIndex = 0;
            cmbstatus.SelectedIndex = 0;
            cmbpaymentmethod.SelectedIndex = 0;

            txtcircle.Enabled = false;
            txtinterest.Enabled = false;
            cmbpaymentmethod.Enabled = false;
            dpkpaidtime.Enabled = false;
            txtpaidafter.Text = "7";
            lblfullpaid.Visible = false;
        }

        private void clearControls()
        {
            cmbstatus.SelectedIndex = 0;
            cmbactor.SelectedIndex = 0;
            cmbpaymentmethod.SelectedIndex = 0;

            txtamount.Clear();
            txtinterest.Clear();
            txtcircle.Clear();
            txtpaidafter.Text = "7";

            ckbcircleinterest.Checked = false;
            ckbisloan.Checked = false;

            dpkpaidtime.Value = DateTime.Now;
            dpkprocessedtime.Value = DateTime.Now;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
            {
                return;
            }

            try
            {
                var receiptNumber = createBillInfo();

                if (receiptNumber != 0)
                {
                    createDebtInfo(receiptNumber, cmbstatus.SelectedIndex);

                    if (cmbstatus.SelectedIndex == 2)
                    {
                        createPayment(receiptNumber);
                    }

                    mdlMain.updateMDIMainMessage("Create successfully", Color.LimeGreen);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                DialogResult result = MessageBox.Show("Process failed, create again ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if (result == DialogResult.Yes)
                {
                    clearControls();
                }
                else
                {
                    mdlMain.updateMDIMainMessage("Process failed", Color.Red);
                    mdlMain.log(ex.Message, ex);
                    this.Close();
                }

                return;
            }
        }

        private void createPayment(int receiptNumber)
        {
            mdlPayment paymentInfo;

            var creationTime = DateTime.Now;

            if (cmbpaymentmethod.SelectedIndex != 2)
            {
                paymentInfo = new mdlPayment()
                {
                    id = Guid.NewGuid(),
                    receiptnumber = receiptNumber,
                    amount = Convert.ToDouble(txtamount.Text.Replace(".", "").Replace(",", "")),
                    userinfoid = cmbactor.SelectedIndex == 0 ? Guid.NewGuid() : Guid.Parse(((ComboBoxItem)cmbactor.SelectedItem).Value.ToString()),
                    paymentmethod = cmbpaymentmethod.SelectedIndex,
                    paydatetime = creationTime,
                    createdatetime = creationTime
                };

                clsController.insertPaymentData(paymentInfo);
            }
        }

        private void createDebtInfo(int receiptNumber, int paidStatus)
        {
            var creationTime = DateTime.Now;

            mdlDebtManagement debt = new mdlDebtManagement();
            debt.id = Guid.NewGuid();
            debt.receiptnumber = receiptNumber;
            debt.interest = txtinterest.Enabled ? Convert.ToDouble(txtinterest.Text) : 0;
            debt.circle = txtcircle.Enabled ? Convert.ToInt32(txtcircle.Text) : 0;
            debt.status = paidStatus;
            debt.processeddatetime = dpkprocessedtime.Value;
            debt.type = ckbisloan.Checked ? 1 : 0;
            debt.paiddatetime = dpkpaidtime.Value;
            debt.createdatetime = creationTime;
            debt.updatedatetime = creationTime;
            debt.paidbeforetime = creationTime.AddDays(Convert.ToInt32(txtpaidafter.Text));

            clsController.insertDebtDetail(debt);
        }

        private bool checkInputData()
        {
            if (cmbactor.SelectedIndex == 0)
            {
                MessageBox.Show("No user selected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtamount.Text.Replace(".", "").Replace(",", "").Trim()))
            {
                MessageBox.Show("Please enter amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtcircle.Enabled && string.IsNullOrEmpty(txtcircle.Text))
            {
                MessageBox.Show("Please enter circle (days)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtinterest.Enabled && string.IsNullOrEmpty(txtinterest.Text))
            {
                MessageBox.Show("Please enter interest (%)", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtpaidafter.Text))
            {
                MessageBox.Show("Please enter number of day before the debt is paid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private int createBillInfo()
        {
            DateTime creationTime = DateTime.Now;

            mdlBill billInfo = new mdlBill();
            billInfo.receiptnumber = clsController.getNewReceiptNumber();
            billInfo.amount = string.IsNullOrEmpty(txtamount.Text) ? 0 : Convert.ToDouble(txtamount.Text.Replace(".", "").Replace(",", ""));
            billInfo.discount = 0;
            billInfo.payamount = string.IsNullOrEmpty(txtamount.Text) ? 0 : Convert.ToDouble(txtamount.Text.Replace(".", "").Replace(",", ""));
            billInfo.userinfoid = cmbactor.SelectedIndex == 0 ? Guid.NewGuid() : Guid.Parse(((ComboBoxItem)cmbactor.SelectedItem).Value.ToString());
            billInfo.isdeleted = false;
            billInfo.createdatetime = creationTime;
            billInfo.updatedatetime = creationTime;

            if (clsController.insertBill(billInfo))
            {
                return billInfo.receiptnumber;
            }
            return 0;
        }

        private void ckbcircleinterest_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbcircleinterest.Checked)
            {
                txtinterest.Clear();
                txtcircle.Clear();
                txtcircle.Enabled = true;
                txtinterest.Enabled = true;
            }
            else
            {
                txtinterest.Clear();
                txtcircle.Clear();
                txtcircle.Enabled = false;
                txtinterest.Enabled = false;
            }
        }

        private void txtnumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtamount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtamount.Text.Replace(".", "").Replace(",", "")))
            {
                txtamount.Text = Convert.ToDouble(txtamount.Text).ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        private void cmbstatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbstatus.SelectedIndex == 2)
            {
                dpkpaidtime.Enabled = true;
                dpkpaidtime.Value = DateTime.Now;

                cmbpaymentmethod.Enabled = true;
                cmbpaymentmethod.SelectedIndex = 0;

                lblfullpaid.Visible = true;
            }
            else
            {
                dpkpaidtime.Enabled = false;
                dpkpaidtime.Value = DateTime.Now;

                cmbpaymentmethod.Enabled = false;
                cmbpaymentmethod.SelectedIndex = 0;

                lblfullpaid.Visible = false;
            }
        }
    }
}
