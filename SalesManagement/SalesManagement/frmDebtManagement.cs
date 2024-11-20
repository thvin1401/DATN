namespace SalesManagement
{
    public partial class frmDebtManagement : Form
    {
        public frmDebtManagement()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            dpkprocessedtimefrom.Value = DateTime.Now.AddMonths(-1);

            initGrdHeader();

            initGrdData();
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
            grdheader.ColumnCount = 12;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Actor";
            grdheader[2, 0].Value = "Receipt number";
            grdheader[3, 0].Value = "Amount";
            grdheader[4, 0].Value = "Interest";
            grdheader[5, 0].Value = "Circle";
            grdheader[6, 0].Value = "Type";
            grdheader[7, 0].Value = "Processed Time";
            grdheader[8, 0].Value = "Pay amount";
            grdheader[9, 0].Value = "Paid Time";
            grdheader[10, 0].Value = "Status";
            grdheader[11, 0].Value = "";

            
            grdheader.Columns[0].Width = 47;
            grdheader.Columns[1].Width = 300;
            grdheader.Columns[2].Width = 100;
            grdheader.Columns[3].Width = 150;
            grdheader.Columns[4].Width = 50;
            grdheader.Columns[5].Width = 50;
            grdheader.Columns[6].Width = 50;
            grdheader.Columns[7].Width = 100;
            grdheader.Columns[8].Width = 150;
            grdheader.Columns[9].Width = 100;
            grdheader.Columns[10].Width = 50;
            grdheader.Columns[11].Width = 50;

            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader.ClearSelection();
        }

        private void initGrdData()
        {
            grddata.Rows.Clear();
            grddata.Columns.Clear();

            int receiptNumber = string.IsNullOrEmpty(txtreceiptnumber.Text.Trim())? 0 : Convert.ToInt32(txtreceiptnumber.Text.Trim());

            var data = clsController.getAllDebtInfo(dpkprocessedtimefrom.Value, dpkprocessedtimeto.Value, cmbstatus.SelectedIndex, receiptNumber);

            if(data.Count > 0)
            {
                grddata.RowCount = data.Count;
                grddata.ColumnCount = 12;

                for(int i = 0; i < data.Count; i++)
                {
                    grddata[0, i].Value = data[i].id;
                    grddata[1, i].Value = i + 1;
                    grddata[2, i].Value = data[i].name;
                    grddata[3, i].Value = data[i].receiptnumber;
                    grddata[4, i].Value = data[i].amount;
                    grddata[5, i].Value = data[i].interest;
                    grddata[6, i].Value = data[i].circle;
                    grddata[7, i].Value = data[i].type == 0 ? "Lend" : "Borrow";

                    if(data[i].type == 0)
                    {
                        grddata[7, i].Style.ForeColor = Color.LimeGreen;
                    }
                    else
                    {
                        grddata[7, i].Style.ForeColor = Color.Red;
                    }

                    grddata[8, i].Value = data[i].processeddatetime.ToString("dd/MM/yyyy");
                    grddata[9, i].Value = data[i].payamount;
                    grddata[10, i].Value = data[i].paiddatetime.ToString("dd/MM/yyyy");

                    switch (data[i].status)
                    {
                        case 0:
                            {
                                grddata[11, i].Value = "Unpaid";
                                grddata[11, i].Style.ForeColor = Color.DarkGreen;
                                break;
                            }
                        case 1:
                            {
                                grddata[11, i].Value = "Partly pay";
                                grddata[11, i].Style.ForeColor = Color.Green;
                                break;
                            }
                        case 2:
                            {
                                grddata[11, i].Value = "Full paid";
                                grddata[11, i].Style.ForeColor = Color.LimeGreen;
                                break;
                            }
                        case 3:
                            {
                                grddata[11, i].Value = "Deleted";
                                grddata[11, i].Style.ForeColor = Color.Red;
                                break;
                            }
                        default:
                            {
                                grddata[11, i].Value = "";
                                break;
                            }
                    }
                }
                grdheader.Columns[0].Visible = false;

                grdheader.Columns[1].Width = 47;
                grdheader.Columns[2].Width = 300;
                grdheader.Columns[3].Width = 100;
                grdheader.Columns[4].Width = 150;
                grdheader.Columns[5].Width = 50;
                grdheader.Columns[6].Width = 50;
                grdheader.Columns[7].Width = 50;
                grdheader.Columns[8].Width = 100;
                grdheader.Columns[9].Width = 150;
                grdheader.Columns[10].Width = 100;
                grdheader.Columns[11].Width = 50;

                DataGridViewButtonColumn btndelete = new DataGridViewButtonColumn
                {
                    Name = "btndelete",
                    Text = "X",
                    Width = 50,
                    UseColumnTextForButtonValue = true
                };

                grddata.CellMouseEnter += (s, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        if (grddata.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                        {
                            grddata.Cursor = Cursors.Hand;
                        }
                    }
                };

                grddata.CellMouseLeave += (s, e) =>
                {
                    if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    {
                        if (grddata.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                        {
                            grddata.Cursor = Cursors.Default;
                        }
                    }
                };

                grddata.Columns.Add(btndelete);

                grddata.ClearSelection();
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

        private void grddata_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                // Get the name of the clicked column
                string columnName = grddata.Columns[e.ColumnIndex].Name;
                string id = grddata[0, e.RowIndex].Value.ToString();

                if (columnName == "btndelete")
                {
                    if (true)
                    {
                        mdlMain.updateMDIMainMessage("Note deleted!", Color.LimeGreen);
                        
                        return;
                    }
                    mdlMain.updateMDIMainMessage("Processed failed!", Color.Red);
                }
            }
        }

        private void grddata_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                return;
            }
        }
    }
}
