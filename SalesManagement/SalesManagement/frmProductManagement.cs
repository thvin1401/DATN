using System.Globalization;

namespace SalesManagement
{
    public partial class frmProductManagement : Form
    {
        private bool isViewDeletedItems = false;

        public frmProductManagement()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            mdlMain.App.frmMainMenu.Show();

            this.Hide();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            frmCreateUpdateProduct frm = new frmCreateUpdateProduct();
            frm.ShowDialog(this);

            initGrdHeader();
        }

        private void initGrdHeader()
        {
            grdheader.Rows.Clear();

            grdheader.RowCount = 1;
            grdheader.ColumnCount = 9;

            grdheader.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            grdheader[0, 0].Value = "#";
            grdheader[1, 0].Value = "Name";
            grdheader[2, 0].Value = "Quantity";
            grdheader[3, 0].Value = "Unit Price";
            grdheader[4, 0].Value = "Provider";
            grdheader[5, 0].Value = "Category";
            grdheader[6, 0].Value = "Weight";
            grdheader[7, 0].Value = "Import Time";
            grdheader[8, 0].Value = "";

            grdheader.Columns[0].Width = 51;
            grdheader.Columns[1].Width = 300;
            grdheader.Columns[2].Width = 100;
            grdheader.Columns[3].Width = 200;
            grdheader.Columns[4].Width = 150;
            grdheader.Columns[5].Width = 140;
            grdheader.Columns[6].Width = 100;
            grdheader.Columns[7].Width = 100;
            grdheader.Columns[8].Width = 50;

            grdheader.ClearSelection();
        }

        private void initGrdData()
        {
            var data = clsController.getAllProducts(dpkarriveddatefrom.Value, dpkarriveddateto.Value, txtsearch.Text.Trim(), isViewDeletedItems);

            grddata.Rows.Clear();
            grddata.Columns.Clear();

            if (data.Count > 0)
            {
                grddata.RowCount = data.Count;
                grddata.ColumnCount = 9;

                for (int i = 0; i < data.Count; i++)
                {
                    grddata[0, i].Value = data[i].id;
                    grddata[1, i].Value = i + 1;
                    grddata[2, i].Value = data[i].name;
                    grddata[3, i].Value = data[i].quantity.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[4, i].Value = data[i].unitprice.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[5, i].Value = data[i].provider;
                    grddata[6, i].Value = data[i].category;
                    grddata[7, i].Value = data[i].weight.ToString("N0", CultureInfo.CurrentCulture);
                    grddata[8, i].Value = data[i].importdatetime.ToString("dd/MM/yyyy");
                }

                grddata.Columns[0].Visible = false;

                grddata.Columns[1].Width = 51;
                grddata.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                grddata.Columns[2].Width = 300;
                grddata.Columns[3].Width = 100;
                grddata.Columns[4].Width = 200;
                grddata.Columns[5].Width = 150;
                grddata.Columns[6].Width = 140;
                grddata.Columns[7].Width = 100;
                grddata.Columns[8].Width = 100;

                if (isViewDeletedItems)
                {
                    DataGridViewButtonColumn btnrevert = new DataGridViewButtonColumn
                    {
                        Name = "btnrevert",
                        Text = "O",
                        UseColumnTextForButtonValue = true,
                        Width = 50
                    };

                    grddata.Columns.Add(btnrevert);
                }
                else
                {
                    DataGridViewButtonColumn btndelete = new DataGridViewButtonColumn
                    {
                        Name = "btndelete",
                        Text = "X",
                        UseColumnTextForButtonValue = true,
                        Width = 50
                    };

                    grddata.Columns.Add(btndelete);
                }

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

                grddata.Height = 480;
                grddata.ClearSelection();
            }
        }

        private void frmProductManagement_Load(object sender, EventArgs e)
        {
            dpkarriveddatefrom.Value = DateTime.Now.AddDays(-7);

            initGrdHeader();
        }

        private void grddata_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 &&
            (grddata.Columns[e.ColumnIndex].Name == "btnrevert" || grddata.Columns[e.ColumnIndex].Name == "btndelete") && e.RowIndex >= 0)
            {
                // Suppress the default cell painting
                e.Handled = true;

                // Paint the background
                e.PaintBackground(e.ClipBounds, true);

                Color textColor = (grddata.Columns[e.ColumnIndex].Name == "btnrevert") ? Color.LimeGreen : Color.Red;

                // Draw the button without borders
                TextRenderer.DrawText(
                    e.Graphics,
                    e.FormattedValue?.ToString(), // Get the button text
                    e.CellStyle.Font,
                    e.CellBounds,
                    textColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }

        private void grddata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                frmCreateUpdateProduct frm = new frmCreateUpdateProduct();
                frm.isEdit = true;
                frm.productId = grddata.Rows[e.RowIndex].Cells[0].Value.ToString();
                frm.ShowDialog(this);

                initGrdData();
            }
        }

        private void grddata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row
            if (e.RowIndex >= 0)
            {
                // Get the name of the clicked column
                string columnName = grddata.Columns[e.ColumnIndex].Name;
                string? id = grddata[0, e.RowIndex].Value.ToString();

                if (columnName == "btnrevert")
                {
                    if (clsController.deleteAndRevertProduct(id, false))
                    {
                        mdlMain.updateMDIMainMessage("Revert successfully!", Color.LimeGreen);

                        initGrdData();
                        return;
                    }
                    mdlMain.updateMDIMainMessage("Processed failed!", Color.Red);
                }
                else if (columnName == "btndelete")
                {
                    if (clsController.deleteAndRevertProduct(id, true))
                    {
                        mdlMain.updateMDIMainMessage("Product deleted!", Color.LimeGreen);

                        initGrdData();
                        return;
                    }
                    mdlMain.updateMDIMainMessage("Processed failed!", Color.Red);
                }
            }
        }

        private void btnviewdeleteditems_Click(object sender, EventArgs e)
        {
            isViewDeletedItems = !isViewDeletedItems;

            if (isViewDeletedItems)
                lbldeletedstatus.ForeColor = Color.Red;
            else
                lbldeletedstatus.ForeColor = SystemColors.ControlText;

            initGrdData();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            initGrdData();
        }

        private void dpkarriveddatefrom_ValueChanged(object sender, EventArgs e)
        {
            initGrdData();
        }

        private void dpkarriveddateto_ValueChanged(object sender, EventArgs e)
        {
            initGrdData();
        }
    }
}
