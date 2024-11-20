﻿namespace SalesManagement.model
{
    public class mdlProductManagement
    {
        public Guid id { get; set; }
        public int receiptnumber { get; set; }
        public Guid productid { get; set; }
        public int quantity { get; set; }
        public double unitprice { get; set; }
        public double discount { get; set; }
        public DateTime createdatetime { get; set; }
        public DateTime updatedatetime { get; set; }
    }
}
