namespace SalesManagement.model
{
    public class mdlBill
    {
        public int receiptnumber { get; set; }
        public Guid userinfoid { get; set; }
        public double amount { get; set; }
        public double discount { get; set; }
        public double payamount { get; set; }
        public bool isdeleted { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
