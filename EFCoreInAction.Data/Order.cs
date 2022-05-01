using System;

namespace EFCoreInAction.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime DateOrderedUTC { get; set; }
        public string CustomerName { get; set; }
    }
}
