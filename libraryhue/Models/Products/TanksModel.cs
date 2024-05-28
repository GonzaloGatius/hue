using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class TanksModel : Products
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public bool IsAluminium { get; set; }
        public int SerialNumber { get; set; }
        public string TankValves { get; set; }
        public int? ColorId { get; set; }
        public int? Capacity { get; set; }
        public int? Presure { get; set; }
        public DateTime HT { get; set; }
        public bool HTCertificate { get; set; }
    }
}
