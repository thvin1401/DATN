namespace SalesManagement.model
{
    public class mdlProviders
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
