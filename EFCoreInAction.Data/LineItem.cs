namespace EFCoreInAction.Data
{
    public class LineItem
    {
        public int LineItemId { get; set; }
        public int LineNumber { get; set; }
        public int NumBooks { get; set; }
        public decimal BookPrice { get; set; }
        public int BookId { get; set; }
        public int OrderId { get; set; }
    }
}
