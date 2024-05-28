﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libraryhue.Models.Products
{
    public class ProductsModel
    {
        public int Id { get; set; }
        public int InternNumber { get; set; }
        public int? BrandId { get; set; }
        public string? Model { get; set; }
        public int? SizeId { get; set; }
        public DateTime? Acquired { get; set; }
        public int? Condition { get; set; }
        public int Price { get; set; }
        public string Notes { get; set; }
    }

}
