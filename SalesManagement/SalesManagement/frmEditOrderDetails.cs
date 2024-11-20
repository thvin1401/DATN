using System.Globalization;

namespace SalesManagement
{
    public partial class frmEditOrderDetails : Form
    {
        public string name;

        public int quantity;

        public int maxQuantity;

        public double unitprice;

        public double discount;

        public frmEditOrderDetails(string? name, int quantity, int maxQuantity, double unitprice, double discount)
        {
            InitializeComponent();

            this.name = name == null ? string.Empty : name;
            this.quantity = quantity;
            this.maxQuantity = maxQuantity;
            this.unitprice = unitprice;
            this.discount = discount;
        }

        private void frmEditOrderDetails_Load(object sender, EventArgs e)
        {
            setData();
        }

        private void btnok_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
            {
                return;
            }

            quantity = Convert.ToInt32(txtquantity.Text.Replace(".", "").Replace(",", ""));
            unitprice = Convert.ToDouble(txtunitprice.Text.Replace(".", "").Replace(",", ""));
            discount = Convert.ToDouble(txtdiscount.Text.Replace(".", "").Replace(",", ""));

            this.DialogResult = DialogResult.OK;

            this.Close();
        }

        private void txtnumeric_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (sender is TextBox && (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private bool checkInputData()
        {
            if (string.IsNullOrEmpty(txtquantity.Text))
            {
                MessageBox.Show("Quantity cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                MessageBox.Show("Unit price cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtdiscount.Text))
            {
                MessageBox.Show("Discount cannot be empty", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(Convert.ToInt32(txtquantity.Text) > maxQuantity)
            {
                MessageBox.Show("Quantity cannot be greater than the remaining", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnrevert_Click(object sender, EventArgs e)
        {
            setData();
        }

        private void setData()
        {
            txtname.Text = name;
            txtname.Enabled = false;

            txtquantity.Text = quantity.ToString("N0", CultureInfo.CurrentCulture);

            lblremaining.Text = "Remaining : " + maxQuantity;
            lblremaining.ForeColor = Color.LimeGreen;

            txtunitprice.Text = unitprice.ToString("N0", CultureInfo.CurrentCulture);
            txtdiscount.Text = discount.ToString("N0", CultureInfo.CurrentCulture);
        }
    }
}
