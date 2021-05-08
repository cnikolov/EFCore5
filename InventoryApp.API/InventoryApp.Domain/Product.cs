using System.Collections.Generic;

namespace InventoryApp.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int SupplierId { get; set; }
        public List<Quote> Quotes { get; set; }
        public List<Marketplace> Marketplaces { get; set; }
    }
}
