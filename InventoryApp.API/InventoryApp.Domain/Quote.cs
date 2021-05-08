using System;

namespace InventoryApp.Domain
{
    public class Quote
    {
        public int Id { get; set; }
        public double QuotedPrice { get; set; }
        public DateTime QuotedDate { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
    }
}