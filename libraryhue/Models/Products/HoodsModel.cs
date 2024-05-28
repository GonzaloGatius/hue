using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class HoodsModel : Products
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public int ColorId { get; set; }
    }

}
