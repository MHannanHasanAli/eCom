using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCom.Entities
{
    public class product : BaseEntity
    {
        public decimal price { get; set; }
        public int CategoryId { get; set; }
        public category category { get; set; }
    }
}
