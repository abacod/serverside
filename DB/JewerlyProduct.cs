using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abacode
{
    public class JewerlyProduct : Product
    {
        public JewerlySection Section { get; set; }

        public MaterialType MaterialType { get; set; }
    }
}
