﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class BCDsModel : IProductsModel
    {
        public int Id { get; set; }
        public int InternNumber { get; set; }
        public DateTime? Acquired { get; set; }
        public int Price { get; set; }
        public string Condition { get; set; }
        public int StateId { get; set; }
        public string? Notes { get; set; }
        public string Valves { get; set; }
        public string? Power { get; set; }
        public string? Model { get; set; }
        public string? Brand { get; set; }
        public int SizeId { get; set; }
    }
}
