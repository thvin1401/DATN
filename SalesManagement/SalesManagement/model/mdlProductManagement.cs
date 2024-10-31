namespace SalesManagement.model
{
    public class mdlProductManagement
    {
        public Guid id { get; set; }
        public Guid productid { get; set; }
        public int quantity { get; set; }
        public double unitprice { get; set; }
        public bool isdeleted { get; set; }
        //statusflag: 1: import, 2: export, 3: pending
        public int statusflag { get; set; }
        public Guid salesid { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
