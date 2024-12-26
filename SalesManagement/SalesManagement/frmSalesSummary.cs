using System.Globalization;

namespace SalesManagement
{
    public partial class frmSalesSummary : Form
    {
        public frmSalesSummary()
        {
            InitializeComponent();
        }

        private void frmSalesSummary_Load(object sender, EventArgs e)
        {
            var totalAsset = clsController.getTotalAssetTo(dpktimeto.Value);
            var totalSalesAsset = clsController.getTotalSalesAsset(dpktimeto.Value);
            var totalSales = clsController.getTotalSales(dpktimeto.Value);
            var totalPayment = clsController.getTotalPaymentFor(dpktimeto.Value);
            var totalCash = clsController.getTotalPaymentFor(dpktimeto.Value, 0);
            var totalBanking = clsController.getTotalPaymentFor(dpktimeto.Value, 1);
            var totalDebt = clsController.getTotalDebt(dpktimeto.Value, 0);
            var totalLoan = clsController.getTotalDebt(dpktimeto.Value, 1);
            var totalRevenue = totalSales - totalSalesAsset - totalLoan;

            txttotalasset.Text = totalAsset.ToString("N0", CultureInfo.CurrentCulture);
            txttotalassetsales.Text = totalSalesAsset.ToString("N0", CultureInfo.CurrentCulture);
            txttotalsales.Text = totalSales.ToString("N0", CultureInfo.CurrentCulture);
            txttotalpayment.Text = totalPayment.ToString("N0", CultureInfo.CurrentCulture);
            txttotalcash.Text = totalCash.ToString("N0", CultureInfo.CurrentCulture);
            txttotalbanking.Text = totalBanking.ToString("N0", CultureInfo.CurrentCulture);
            txttotaldebt.Text = totalDebt.ToString("N0", CultureInfo.CurrentCulture);
            txttotalloan.Text = totalLoan.ToString("N0", CultureInfo.CurrentCulture);
            txttotalrevenue.Text = totalRevenue.ToString("N0", CultureInfo.CurrentCulture);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
