namespace SalesManagement.model
{
    internal class mdlCategories
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public bool isdeleted { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
