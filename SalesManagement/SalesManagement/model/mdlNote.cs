namespace SalesManagement.model
{
    internal class mdlNote
    {
        public Guid id { get; set; }
        public string message { get; set; } = string.Empty;
        public bool isdone { get; set; }
        public bool isdeleted { get; set; }
        public DateTime reminddatetime { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
