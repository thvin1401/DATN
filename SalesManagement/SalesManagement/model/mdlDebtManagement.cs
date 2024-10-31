namespace SalesManagement.model
{
    public class mdlDebtManagement
    {
        public Guid id { get; set; }
        public Guid userinfo { get; set; }
        public double amount { get; set; }
        public DateTime lendingdatetime { get; set; }
        public bool isfullpaid { get; set; }
        public DateTime paiddatetime { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
