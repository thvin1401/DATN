using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmAdjustment : Form
    {
        private List<mdlProducts> listSalesProduct;

        private List<mdlUserInfo> listUserInfo;

        private List<mdlProductManagement> listOrders;

        private mdlUserInfo? selectedUser;

        private bool isDebt = false;

        public frmAdjustment()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            listSalesProduct = clsController.getAllProductsForSales();

            listUserInfo = new List<mdlUserInfo>();

            listOrders = new List<mdlProductManagement>();

            selectedUser = null;

            initCmbUserinfo();

            initGrd();

            initGrdSales();

            cmbpaymentmethod.Items.Clear();
            cmbpaymentmethod.Items.Add("CASH");
            cmbpaymentmethod.Items.Add("BANKING");
            cmbpaymentmethod.Items.Add("ALL");
        }

        private void initCmbUserinfo()
        {
            listUserInfo = clsController.getUserByNameAndType();

            cmbuserinfoname.Items.Clear();
            cmbuserinfoname.Items.Add("");
            foreach (var item in listUserInfo)
            {
                ComboBoxItem cmbItem = new ComboBoxItem();
                cmbItem.Name = item.name + " - " + item.phone + " - " + item.address;
                cmbItem.Value = item.id.ToString();
                cmbuserinfoname.Items.Add(cmbItem);
            }

            cmbuserinfoname.DisplayMember = "Name";
            cmbuserinfoname.ValueMember = "Value";

            cmbuserinfoname.SelectedIndex = 0;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void initGrd()
        {
            // grd header
            grdheader.Rows.Clear();

            grdheader.RowCount = 1;
            grdheader.ColumnCount = 6;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Name";
            grdheader[2, 0].Value = "Qty";
            grdheader[3, 0].Value = "Unit price";
            grdheader[4, 0].Value = "Discount";
            grdheader[5, 0].Value = "";

            grdheader.Columns[0].Width = 59;
            grdheader.Columns[1].Width = 250;
            grdheader.Columns[2].Width = 50;
            grdheader.Columns[3].Width = 150;
            grdheader.Columns[4].Width = 150;
            grdheader.Columns[5].Width = 50;

            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader.ClearSelection();

            // grd product
            grdproduct.Rows.Clear();

            if (listSalesProduct.Count > 0)
            {
                grdproduct.RowCount = listSalesProduct.Count;
                grdproduct.ColumnCount = 3;

                for (int i = 0; i < listSalesProduct.Count; i++)
                {
                    grdproduct[0, i].Value = listSalesProduct[i].id;
                    grdproduct[1, i].Value = i + 1;
                    grdproduct[2, i].Value = listSalesProduct[i].name;
                }

                grdproduct.Columns[1].Width = 45;
                grdproduct.Columns[2].Width = 450;

                grdproduct.Columns[0].Visible = false;
                grdproduct.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdproduct.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

                grdproduct.ClearSelection();
            }

            grdproduct.Height = 210;
        }

        private void initGrdSales()
        {
            grdsales.Rows.Clear();

            grdsales.ColumnCount = 7;

            grdsales.Columns[0].Visible = false;

            grdsales.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            grdsales.Columns[1].Width = 59;
            grdsales.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdsales.Columns[2].Width = 250;

            grdsales.Columns[3].Width = 50;
            grdsales.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdsales.Columns[4].Width = 150;
            grdsales.Columns[5].Width = 150;
            grdsales.Columns[6].Width = 50;
        }

        private void grdproduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string id = grdproduct[0, e.RowIndex].Value.ToString();

                var selectedProduct = listSalesProduct.FirstOrDefault(x => x.id.ToString() == id);

                if (selectedProduct != null)
                {
                    // Create a new row
                    DataGridViewRow row = new DataGridViewRow();

                    DataGridViewButtonCell buttonDelete = new DataGridViewButtonCell();
                    buttonDelete.Value = "X";

                    // Add cells to the row
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedProduct.id });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = grdsales.RowCount + 1 });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedProduct.name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 1 });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = selectedProduct.unitprice.ToString("N0", CultureInfo.CurrentCulture) });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = 0 });
                    row.Cells.Add(buttonDelete);

                    for (int i = 0; i < grdsales.RowCount; i++)
                    {
                        if (grdsales.Rows[i].Cells[0].Value.ToString() == row.Cells[0].Value.ToString())
                        {
                            grdsales[3, i].Value = Convert.ToInt32(grdsales[3, i].Value) + 1;
                            break;
                        }
                        if (i == (grdsales.RowCount - 1))
                        {
                            grdsales.Rows.Add(row);
                            break;
                        }
                    }

                    if (grdsales.RowCount == 0)
                    {
                        grdsales.Rows.Add(row);
                    }
                }
            }
        }

        private void clearControls()
        {
            cmbuserinfoname.SelectedIndex = 0;
            cmbpaymentmethod.SelectedIndex = 0;
            initGrdSales();
            txtreceiptnumber.Clear();
        }

        private void btnadjustment_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("No user selected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (grdsales.RowCount == 0)
            {
                MessageBox.Show("No item selected", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            getListSalesInfo();

            var receiptNumber = createBillInfo();

            try
            {
                if (receiptNumber != 0)
                {
                    updateProductSales(receiptNumber);

                    if (isDebt)
                    {

                    }
                    else
                    {
                        createPaymentInfo(receiptNumber, Guid.NewGuid());
                    }

                    updateUserPointAndRank();
                }

                clearControls();

                mdlMain.updateMDIMainMessage("Adjustment successfully!", Color.LimeGreen);
            }
            catch (Exception ex)
            {
                mdlMain.updateMDIMainMessage("Adjustment failed!", Color.Red);
                mdlMain.log(ex.Message, ex);
                return;
            }
        }

        private int createBillInfo()
        {
            DateTime creationTime = DateTime.Now;

            mdlBill billInfo = new mdlBill();
            billInfo.receiptnumber = clsController.getNewReceiptNumber();
            billInfo.billtype = 0;
            billInfo.amount = listOrders.Sum(x => x.unitprice);
            billInfo.discount = listOrders.Sum(x => x.discount);
            billInfo.payamount = listOrders.Sum(x => x.unitprice) - listOrders.Sum(x => x.discount);
            billInfo.isdeleted = false;
            billInfo.createdatetime = creationTime;
            billInfo.updatedatetime = creationTime;

            if (clsController.insertBill(billInfo))
            {
                return billInfo.receiptnumber;
            }
            return 0;
        }

        private void updateProductSales(int receiptNumber)
        {
            List<mdlProductManagement> productSales = new List<mdlProductManagement>();

            var creationTime = DateTime.Now;

            foreach (var item in listOrders)
            {
                item.receiptnumber = receiptNumber;
                item.createdatetime = creationTime;
                item.updatedatetime = creationTime;
            }

            clsController.insertData(listOrders);
        }

        private void createPaymentInfo(int receiptNumber, Guid debtId)
        {
            mdlPayment paymentInfo;

            var creationTime = DateTime.Now;

            if (cmbpaymentmethod.SelectedIndex != 2)
            {
                paymentInfo = new mdlPayment()
                {
                    id = Guid.NewGuid(),
                    receiptnumber = receiptNumber,
                    amount = Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", "")),
                    debtid = debtId,
                    paymentmethod = cmbpaymentmethod.SelectedIndex,
                    paymenttype = 0,
                    paydatetime = creationTime,
                    createdatetime = creationTime,
                    updatedatetime = creationTime
                };

                clsController.insertPaymentData(paymentInfo);
            }
            else
            {
                for (int i = 0; i < 2; i++)
                {
                    var amount = i == 0 ? Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", "")) :
                        Convert.ToDouble(txtbankingpayamount.Text.Replace(".", "").Replace(",", ""));
                    paymentInfo = new mdlPayment()
                    {
                        id = Guid.NewGuid(),
                        receiptnumber = receiptNumber,
                        amount = amount,
                        debtid = debtId,
                        paymentmethod = i,
                        paymenttype = 0,
                        paydatetime = creationTime,
                        createdatetime = creationTime,
                        updatedatetime = creationTime
                    };

                    clsController.insertPaymentData(paymentInfo);
                }
            }
        }

        private void updateUserPointAndRank()
        {
            if (selectedUser != null)
            {
                int awardedPoint = (int)((listOrders.Sum(x => x.unitprice) - listOrders.Sum(x => x.discount))/clsConfig.amountPerPoint);
                selectedUser.point += awardedPoint;
                selectedUser.rankid = mdlMain.App.ranks.OrderByDescending(x => x.achivepoint).First(x => x.achivepoint <= selectedUser.point).id;
                selectedUser.updatedatetime = DateTime.Now;

                clsController.updateUserPointAndRank(selectedUser);
            }
        }

        private void getListSalesInfo()
        {
            mdlProductManagement item;
            if (grdsales.RowCount > 0)
            {
                foreach (DataGridViewRow row in grdsales.Rows)
                {
                    item = new mdlProductManagement()
                    {
                        id = Guid.NewGuid(),
                        productid = Guid.Parse(row.Cells[0].Value.ToString()),
                        quantity = Convert.ToInt32(row.Cells[3].Value),
                        unitprice = Convert.ToDouble(row.Cells[4].Value),
                        discount = Convert.ToDouble(row.Cells[5].Value)
                    };

                    listOrders.Add(item);
                }
            }
        }

        private void grdsales_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            updatePriceData();
        }

        private void grdsales_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            updatePriceData();
        }

        private void updatePriceData()
        {
            double totalPrice = 0;
            double totalDiscount = 0;

            foreach (DataGridViewRow item in grdsales.Rows)
            {
                totalPrice += Convert.ToDouble(item.Cells[3].Value) * Convert.ToDouble(item.Cells[4].Value?.ToString()?.Replace(".", "").Replace(",", ""));
                totalDiscount += Convert.ToDouble(item.Cells[5].Value);
            }

            txttotalprice.Text = (totalPrice - totalDiscount).ToString("N0", CultureInfo.CurrentCulture);

            if (txtcashamount.Enabled || (txtcashamount.Enabled && txtbankingpayamount.Enabled))
            {
                txtcashamount.Text = txttotalprice.Text;
                txtbankingpayamount.Text = "0";

                var totalprice = Convert.ToDouble(txttotalprice.Text.Replace(".", "").Replace(",", ""));
                var cashamount = Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));

                txtchange.Text = cashamount == 0 ? "0" : (cashamount - totalprice).ToString("N0", CultureInfo.CurrentCulture);
            }
            else
            {
                txtbankingpayamount.Text = txttotalprice.Text;

                var totalprice = Convert.ToDouble(txttotalprice.Text.Replace(".", "").Replace(",", ""));
                var bankingamount = Convert.ToDouble(txtbankingpayamount.Text.Replace(".", "").Replace(",", ""));

                txtchange.Text = bankingamount == 0 ? "0" : (bankingamount - totalprice).ToString("N0", CultureInfo.CurrentCulture);
            }
        }

        private void grdsales_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // Check if the cell is a button cell (in this case, in the desired column)
            if (e.RowIndex >= 0 && grdsales[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                // Prevent the default painting behavior
                e.Handled = true;

                // Draw the button manually
                var buttonRect = e.CellBounds;

                // Draw the background color of the button
                using (Brush backBrush = new SolidBrush(SystemColors.Control))
                {
                    e.Graphics.FillRectangle(backBrush, buttonRect);
                }

                // Draw the button text (centered)
                using (Brush textBrush = new SolidBrush(Color.Red))
                {
                    var textSize = e.Graphics.MeasureString("X", e.CellStyle.Font);
                    var textX = buttonRect.Left + (buttonRect.Width - textSize.Width) / 2;
                    var textY = buttonRect.Top + (buttonRect.Height - textSize.Height) / 2;
                    e.Graphics.DrawString("X", e.CellStyle.Font, textBrush, new PointF(textX, textY));
                }

                // Optionally, draw a border (if desired)
                using (Pen borderPen = new Pen(Color.Transparent))
                {
                    e.Graphics.DrawRectangle(borderPen, buttonRect);
                }
            }
        }

        private void grdsales_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdsales[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                // Set the cursor to Hand
                grdsales.Cursor = Cursors.Hand;
            }
        }

        private void grdsales_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            grdsales.Cursor = Cursors.Default;
        }

        private void grdsales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdsales[e.ColumnIndex, e.RowIndex] is DataGridViewButtonCell)
            {
                grdsales.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void grdsales_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            updatePriceData();
        }

        private void grdsales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? name = grdsales[2, e.RowIndex].Value.ToString()?.Trim();
                int quantity = Convert.ToInt32(grdsales[3, e.RowIndex].Value);
                int maxQuantity = listSalesProduct.First(x => x.id.ToString() == grdsales[0, e.RowIndex].Value.ToString()).quantity;
                double unitprice = Convert.ToDouble(grdsales[4, e.RowIndex].Value);
                double discount = Convert.ToDouble(grdsales[5, e.RowIndex].Value);

                frmEditOrderDetails frm = new frmEditOrderDetails(name, quantity, maxQuantity, unitprice, discount);
                frm.ShowDialog(this);

                if (frm.DialogResult == DialogResult.OK)
                {
                    grdsales[3, e.RowIndex].Value = frm.quantity;
                    grdsales[4, e.RowIndex].Value = frm.unitprice;
                    grdsales[5, e.RowIndex].Value = frm.discount;
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
                        txtbankingpayamount.Enabled = false;
                        txtbankingpayamount.Clear();
                        break;
                    }
                case 1:
                    {
                        txtcashamount.Enabled = false;
                        txtcashamount.Clear();

                        txtbankingpayamount.Enabled = true;
                        break;
                    }
                case 2:
                    {
                        txtcashamount.Enabled = true;
                        txtbankingpayamount.Enabled = true;
                        break;
                    }
                default:
                    {
                        txtcashamount.Enabled = false;
                        txtcashamount.Clear();
                        txtbankingpayamount.Enabled = false;
                        txtbankingpayamount.Clear();
                        break;
                    }
            }

            updatePriceData();
        }

        private void frmAdjustment_Load(object sender, EventArgs e)
        {
            cmbpaymentmethod.SelectedIndex = 0;
            dpkbirthday.Enabled = false;
        }

        private void txtcashamount_TextChanged(object sender, EventArgs e)
        {
            var bankingAmount = string.IsNullOrEmpty(txtbankingpayamount.Text) ? 0 : Convert.ToDouble(txtbankingpayamount.Text.Replace(".", "").Replace(",", ""));
            var cashAmount = string.IsNullOrEmpty(txtcashamount.Text) ? 0 : Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotalprice.Text) ? 0 : Convert.ToDouble(txttotalprice.Text.Replace(".", "").Replace(",", ""));

            if ((bankingAmount + cashAmount - total) < 0)
            {
                isDebt = true;
            }
            else
            {
                isDebt = false;
            }
            txtchange.Text = isDebt ? "0" : (bankingAmount + cashAmount - total).ToString();
        }

        private void txtbankingpayamount_TextChanged(object sender, EventArgs e)
        {
            var bankingAmount = string.IsNullOrEmpty(txtbankingpayamount.Text) ? 0 : Convert.ToDouble(txtbankingpayamount.Text.Replace(".", "").Replace(",", ""));
            var cashAmount = string.IsNullOrEmpty(txtcashamount.Text) ? 0 : Convert.ToDouble(txtcashamount.Text.Replace(".", "").Replace(",", ""));
            var total = string.IsNullOrEmpty(txttotalprice.Text) ? 0 : Convert.ToDouble(txttotalprice.Text.Replace(".", "").Replace(",", ""));

            if ((bankingAmount + cashAmount - total) < 0)
            {
                isDebt = true;
            }
            else
            {
                isDebt = false;
            }
            txtchange.Text = isDebt ? "0" : (bankingAmount + cashAmount - total).ToString();
        }

        private void cmbuserinfoname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbuserinfoname.SelectedIndex > 0)
            {
                string id = ((ComboBoxItem)cmbuserinfoname.SelectedItem).Value.ToString();

                var selectedUser = listUserInfo.FirstOrDefault(x => x.id == Guid.Parse(id));

                if (selectedUser != null)
                {
                    var rank = mdlMain.App.ranks.FirstOrDefault(x => x.id == selectedUser.rankid);
                    txtfullname.Text = selectedUser.name;
                    txtaddress.Text = selectedUser.address;
                    txtphone.Text = selectedUser.phone;
                    txtemail.Text = selectedUser.email;
                    txtpoint.Text = selectedUser.point.ToString();
                    dpkbirthday.Value = selectedUser.birthday;
                    txtrank.Text = rank == null ? "" : rank.ToString();
                    switch (selectedUser.type)
                    {
                        case 0:
                            {
                                txttype.Text = "Owner";
                                break;
                            }
                        case 1:
                            {
                                txttype.Text = "Manager";
                                break;
                            }
                        case 2:
                            {
                                txttype.Text = "Customer";
                                break;
                            }
                        case 3:
                            {
                                txttype.Text = "Provider";
                                break;
                            }
                        case 4:
                            {
                                txttype.Text = "Debt owner";
                                break;
                            }
                        default:
                            {
                                txttype.Text = "";
                                break;
                            }
                    }

                    this.selectedUser = selectedUser;
                }
                else
                {
                    this.selectedUser = null;
                }
            }
            else
            {
                txtfullname.Clear();
                txtaddress.Clear();
                txtphone.Clear();
                txtemail.Clear();
                txtpoint.Clear();
                dpkbirthday.Value = DateTime.Now;
                txttype.Clear();
                txtrank.Clear();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearControls();
        }
    }
}
