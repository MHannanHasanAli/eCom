using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Entities
{
    public class product : BaseEntity
    {
        public decimal price { get; set; }

        public category category { get; set; }
    }
}
