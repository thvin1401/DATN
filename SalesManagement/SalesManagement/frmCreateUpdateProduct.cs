using SalesManagement.model;
using System.Globalization;

namespace SalesManagement
{
    public partial class frmCreateUpdateProduct : Form
    {
        public bool isEdit = false;
        public string productId = string.Empty;
        private double exchangeRate = 0;
        private double exchangeRate1 = 0;
        private List<mdlUserInfo> providerList;
        private List<mdlCategories> categoryList;

        public frmCreateUpdateProduct()
        {
            InitializeComponent();

            cmbcurrencytype.Items.Clear();
            cmbcurrencytype1.Items.Clear();
            cmbprovider.Items.Clear();
            cmbcategory.Items.Clear();

            foreach (var item in mdlMain.App.currencyExchange)
            {
                cmbcurrencytype.Items.Add(item.name);
                cmbcurrencytype1.Items.Add(item.name);
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
            cmbcurrencytype.SelectedIndex = 0;
            cmbcurrencytype1.SelectedIndex = 0;

            exchangeRate = mdlMain.App.currencyExchange[cmbcurrencytype.SelectedIndex].exchangerate;
            exchangeRate1 = mdlMain.App.currencyExchange[cmbcurrencytype1.SelectedIndex].exchangerate;

            if (isEdit)
            {
                lbltitle.Text = "Product update screen";

                var data = clsController.getProductEdit(productId);
                txtname.Text = data.name;
                txtquantity.Text = data.quantity.ToString("N0", CultureInfo.CurrentCulture);
                txtweight.Text = data.weight.ToString("N0", CultureInfo.CurrentCulture);
                txtunitpricevnd.Text = data.unitprice.ToString("N0", CultureInfo.CurrentCulture);
                txtimportprice.Text = (data.importprice / exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
                txtimportpricevnd.Text = data.importprice.ToString("N0", CultureInfo.CurrentCulture);
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
            cmbcurrencytype.Enabled = false;

            if (!string.IsNullOrEmpty(txtweight.Text))
            {
                txtunitprice.Enabled = true;
                cmbcurrencytype.Enabled = true;
            }
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
                product.importprice = Convert.ToDouble(txtimportpricevnd.Text.Trim().Replace(".", "").Replace(",", ""));
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

                this.Close();
            }
            catch (Exception ex)
            {
                mdlMain.log(ex.Message, ex);
                var result = MessageBox.Show(clsConfig.messageProcessFailed + ", try again?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    clearControl();
                    return;
                }
                else
                {
                    mdlMain.updateMDIMainMessage(clsConfig.messageProcessFailed, Color.LimeGreen);
                    this.Close();
                }
            }
        }

        private void cmbcurrencytype_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeRate = mdlMain.App.currencyExchange[cmbcurrencytype.SelectedIndex].exchangerate;

            var unitprice = string.IsNullOrEmpty(txtunitprice.Text) ? 0 : Convert.ToDouble(txtunitprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            txtunitpricevnd.Text = ((unitprice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate)) * exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
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
            if (string.IsNullOrEmpty(txtimportprice.Text))
            {
                MessageBox.Show("Please enter product import price", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtimportprice.Clear();
            txtunitprice.Clear();
            txtunitpricevnd.Clear();
            txtnewprovidername.Clear();
            txtnewcategoryname.Clear();
            ckbisnewprovider.Checked = false;
            ckbnewcategory.Checked = false;
            dpkimporttime.Value = DateTime.Today;

            cmbcurrencytype.SelectedIndex = 0;
            cmbcurrencytype1.SelectedIndex = 0;

            cmbprovider.SelectedIndex = 0;
            cmbcategory.SelectedIndex = 0;

            exchangeRate = mdlMain.App.currencyExchange[cmbcurrencytype.SelectedIndex].exchangerate;
            exchangeRate1 = mdlMain.App.currencyExchange[cmbcurrencytype1.SelectedIndex].exchangerate;
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtweight_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtweight.Text))
            {
                txtweight.Text = Convert.ToInt32(txtweight.Text).ToString("N0", CultureInfo.CurrentCulture);

                txtunitprice.Enabled = true;
                cmbcurrencytype.Enabled = true;
            }
            else
            {
                txtunitprice.Enabled = false;
                cmbcurrencytype.Enabled = false;
            }
        }

        private void txtweight_TextChanged(object sender, EventArgs e)
        {
            var unitprice = string.IsNullOrEmpty(txtunitprice.Text) ? 0 : Convert.ToDouble(txtunitprice.Text.Replace(".", "").Replace(",", ""));
            var importPrice = string.IsNullOrEmpty(txtimportprice.Text) ? 0 : Convert.ToDouble(txtimportprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            txtunitpricevnd.Text = ((unitprice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate)) * exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
            txtimportpricevnd.Text = ((importPrice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate1)) * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void txtimportprice_TextChanged(object sender, EventArgs e)
        {
            var importPrice = string.IsNullOrEmpty(txtimportprice.Text) ? 0 : Convert.ToDouble(txtimportprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            //txtimportpricevnd.Text = (importPrice * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
            txtimportpricevnd.Text = ((importPrice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate1)) * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void txtunitprice_TextChanged(object sender, EventArgs e)
        {
            var unitprice = string.IsNullOrEmpty(txtunitprice.Text) ? 0 : Convert.ToDouble(txtunitprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            txtunitpricevnd.Text = ((unitprice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate)) * exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void txtimportprice_Leave(object sender, EventArgs e)
        {
            txtimportprice.Text = string.IsNullOrEmpty(txtimportprice.Text) ? "0" : Convert.ToInt32(txtimportprice.Text.Replace(".", "").Replace(",", "")).ToString("N0", CultureInfo.CurrentCulture);

            var importPrice = string.IsNullOrEmpty(txtimportprice.Text) ? 0 : Convert.ToDouble(txtimportprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            //txtimportpricevnd.Text = (importPrice * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
            txtimportpricevnd.Text = ((importPrice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate1)) * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void txtunitprice_Leave(object sender, EventArgs e)
        {
            txtunitprice.Text = string.IsNullOrEmpty(txtunitprice.Text) ? "0" : Convert.ToInt32(txtunitprice.Text.Replace(".", "").Replace(",", "")).ToString("N0", CultureInfo.CurrentCulture);

            var unitprice = string.IsNullOrEmpty(txtunitprice.Text) ? 0 : Convert.ToDouble(txtunitprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            txtunitpricevnd.Text = ((unitprice + weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate) * exchangeRate).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void cmbcurrencytype1_SelectedIndexChanged(object sender, EventArgs e)
        {
            exchangeRate1 = mdlMain.App.currencyExchange[cmbcurrencytype1.SelectedIndex].exchangerate;
            var importPrice = string.IsNullOrEmpty(txtimportprice.Text) ? 0 : Convert.ToDouble(txtimportprice.Text.Replace(".", "").Replace(",", ""));
            var weightUSD = string.IsNullOrEmpty(txtweight.Text) ? 0 : Convert.ToDouble(txtweight.Text.Replace(".", "").Replace(",", ""));

            //txtimportpricevnd.Text = (importPrice * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
            txtimportpricevnd.Text = ((importPrice + (weightUSD * 10 * mdlMain.App.currencyExchange.First(x => x.name == "USD").exchangerate / exchangeRate1)) * exchangeRate1).ToString("N0", CultureInfo.CurrentCulture);
        }

        private void txtquantity_Leave(object sender, EventArgs e)
        {
            txtquantity.Text = string.IsNullOrEmpty(txtquantity.Text) ? "0" : Convert.ToInt32(txtquantity.Text.Replace(".", "").Replace(",", "")).ToString("N0", CultureInfo.CurrentCulture);
        }
    }
}
