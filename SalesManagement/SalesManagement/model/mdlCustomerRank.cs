namespace SalesManagement.model
{
    internal class mdlCustomerRank
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public bool isactive { get; set; }
        public int discount { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
