using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delivarymanagement.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public int CatId { get; set; }
        public string itemDestination { get; set; }
        public string ownerName { get; set; }
        public int ownerContact { get; set; }
    }
}
