using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abacode
{
    public class Service
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ServiceCategory ServiceCategory { get; set; }

        public string ServiceCategoryId { get; set; }

        public int Count { get; set; }

        public bool IsAvailable { get; set; }

        public bool IsDeleted { get; set; }
    }
}
