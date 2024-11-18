namespace SalesManagement.model
{
    public class mdlProducts
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public int quantity { get; set; }
        public double unitprice { get; set; }
        public Guid providerid { get; set; }
        public bool isdeleted { get; set; }
        public Guid categoryid { get; set; }
        public int weight { get; set; }
        public DateTime importdatetime { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
