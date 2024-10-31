namespace SalesManagement.model
{
    public class mdlUserInfo
    {
        public Guid id { get; set; }
        public string name { get; set; } = string.Empty;
        public string address { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;
        public string phone { get; set; } = string.Empty;
        public Guid rankid { get; set; }
        public bool isactive { get; set; }
        public int point { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }

        public mdlUserInfo()
        {
            id = Guid.NewGuid();
        }
    }
}
