namespace SalesManagement.model
{
    public class mdlPayment
    {
        public Guid id { get; set; }
        public int receiptnumber { get; set; }
        public double amount { get; set; }
        public Guid debtid { get; set; }
        // paymentmethod: 0: CASH/ 1: BANKING
        public int paymentmethod { get; set; }
        // paymenttype: 0: SALES/ 1: DEBT
        public int paymenttype { get; set; }
        public DateTime paydatetime { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
