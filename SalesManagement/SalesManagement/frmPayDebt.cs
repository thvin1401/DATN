using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmPayDebt : Form
    {
        public string selectedDebtID = string.Empty;

        public int originalStatus = 0;

        private int currentStatus = 0;

        private int receiptNumber = 0;

        public frmPayDebt()
        {
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void clearControls()
        {
            txtbankingamount.Text = "0";
            txtcashamount.Text = "0";

            ckbisfullpaid.Checked = false;
            cmbpayee.SelectedIndex = 0;
            cmbpaymentmethod.SelectedIndex = 0;
            dpkpaidtime.Value = DateTime.Now;

            currentStatus = originalStatus;
            setStatusText();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            if(cmbpayee.Items.Count > 1 && cmbpayee.SelectedIndex == 0)
            {
                MessageBox.Show("No payee selected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(txtbankingamount.Text == "0" && txtcashamount.Text == "0")
            {
                MessageBox.Show("Please enter payment amount", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            try
            {
                var userId = Guid.Parse(((ComboBoxItem)cmbpayee.SelectedItem).Value);

                var paymentAmount = createPaymentInfo(receiptNumber, userId);

                updateDebtStatus();

                updateUserPointAndRank(paymentAmount, userId);

                mdlMain.updateMDIMainMessage("Paid successfully !", Color.LimeGreen);

                this.Close();
            }
            catch(Exception ex)
            {
                mdlMain.log(ex.Message, ex);
                DialogResult result = MessageBox.Show("An error occur, pay again ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                if(result == DialogResult.Yes)
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

        private void updateDebtStatus()
        {
            mdlDebtManagement debt = new mdlDebtManagement();

            debt.id = Guid.Parse(selectedDebtID);
            debt.status = ckbisfullpaid.Checked ? 2 : 1;
            debt.paiddatetime = dpkpaidtime.Value;
            debt.updatedatetime = DateTime.Now;

            clsController.changeDebtStatus(debt);
        }

        private void updateUserPointAndRank(double paymentAmount, Guid userID)
        {
            mdlUserInfo selectedUser = new mdlUserInfo();

            selectedUser.id = userID;
            selectedUser.point += (int)(paymentAmount / clsConfig.amountPerPoint);
            selectedUser.rankid = mdlMain.App.ranks.OrderByDescending(x => x.achivepoint).First(x => x.achivepoint <= selectedUser.point).id;
            selectedUser.updatedatetime = DateTime.Now;

            clsController.updateUserPointAndRank(selectedUser);
        }

        private double createPaymentInfo(int receiptNumber, Guid userinfoId)
        {
            mdlPayment paymentInfo;

            var creationTime = DateTime.Now;

            double amount = 0;

            if (cmbpaymentmethod.SelectedIndex != 2)
            {
                amount = cmbpaymentmethod.SelectedIndex == 0 ? Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", "")) :
                    Convert.ToDouble(txtbankingamount.Text.Replace(".", "").Replace(",", ""));

                paymentInfo = new mdlPayment()
                {
                    id = Guid.NewGuid(),
                    receiptnumber = receiptNumber,
                    amount = amount,
                    userinfoid = userinfoId,
                    paymentmethod = cmbpaymentmethod.SelectedIndex,
                    paydatetime = creationTime,
                    createdatetime = creationTime
                };

                clsController.insertPaymentData(paymentInfo);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    var payAmount = i == 0 ? Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", "")) :
                        Convert.ToDouble(txtbankingamount.Text.Replace(".", "").Replace(",", ""));

                    amount += payAmount; 

                    paymentInfo = new mdlPayment()
                    {
                        id = Guid.NewGuid(),
                        receiptnumber = receiptNumber,
                        amount = payAmount,
                        userinfoid = userinfoId,
                        paymentmethod = i,
                        paydatetime = creationTime,
                        createdatetime = creationTime
                    };

                    clsController.insertPaymentData(paymentInfo);
                }
            }

            return amount;
        }

        private void txtnumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void ckbisfullpaid_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbisfullpaid.Checked)
            {
                currentStatus = 2;
                lblstatus.Text = "Full paid";
                lblstatus.ForeColor = Color.LimeGreen;

                if (!txtbankingamount.Enabled && txtcashamount.Enabled)
                {
                    txtcashamount.Text = txttotal.Text;
                    txtcashamount.ReadOnly = true;
                }
                if (!txtcashamount.Enabled && txtbankingamount.Enabled)
                {
                    txtbankingamount.Text = txttotal.Text;
                    txtbankingamount.ReadOnly = true;
                }
                if (txtcashamount.Enabled && txtbankingamount.Enabled)
                {
                    txtcashamount.Text = txttotal.Text;
                    txtcashamount.ReadOnly = false;
                    txtbankingamount.ReadOnly = false;
                }
            }
            else
            {
                currentStatus = originalStatus;
                txtcashamount.ReadOnly = false;
                txtbankingamount.ReadOnly = false;
            }

            setStatusText();
        }

        private void setStatusText()
        {
            switch (currentStatus)
            {
                case 0:
                    {
                        lblstatus.Text = "Unpaid";
                        lblstatus.ForeColor = Color.Red;
                        break;
                    }
                case 1:
                    {
                        lblstatus.Text = "Partly paid";
                        lblstatus.ForeColor = Color.Blue;
                        break;
                    }
                case 2:
                    {
                        lblstatus.Text = "Full paid";
                        lblstatus.ForeColor = Color.LimeGreen;
                        break;
                    }
                default:
                    {
                        lblstatus.Text = "";
                        break;
                    }
            }
        }

        private void cmbpaymentmethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbpaymentmethod.SelectedIndex)
            {
                case 0:
                    {
                        txtcashamount.Enabled = true;
                        txtbankingamount.Enabled = false;
                        break;
                    }
                case 1:
                    {
                        txtcashamount.Enabled = false;
                        txtbankingamount.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        txtcashamount.Enabled = true;
                        txtbankingamount.Enabled = true;
                        break;
                    }
                default:
                    {
                        cmbpaymentmethod.SelectedIndex = 0;
                        txtcashamount.Enabled = true;
                        txtbankingamount.Enabled = false;
                        break;
                    }
            }

            ckbisfullpaid_CheckedChanged(sender, e);
        }

        private void txtbankingamount_Leave(object sender, EventArgs e)
        {
            var bankingAmount = string.IsNullOrEmpty(txtbankingamount.Text) ? 0 : Convert.ToDouble(txtbankingamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotal.Text) ? 0 : Convert.ToDouble(txttotal.Text.Replace(".", "").Replace(",", ""));
            txtbankingamount.Text = total - bankingAmount < 0 ? txttotal.Text : bankingAmount.ToString("N0", CultureInfo.CurrentCulture);

            if(txtbankingamount.Text == txttotal.Text)
            {
                ckbisfullpaid.Checked = true;
            }
        }

        private void txtcashamount_Leave(object sender, EventArgs e)
        {
            var cashAmount = string.IsNullOrEmpty(txtcashamount.Text) ? 0 : Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotal.Text) ? 0 : Convert.ToDouble(txttotal.Text.Replace(".", "").Replace(",", ""));
            txtcashamount.Text = total - cashAmount < 0 ? txttotal.Text : cashAmount.ToString("N0", CultureInfo.CurrentCulture);

            if (txtcashamount.Text == txttotal.Text)
            {
                ckbisfullpaid.Checked = true;
            }
        }

        private void txtcashamount_TextChanged(object sender, EventArgs e)
        {
            var bankingAmount = string.IsNullOrEmpty(txtbankingamount.Text) ? 0 : Convert.ToDouble(txtbankingamount.Text.Replace(".", "").Replace(",", ""));
            var cashAmount = string.IsNullOrEmpty(txtcashamount.Text) ? 0 : Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotal.Text) ? 0 : Convert.ToDouble(txttotal.Text.Replace(".", "").Replace(",", ""));

            if (ckbisfullpaid.Checked && txtcashamount.Focused)
            {
                if (txtbankingamount.Enabled && txtcashamount.Enabled)
                {
                    txtbankingamount.Text = (total - cashAmount).ToString("N0", CultureInfo.CurrentCulture);
                }
            }

            if (total - cashAmount - bankingAmount < 0)
            {
                txtbankingamount.Text = total - cashAmount < 0 ? "0" : (total - cashAmount).ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        private void txtbankingamount_TextChanged(object sender, EventArgs e)
        {
            var bankingAmount = string.IsNullOrEmpty(txtbankingamount.Text) ? 0 : Convert.ToDouble(txtbankingamount.Text.Replace(".", "").Replace(",", ""));
            var cashAmount = string.IsNullOrEmpty(txtcashamount.Text) ? 0 : Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotal.Text) ? 0 : Convert.ToDouble(txttotal.Text.Replace(".", "").Replace(",", ""));

            if (ckbisfullpaid.Checked && txtbankingamount.Focused)
            {
                if (txtbankingamount.Enabled && txtcashamount.Enabled)
                {
                    txtcashamount.Text = (total - bankingAmount).ToString("N0", CultureInfo.CurrentCulture);
                }
            }

            if (total - cashAmount - bankingAmount < 0)
            {
                txtcashamount.Text = total - bankingAmount < 0 ? "0" : (total - bankingAmount).ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        private void frmPayDebt_Load(object sender, EventArgs e)
        {
            cmbpaymentmethod.Items.Clear();
            cmbpaymentmethod.Items.Add("CASH");
            cmbpaymentmethod.Items.Add("BANKING");
            cmbpaymentmethod.Items.Add("BOTH");

            cmbpaymentmethod.SelectedIndex = 0;

            var data = clsController.getDebtInfoById(selectedDebtID);

            if (data == null)
            {
                MessageBox.Show("No payment data", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                this.Close();
            }
            else
            {
                currentStatus = originalStatus = data.status;
                receiptNumber = data.receiptnumber;

                switch (data.type)
                {
                    case 0:
                        {
                            var listUser = clsController.getUserByNameAndType();

                            cmbpayee.Items.Clear();
                            cmbpayee.Items.Add("");
                            foreach (var item in listUser)
                            {
                                cmbpayee.Items.Add(new ComboBoxItem()
                                {
                                    Name = clsUtility.getUserTypeString(item.type) + item.name + " - " + item.phone + " - " + item.address,
                                    Value = item.id.ToString()
                                });
                            }

                            cmbpayee.DisplayMember = "Name";
                            cmbpayee.ValueMember = "Value";

                            cmbpayee.SelectedIndex = 0;

                            lbltype.Text = "LEND";
                            lbltype.ForeColor = Color.LimeGreen;
                            break;
                        }
                    case 1:
                        {
                            var listUser = clsController.getUserByNameAndType(type: 0, typeExcept: 1);

                            cmbpayee.Items.Clear();

                            var item = listUser.First();

                            cmbpayee.Items.Add(new ComboBoxItem()
                            {
                                Name = clsUtility.getUserTypeString(item.type) + item.name + " - " + item.phone + " - " + item.address,
                                Value = item.id.ToString()
                            });

                            cmbpayee.DisplayMember = "Name";
                            cmbpayee.ValueMember = "Value";

                            cmbpayee.SelectedIndex = 0;

                            cmbpayee.Enabled = false;

                            lbltype.Text = "LOAN";
                            lbltype.ForeColor = Color.Red;
                            break;
                        }
                    default:
                        {
                            lbltype.Text = "0";
                            break;
                        }
                }

                setStatusText();

                txtbankingamount.Text = "0";
                txtcashamount.Text = "0";

                txtcashamount.Enabled = true;
                txtbankingamount.Enabled = false;

                txttotal.Text = (data.totalamount - data.paidamount).ToString("N0", CultureInfo.CurrentCulture);
            }
        }
    }
}
