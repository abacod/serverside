using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abacode
{
    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public CustomerCategory CustomerCategory { get; set; }

        public ProductCategory ProductCategory { get; set; }

        public int SellerId { get; set; }

        public Seller Seller { get; set; }

        public bool IsDeleted { get; set; }
    }
}
