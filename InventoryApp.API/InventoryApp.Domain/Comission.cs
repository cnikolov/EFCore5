using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryApp.Domain
{
    public class Comission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double CommisionRate { get; set; }
        public int MarketplaceId { get; set; }
    }
}
