using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Rentals
{
    public class RentalsModels
    {
        public int Id { get; private set; }
        public int UserId { get; set; }
        public DateTime InitialDate { get; set; }
        public DateTime EndDate { get; set; }


    }
}
