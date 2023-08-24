﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.MenuDTO
{
    public class MenuDTOBase
    {
        public string Name { get; set; }     
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
    }
}
