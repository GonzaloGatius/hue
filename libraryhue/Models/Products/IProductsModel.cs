using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public interface IProductsModel
    {
        public int Id { get; set; }
        public int InternNumber { get; set; }
        public string Name { get; set; }
        public DateTime? Acquired { get; set; }
        public int Price { get; set; }
        public string Condition { get; set; }
        public int StateId { get; set; }
        public string? Notes { get; set; }
    }
}
