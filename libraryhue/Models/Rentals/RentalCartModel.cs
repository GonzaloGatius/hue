using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Rentals
{
    public class RentalCartModel
    {
        public int Id { get; private set; }

        public int RentalId { get; set; }
        public int ProductTypeId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
