using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.ProductDTO
{
    public class ProductDTOBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
    }
}
