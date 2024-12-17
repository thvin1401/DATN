using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmSearchBillJournal : Form
    {
        private int currentReceiptNumber = 0;

        private List<mdlProducts> listProduct;

        private List<mdlUserInfo> listUser;

        public frmSearchBillJournal()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            listProduct = clsController.getAllProducts();

            listUser = clsController.getAllUsersNoCondition();

            cmbtype.Items.Clear();

            cmbtype.Items.Add("Sales");
            cmbtype.Items.Add("Cancel");
            cmbtype.Items.Add("Debt");

            cmbtype.SelectedIndex = 0;

            dpkbillfrom.Value = DateTime.Now.AddDays(-7);
            dpkbillto.Value = DateTime.Now.AddDays(7);

            initGrdHeader();
            initGrdBillData();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void txtnumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearControls();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            initGrdBillData();
        }

        private void clearControls()
        {
            txtcostfrom.Clear();
            txtcostto.Clear();
            txtreceiptnumber.Clear();

            cmbtype.SelectedIndex = 0;

            lbltotalamount.Text = "0";
            lblpaidamount.Text = "0";
            lblunpaidamount.Text = "0";
            lblunpaidamount.ForeColor = SystemColors.ControlText;
            lblstatus.Text = "";

            dpkbillfrom.Value = DateTime.Now.AddDays(-7);
            dpkbillto.Value = DateTime.Now.AddDays(7);

            initGrdBillData();
            grdproducts.Rows.Clear();
            grdpayment.Rows.Clear();
        }

        private void initGrdHeader()
        {
            grdbillheader.Rows.Clear();

            grdbillheader.RowCount = 1;
            grdbillheader.ColumnCount = 8;

            grdbillheader[0, 0].Value = "#";
            grdbillheader[1, 0].Value = "Receipt No";
            grdbillheader[2, 0].Value = "Name";
            grdbillheader[3, 0].Value = "Amount";
            grdbillheader[4, 0].Value = "Discount";
            grdbillheader[5, 0].Value = "Payamount";
            grdbillheader[6, 0].Value = "Type";
            grdbillheader[7, 0].Value = "Time";

            grdbillheader.Columns[0].Width = 44;
            grdbillheader.Columns[1].Width = 70;
            grdbillheader.Columns[2].Width = 150;
            grdbillheader.Columns[3].Width = 100;
            grdbillheader.Columns[4].Width = 100;
            grdbillheader.Columns[5].Width = 100;
            grdbillheader.Columns[6].Width = 50;
            grdbillheader.Columns[7].Width = 80;

            grdbillheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void initGrdBillData()
        {
            int? costFrom = string.IsNullOrEmpty(txtcostfrom.Text) ? null : Convert.ToInt32(txtcostfrom.Text.Replace(",", ""));
            int? costTo = string.IsNullOrEmpty(txtcostto.Text) ? null : Convert.ToInt32(txtcostto.Text.Replace(",", ""));
            int? receiptNumber = string.IsNullOrEmpty(txtreceiptnumber.Text) ? null : Convert.ToInt32(txtreceiptnumber.Text);

            var listData = clsController.getAllBills(dpkbillfrom.Value, dpkbillto.Value, costFrom, costTo, receiptNumber, cmbtype.SelectedIndex);

            grdbilldata.Rows.Clear();

            if (listData != null && listData.Count > 0)
            {
                grdbilldata.ColumnCount = 9;
                grdbilldata.RowCount = listData.Count;

                grdbilldata.Columns[0].Width = 44;
                grdbilldata.Columns[1].Width = 70;
                grdbilldata.Columns[2].Width = 150;
                grdbilldata.Columns[3].Width = 100;
                grdbilldata.Columns[4].Width = 100;
                grdbilldata.Columns[5].Width = 100;
                grdbilldata.Columns[6].Width = 50;
                grdbilldata.Columns[7].Width = 80;
                grdbilldata.Columns[8].Visible = false;

                grdbilldata.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdbilldata.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grdbilldata.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grdbilldata.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdbilldata.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdbilldata.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdbilldata.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdbilldata.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                for (int i = 0; i < listData.Count; i++)
                {
                    grdbilldata[0, i].Value = i + 1;
                    grdbilldata[1, i].Value = listData[i].receiptnumber;
                    grdbilldata[2, i].Value = listUser.First(x => x.id == listData[i].userinfoid).name;
                    grdbilldata[3, i].Value = listData[i].amount.ToString("N0", CultureInfo.CurrentCulture);
                    grdbilldata[4, i].Value = listData[i].discount.ToString("N0", CultureInfo.CurrentCulture);
                    grdbilldata[5, i].Value = listData[i].payamount.ToString("N0", CultureInfo.CurrentCulture);

                    switch (listData[i].billtype)
                    {
                        case 0:
                            {
                                grdbilldata[6, i].Value = "SALES";
                                grdbilldata[6, i].Style.ForeColor = Color.LimeGreen;
                                break;
                            }
                        case 1:
                            {
                                grdbilldata[6, i].Value = "RTN";
                                grdbilldata[6, i].Style.ForeColor = Color.Blue;
                                break;
                            }
                        case 2:
                            {
                                grdbilldata[6, i].Value = "DEBT";
                                grdbilldata[6, i].Style.ForeColor = Color.Red;
                                break;
                            }
                        default:
                            {
                                grdbilldata[6, i].Value = "";
                                break;
                            }
                    }

                    grdbilldata[7, i].Value = listData[i].updatedatetime.ToString("dd/MM/yyyy");
                    grdbilldata[8, i].Value = listData[i].ispaid;
                }
            }
        }

        private void initGrdProducts()
        {
            var listData = clsController.getListProductManagementByReceiptNumber(currentReceiptNumber);

            grdproducts.Rows.Clear();

            if (listData != null && listData.Count > 0)
            {
                grdproducts.ColumnCount = 4;
                grdproducts.RowCount = listData.Count;

                grdproducts.Columns[0].Width = 240;
                grdproducts.Columns[1].Width = 52;
                grdproducts.Columns[2].Width = 100;
                grdproducts.Columns[3].Width = 100;

                grdproducts.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grdproducts.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdproducts.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdproducts.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                for (int i = 0; i < listData.Count; i++)
                {
                    grdproducts[0, i].Value = listProduct.First(x => x.id == listData[i].productid).name;
                    grdproducts[1, i].Value = listData[i].quantity;
                    grdproducts[2, i].Value = listData[i].unitprice.ToString("N0", CultureInfo.CurrentCulture);
                    grdproducts[3, i].Value = listData[i].discount.ToString("N0", CultureInfo.CurrentCulture);
                }

                lbltotalamount.Text = listData.Sum(x => x.unitprice * x.quantity - x.discount).ToString("N0", CultureInfo.CurrentCulture);
            }
            else
            {
                lbltotalamount.Text = "0";
            }
        }

        private void initGrdPayment()
        {
            var listData = clsController.getListPaymentByReceiptNumber(currentReceiptNumber);

            grdpayment.Rows.Clear();

            if (listData != null && listData.Count > 0)
            {
                grdpayment.ColumnCount = 4;
                grdpayment.RowCount = listData.Count;

                grdpayment.Columns[0].Width = 240;
                grdpayment.Columns[1].Width = 120;
                grdpayment.Columns[2].Width = 52;
                grdpayment.Columns[3].Width = 80;

                grdpayment.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                grdpayment.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                grdpayment.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdpayment.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                for (int i = 0; i < listData.Count; i++)
                {
                    grdpayment[0, i].Value = listUser.First(x => x.id == listData[i].userinfoid).name;
                    grdpayment[1, i].Value = listData[i].amount.ToString("N0", CultureInfo.CurrentCulture);
                    grdpayment[2, i].Value = listData[i].paymentmethod == 0 ? "CASH" : "BANK";
                    grdpayment[3, i].Value = listData[i].paydatetime.ToString("dd/MM/yyyy");
                }

                lblpaidamount.Text = listData.Sum(x => x.amount).ToString("N0", CultureInfo.CurrentCulture);
                lblunpaidamount.Text = (Convert.ToInt32(lbltotalamount.Text?.Replace(",", "")) - Convert.ToInt32(lblpaidamount.Text.Replace(",", ""))).ToString("N0", CultureInfo.CurrentCulture);
                lblunpaidamount.ForeColor = lblunpaidamount.Text == "0" ? SystemColors.ControlText : Color.Red;
            }
            else
            {
                lblpaidamount.Text = "0";
                lblunpaidamount.Text = "0";
                lblunpaidamount.ForeColor = SystemColors.ControlText;
            }
        }

        private void cmbtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            initGrdBillData();
        }

        private void dpkbillfrom_ValueChanged(object sender, EventArgs e)
        {
            initGrdBillData();
        }

        private void dpkbillto_ValueChanged(object sender, EventArgs e)
        {
            initGrdBillData();
        }

        private void grdbilldata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                currentReceiptNumber = Convert.ToInt32(grdbilldata.Rows[e.RowIndex].Cells[1].Value);

                bool isPaid = Convert.ToBoolean(grdbilldata.Rows[e.RowIndex].Cells[8].Value);

                if (isPaid)
                {
                    lblstatus.Text = "PAID";
                    lblstatus.ForeColor = Color.LimeGreen;
                }
                else
                {
                    lblstatus.Text = "UNPAID";
                    lblstatus.ForeColor = Color.Red;
                }

                initGrdProducts();

                initGrdPayment();
            }
        }

        private void txtcostfrom_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcostfrom.Text) && !txtcostfrom.Text.Contains(","))
            {
                txtcostfrom.Text = Convert.ToInt32(txtcostfrom.Text).ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        private void txtcostto_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtcostto.Text) && !txtcostto.Text.Contains(","))
            {
                txtcostto.Text = Convert.ToInt32(txtcostto.Text).ToString("N0", CultureInfo.CurrentCulture);
            }
        }
    }
}
