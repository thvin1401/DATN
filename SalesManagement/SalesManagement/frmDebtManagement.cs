using System.Globalization;

namespace SalesManagement
{
    public partial class frmDebtManagement : Form
    {
        private Guid selectedUserID = Guid.Empty;

        private List<string> listSelectedDebtID;

        private int debtType = 0;

        public frmDebtManagement()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            dpkprocessedtimefrom.Value = DateTime.Now.AddMonths(-1);

            listSelectedDebtID = new List<string>();

            lbltype.Visible = false;

            btnpay.Enabled = false;
            btndelete.Enabled = false;

            initGrdHeader();

            initGrdOverviewData();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void initGrdHeader()
        {
            grdheader.Rows.Clear();

            grdheader.RowCount = 1;
            grdheader.ColumnCount = 10;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Total Amount";
            grdheader[2, 0].Value = "Paid Amount";
            grdheader[3, 0].Value = "I";
            grdheader[4, 0].Value = "C";
            grdheader[5, 0].Value = "Created Time";
            grdheader[6, 0].Value = "Paid Before";
            grdheader[7, 0].Value = "Paid Time";
            grdheader[8, 0].Value = "Status";
            grdheader[9, 0].Value = "";


            grdheader.Columns[0].Width = 33;
            grdheader.Columns[1].Width = 115;
            grdheader.Columns[2].Width = 115;
            grdheader.Columns[3].Width = 30;
            grdheader.Columns[4].Width = 30;
            grdheader.Columns[5].Width = 80;
            grdheader.Columns[6].Width = 80;
            grdheader.Columns[7].Width = 80;
            grdheader.Columns[8].Width = 50;
            grdheader.Columns[9].Width = 50;

            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader.ClearSelection();


            grdheader1.Rows.Clear();
            grdheader1.RowCount = 1;
            grdheader1.ColumnCount = 5;

            grdheader1[0, 0].Value = "#";
            grdheader1[1, 0].Value = "Actor";
            grdheader1[2, 0].Value = "Type";
            grdheader1[3, 0].Value = "Paid Amount";
            grdheader1[4, 0].Value = "Paid Amount";

            grdheader1.Columns[0].Width = 35;
            grdheader1.Columns[1].Width = 200;
            grdheader1.Columns[2].Width = 40;
            grdheader1.Columns[3].Width = 125;
            grdheader1.Columns[4].Width = 125;

            grdheader1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader1.ClearSelection();
        }

        private void initGrdOverviewData()
        {
            grdoverviewdata.Rows.Clear();
            grdoverviewdata.Columns.Clear();

            var data = clsController.getListDebtOverview();

            if (data.Count > 0)
            {
                grdoverviewdata.RowCount = data.Count;
                grdoverviewdata.ColumnCount = 6;

                for (int i = 0; i < data.Count; i++)
                {
                    grdoverviewdata[0, i].Value = data[i].id;
                    grdoverviewdata[1, i].Value = i + 1;
                    grdoverviewdata[2, i].Value = data[i].name;

                    switch (data[i].type)
                    {
                        case 0:
                            {
                                grdoverviewdata[3, i].Value = "LEND";
                                grdoverviewdata[3, i].Style.ForeColor = Color.LimeGreen;
                                break;
                            }
                        case 1:
                            {
                                grdoverviewdata[3, i].Value = "LOAN";
                                grdoverviewdata[3, i].Style.ForeColor = Color.Red;
                                break;
                            }
                        default:
                            {
                                grdoverviewdata[3, i].Value = "";
                                break;
                            }
                    }

                    grdoverviewdata[4, i].Value = data[i].totalamount.ToString("N0", CultureInfo.CurrentCulture);
                    grdoverviewdata[5, i].Value = data[i].paidamount.ToString("N0", CultureInfo.CurrentCulture);
                }

                grdoverviewdata.Columns[0].Visible = false;

                grdoverviewdata.Columns[1].Width = 35;
                grdoverviewdata.Columns[2].Width = 200;
                grdoverviewdata.Columns[3].Width = 40;
                grdoverviewdata.Columns[4].Width = 125;
                grdoverviewdata.Columns[5].Width = 125;

                grdoverviewdata.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                grdoverviewdata.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grdoverviewdata.ClearSelection();
            }
        }

