namespace SalesManagement.model
{
    public class mdlBill
    {
        public int receiptnumber { get; set; }
        public int billtype { get; set; } // 0: sales 1: pay debt
        public double amount { get; set; }
        public double discount { get; set; }
        public double payamount { get; set; }
        public bool isdeleted { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
