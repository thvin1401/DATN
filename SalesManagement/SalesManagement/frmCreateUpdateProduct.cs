using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmCreateUpdateProduct : Form
    {
        public bool isEdit = false;
        public string productId = string.Empty;
        public int initWeight = 0;
        private List<mdlUserInfo> providerList;
        private List<mdlCategories> categoryList;

        public frmCreateUpdateProduct()
        {
            InitializeComponent();

            txtunitprice.KeyPress += txtnumeric_KeyPress;
            txtquantity.KeyPress += txtnumeric_KeyPress;
            txtweight.KeyPress += txtnumeric_KeyPress;
            txtunitpricevnd.KeyPress += txtnumeric_KeyPress;

            cmbcurrencytype.Items.Clear();
            cmbprovider.Items.Clear();
            cmbcategory.Items.Clear();

            foreach (var item in mdlMain.App.currencyExchange)
            {
                cmbcurrencytype.Items.Add(item.name);
            }

            providerList = clsController.getUserByNameAndType(type: 3);

            if (providerList.Count != 0)
            {
                foreach (var provider in providerList)
                {
                    cmbprovider.Items.Add(new ComboBoxItem { Name = provider.name, Value = provider.id.ToString() });
                }
                cmbprovider.DisplayMember = "Name";
                cmbprovider.ValueMember = "Value";
                cmbprovider.SelectedIndex = 0;
            }
            else
            {
                ckbisnewprovider.Checked = true;
            }

            categoryList = clsController.getAllCategories();

            if (categoryList.Count != 0)
            {
                foreach (var category in categoryList)
                {
                    cmbcategory.Items.Add(new ComboBoxItem { Name = category.name, Value = category.id.ToString() });
                }
                cmbcategory.DisplayMember = "Name";
                cmbcategory.ValueMember = "Value";
                cmbcategory.SelectedIndex = 0;
            }
            else
            {
                ckbnewcategory.Checked = true;
            }
        }

        private void FrmCreateUpdateProduct_Load(object sender, EventArgs e)
        {
            if (isEdit)
            {
                lbltitle.Text = "Product update screen";

                var data = clsController.getProductEdit(productId);

                txtname.Text = data.name;
                txtquantity.Text = data.quantity.ToString();
                txtweight.Text = data.weight.ToString();
                txtunitpricevnd.Text = data.unitprice.ToString();
                cmbprovider.SelectedValue = data.providerid;
                cmbcategory.SelectedValue = data.categoryid;
                dpkimporttime.Value = data.importdatetime;
                ckbisdeleted.Checked = data.isdeleted;
            }
            else
            {
                lbltitle.Text = "Product creation screen";
            }

            txtunitprice.Enabled = false;
            txtunitpricevnd.Enabled = false;
            cmbcurrencytype.Enabled = false;

            if (!string.IsNullOrEmpty(txtweight.Text))
            {
                txtunitprice.Enabled = true;
                txtunitpricevnd.Enabled = true;
                cmbcurrencytype.Enabled = true;
            }

            cmbcurrencytype.SelectedIndex = 0;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (!checkInputData())
            {
                return;
            }

            Guid providernewguid = Guid.NewGuid();
            Guid categorynewguid = Guid.NewGuid();

            var creationTime = DateTime.Now;

            try
            {
                if (ckbisnewprovider.Checked)
                {
                    mdlUserInfo userInfo = new mdlUserInfo();
                    userInfo.id = providernewguid;
                    userInfo.name = txtnewprovidername.Text.Trim();
                    userInfo.address = "";
                    userInfo.email = "";
                    userInfo.rankid = Guid.Empty;
                    userInfo.isactive = true;
                    userInfo.point = 0;
                    userInfo.type = 3;
                    userInfo.createdatetime = creationTime;
                    userInfo.updatedatetime = creationTime;
                    userInfo.birthday = creationTime;

                    clsController.createUser(userInfo);
                }

                if (ckbnewcategory.Checked)
                {
                    mdlCategories category = new mdlCategories();
                    category.id = categorynewguid;
                    category.name = txtnewcategoryname.Text.Trim();
                    category.isdeleted = false;
                    category.createdatetime = creationTime;
                    category.updatedatetime = creationTime;

                    clsController.createNewCategory(category);
                }

                mdlProducts product = new mdlProducts();
                product.id = Guid.NewGuid();
                product.name = txtname.Text.Trim();
                product.quantity = Convert.ToInt32(txtquantity.Text.Trim().Replace(".", "").Replace(",", ""));
                product.unitprice = Convert.ToDouble(txtunitpricevnd.Text.Trim().Replace(".", "").Replace(",", ""));
                product.providerid = ckbisnewprovider.Checked ? providernewguid : Guid.Parse(((ComboBoxItem)cmbprovider.SelectedItem).Value.ToString());
                product.isdeleted = ckbisdeleted.Checked;
                product.categoryid = ckbnewcategory.Checked ? categorynewguid : Guid.Parse(((ComboBoxItem)cmbcategory.SelectedItem).Value.ToString());
                product.createdatetime = creationTime;
                product.updatedatetime = creationTime;
                product.importdatetime = dpkimporttime.Value;
                product.weight = Convert.ToInt32(txtweight.Text.Trim());

                if (isEdit)
                {
                    product.id = Guid.Parse(productId);
                    clsController.updateProduct(product);
                    mdlMain.updateMDIMainMessage("Update sucessfully", Color.LimeGreen);
                }
                else
                {
                    clsController.createNewProduct(product);
                    mdlMain.updateMDIMainMessage("Create sucessfully", Color.LimeGreen);
                }

                clearControl();
                this.Close();
            }
            catch (Exception ex)
            {
                mdlMain.updateMDIMainMessage("Processed failed", Color.LimeGreen);
                mdlMain.log(ex.Message, ex);
                return;
            }
        }

        private void cmbcurrencytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtunitprice.Text) && !string.IsNullOrEmpty(txtunitpricevnd.Text))
            {
                double unitPriceVND = Convert.ToDouble(txtunitpricevnd.Text.Trim());
                var exchangeRate = mdlMain.App.currencyExchange[cmbcurrencytype.SelectedIndex].exchangerate;

                txtunitprice.Text = (unitPriceVND / exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
            }
            if (!string.IsNullOrEmpty(txtunitprice.Text))
            {
                double weightUSDPrice = 0;

                if (initWeight != Convert.ToInt32(txtweight.Text))
                {
                    weightUSDPrice = Convert.ToInt32(txtweight.Text) * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate * 10;

                    initWeight = Convert.ToInt32(txtweight.Text);
                }

                double unitPrice = Convert.ToDouble(txtunitprice.Text.Trim());

                double exchangeRate = mdlMain.App.currencyExchange[cmbcurrencytype.SelectedIndex].exchangerate;

                txtunitprice.Text = (unitPrice + weightUSDPrice / exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
                txtunitpricevnd.Text = (exchangeRate * (unitPrice + weightUSDPrice / exchangeRate)).ToString("N0", CultureInfo.CurrentCulture);
            }
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
            if (string.IsNullOrEmpty(txtname.Text))
            {
                MessageBox.Show("Please enter product name", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtquantity.Text))
            {
                MessageBox.Show("Please enter product quantity", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtweight.Text))
            {
                MessageBox.Show("Please enter product weight", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtunitprice.Text))
            {
                MessageBox.Show("Please enter product unit price", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ckbisnewprovider.Checked && string.IsNullOrEmpty(txtnewprovidername.Text))
            {
                MessageBox.Show("Please enter new provider", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ckbnewcategory.Checked && string.IsNullOrEmpty(txtnewcategoryname.Text))
            {
                MessageBox.Show("Please enter new category", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void ckbisnewprovider_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbisnewprovider.Checked)
            {
                cmbprovider.Enabled = false;
                txtnewprovidername.Enabled = true;
            }
            else
            {
                cmbprovider.Enabled = true;
                txtnewprovidername.Enabled = false;
            }
        }

        private void ckbnewcategory_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbnewcategory.Checked)
            {
                cmbcategory.Enabled = false;
                txtnewcategoryname.Enabled = true;
            }
            else
            {
                cmbcategory.Enabled = true;
                txtnewcategoryname.Enabled = false;
            }
        }

        private void clearControl()
        {
            txtname.Clear();
            txtquantity.Clear();
            txtweight.Clear();
            txtunitprice.Clear();
            txtunitpricevnd.Clear();
            txtnewprovidername.Clear();
            txtnewcategoryname.Clear();
            cmbcurrencytype.Items.Clear();
            cmbprovider.Items.Clear();
            cmbcategory.Items.Clear();
            ckbisnewprovider.Checked = false;
            ckbnewcategory.Checked = false;
            dpkimporttime.Value = DateTime.Today;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            clearControl();

            this.Close();
        }

        private void txtweight_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtweight.Text))
            {
                txtunitprice.Enabled = true;
                txtunitpricevnd.Enabled = true;
                cmbcurrencytype.Enabled = true;
            }
            else
            {
                txtunitprice.Enabled = false;
                txtunitpricevnd.Enabled = false;
                cmbcurrencytype.Enabled = false;
            }
        }
    }
}