        private void initGrdData()
        {
            listSelectedDebtID = new List<string>();
            btnpay.Enabled = false;
            btndelete.Enabled = false;

            grddata.Rows.Clear();
            grddata.Columns.Clear();

            int receiptNumber = string.IsNullOrEmpty(txtreceiptnumber.Text.Trim()) ? 0 : Convert.ToInt32(txtreceiptnumber.Text.Trim());

            var data = clsController.getAllDebtInfo(dpkprocessedtimefrom.Value, dpkprocessedtimeto.Value, receiptNumber, debtType, selectedUserID);

            if (data.Count > 0)
            {
                grddata.RowCount = data.Count;
                grddata.ColumnCount = 10;

                for (int i = 0; i < data.Count; i++)
                {
                    grddata[0, i].Value = data[i].id;
                    grddata[1, i].Value = i + 1;
                    grddata[2, i].Value = data[i].payamount.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[3, i].Value = data[i].paidamount.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[4, i].Value = data[i].interest;
                    grddata[5, i].Value = data[i].circle;
                    grddata[6, i].Value = data[i].processeddatetime.ToString("dd/MM/yyyy");
                    grddata[7, i].Value = data[i].paidbeforetime == null ? "" : data[i].paidbeforetime.ToString("dd/MM/yyyy");
                    grddata[8, i].Value = data[i].paiddatetime == null ? "" : data[i].paiddatetime.ToString("dd/MM/yyyy");

                    switch (data[i].status)
                    {
                        case 0:
                            {
                                grddata[9, i].Value = "Unpaid";
                                grddata[9, i].Style.ForeColor = Color.Red;
                                break;
                            }
                        case 1:
                            {
                                grddata[9, i].Value = "Partly";
                                grddata[9, i].Style.ForeColor = Color.Blue;
                                break;
                            }
                        case 2:
                            {
                                grddata[9, i].Value = "Paid";
                                grddata[9, i].Style.ForeColor = Color.LimeGreen;
                                break;
                            }
                        case 3:
                            {
                                grddata[9, i].Value = "Deleted";
                                grddata[9, i].Style.ForeColor = Color.Red;
                                break;
                            }
                        default:
                            {
                                grddata[9, i].Value = "";
                                break;
                            }
                    }
                }

                grddata.Columns[0].Visible = false;

                grddata.Columns[1].Width = 33;
                grddata.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grddata.Columns[2].Width = 115;
                grddata.Columns[3].Width = 115;
                grddata.Columns[4].Width = 30;
                grddata.Columns[5].Width = 30;
                grddata.Columns[6].Width = 80;
                grddata.Columns[7].Width = 80;
                grddata.Columns[8].Width = 80;

                grddata.Columns[9].Width = 50;
                grddata.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
                {
                    Name = "ckbcolumn",
                    Width = 50
                };

                grddata.Columns.Add(checkBoxColumn);

                grddata.ClearSelection();
            }
        }

        private void grddata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == grddata.Columns["ckbcolumn"].Index && e.RowIndex >= 0)
            {
                // Toggle checkbox value
                bool isChecked = Convert.ToBoolean(grddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);

                grddata.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = !isChecked;

                if (!isChecked)
                {
                    listSelectedDebtID.Add(grddata[0, e.RowIndex].Value.ToString());
                }
                else
                {
                    listSelectedDebtID.Remove(grddata[0, e.RowIndex].Value.ToString());
                }

                if (listSelectedDebtID.Count == 1)
                {
                    btnpay.Enabled = true;
                    btndelete.Enabled = true;
                }
                else
                {
                    btnpay.Enabled = false;
                    btndelete.Enabled = false;
                }
            }
        }

        private void grddata_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
            (grddata.Columns[e.ColumnIndex].Name == "btndelete") && e.RowIndex >= 0)
            {
                // Suppress the default cell painting
                e.Handled = true;

                // Paint the background
                e.PaintBackground(e.ClipBounds, true);

                // Draw the button without borders
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString(), // Get the button text
                    e.CellStyle.Font,
                    e.CellBounds,
                    Color.Red,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void grddata_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                return;
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmCreateDebt frm = new frmCreateDebt();
            frm.ShowDialog(this);

            initGrdOverviewData();
            initGrdData();
        }

        private void btnpay_Click(object sender, EventArgs e)
        {
            frmPayDebt frm = new frmPayDebt();
            frm.selectedDebtID = listSelectedDebtID[0];
            frm.ShowDialog(this);

            initGrdData();
        }

        private void grdoverviewdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string? id = grdoverviewdata[0, e.RowIndex].Value.ToString();

                if (grdoverviewdata[3, e.RowIndex].Value.ToString() == "LEND")
                {
                    debtType = 0;
                    lbltype.Visible = true;
                    lbltype.Text = "LEND";
                    lbltype.ForeColor = Color.LimeGreen;
                }

                if (grdoverviewdata[3, e.RowIndex].Value.ToString() == "LOAN")
                {
                    debtType = 1;
                    lbltype.Visible = true;
                    lbltype.Text = "LOAN";
                    lbltype.ForeColor = Color.Red;
                }

                if (id != null)
                {
                    selectedUserID = Guid.Parse(id);
                    initGrdData();
                }
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete? this action cannot be undone", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (clsController.deleteDebtInfo(listSelectedDebtID[0]))
                {
                    mdlMain.updateMDIMainMessage("Note deleted!", Color.LimeGreen);
                    initGrdData();
                    return;
                }
                else
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.Red);
                }
            }
        }
    }
}
