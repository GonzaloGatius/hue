using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models
{
    public class RentalModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public int AccId { get; set; }
        public int BodyId { get; set; }
        public int FootwearId { get; set; }
        public int Quantity { get; set; }

    }
}
