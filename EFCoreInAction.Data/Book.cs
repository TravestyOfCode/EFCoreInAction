using System;

namespace EFCoreInAction.Data
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? PublishedOn { get; set; }
        public string Publisher { get; set; }
        public decimal Price { get; set; }
        public string ImageURL { get; set; }
    }
}
