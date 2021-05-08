using System;

namespace InventoryApp.Domain
{
    public class MarketplaceProduct
    {
        public int MarketplaceId { get; set; }
        public int ProductId { get; set; }
        public DateTime DateListed { get; set; }
    }
}
