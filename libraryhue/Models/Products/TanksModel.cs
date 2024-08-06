using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class TanksModel : IProductsModel
    {
        public int Id { get; set; }
        public int InternNumber { get; set; }
        public string Name { get; set; }
        public DateTime? Acquired { get; set; }
        public int Price { get; set; }
        public string Condition { get; set; }
        public int StateId { get; set; }
        public string? Notes { get; set; }
        public bool IsAluminium { get; set; }
        public int SerialNumber { get; set; }
        public string? TankValves { get; set; }
        public string? Color { get; set; }
        public int? Capacity { get; set; }
        public int? Presure { get; set; }
        public DateTime? HT { get; set; }
        public bool HTCertificate { get; set; }
    }
}
