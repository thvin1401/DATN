namespace SalesManagement.model
{
    public class mdlDebtManagement
    {
        public Guid id { get; set; }
        public int receiptnumber { get; set; }
        public double amount { get; set; }
        public double interest { get; set; }
        public int circle { get; set; }
        // 0: unpaid, 1: partly pay, 2: full paid
        public int status { get; set; }
        // 0: lend, 1: borrow
        public int type { get; set; }
        public DateTime processeddatetime { get; set; }
        public DateTime paiddatetime { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
        public DateTime paidbeforetime { get; set; }
    }
}
