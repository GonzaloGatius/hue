using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class OctopusModel : ProductsModel
    {
        public string System { get; set; }
        public int? SerialNumber { get; set; }
        public int PartId { get; set; }
    }

}
