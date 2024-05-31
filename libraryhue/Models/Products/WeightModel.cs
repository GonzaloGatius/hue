using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class WeightModel
    {
        public int Id { get; set; }
        public int WeightTypeId { get; set; }
        public int Stock { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
}
