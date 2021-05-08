using System.Collections.Generic;

namespace InventoryApp.Domain
{
    public class Marketplace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
        public Comission Comission { get; set; }
    }
}