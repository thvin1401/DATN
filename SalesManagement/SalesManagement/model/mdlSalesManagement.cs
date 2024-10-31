namespace SalesManagement.model
{
    public class mdlSalesManagement
    {
        public Guid id {  get; set; }
        public Guid userinfoid { get; set; }
        public bool isdeleted { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
