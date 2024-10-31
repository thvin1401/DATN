namespace SalesManagement.model
{
    internal class mdlPayment
    {
        public Guid id { get; set; }
        public double amount { get; set; }
        public Guid salesid { get; set; }
        public Guid debtid { get; set; }
        // paymentmethod: CASH/CARD
        public string paymentmethod { get; set; } = string.Empty;
        // paymenttype: SALES/DEBT
        public string paymenttype { get; set; } = string.Empty ;
        public DateTime paydatetime { get; set; }
        public DateTime createdatetime { get; set; }
    }
}
