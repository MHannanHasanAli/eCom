using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Entities
{
    public class category : BaseEntity
    {
        public List<product> product { get; set; }
    }
}
