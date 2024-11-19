using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmAdjustment : Form
    {
        private List<mdlProducts> listSalesProduct;

        public frmAdjustment()
        {
            InitializeComponent();

            this.MdiParent = mdlMain.frmMDIMain;

            listSalesProduct = clsController.getAllProductsForSales();

            initGrd();

            initGrdSales();
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

        private void btnadjustment_Click(object sender, EventArgs e)
        {

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
                double unitprice = Convert.ToDouble(grdsales[4, e.RowIndex].Value);
                double discount = Convert.ToDouble(grdsales[5, e.RowIndex].Value);

                frmEditOrderDetails frm = new frmEditOrderDetails(name, quantity, unitprice, discount);
                frm.ShowDialog(this);

                if(frm.DialogResult == DialogResult.OK)
                {
                    grdsales[3, e.RowIndex].Value = frm.quantity;
                    grdsales[4, e.RowIndex].Value = frm.unitprice;
                    grdsales[5, e.RowIndex].Value = frm.discount;
                }
            }
        }
    }
}
