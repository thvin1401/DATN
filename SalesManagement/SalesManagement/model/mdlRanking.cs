namespace SalesManagement.model
{
    public class mdlRanking
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public bool isactive { get; set; }
        public double discount { get; set; }
        public int achivepoint { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
