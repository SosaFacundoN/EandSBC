using System.Collections.Generic;
using System.Text;


namespace Inventory.Core
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int ProviderId { get; set; }

    }
}
