namespace SalesManagement.model
{
    public class mdlAccount
    {
        public Guid id { get; set;}
        public string username { get; set;} = string.Empty;
        public string password { get; set;} = string.Empty;
        public Guid userinfoid { get; set;}
        public bool isenabled { get; set;}
        public DateTime createdatetime { get; set;}
        public DateTime updatedatetime { get; set;}
    }
}
