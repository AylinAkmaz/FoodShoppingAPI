using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.ProductDTO
{
    public class ProductDTOResponse : ProductDTOBase
    {
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string FoodDetailName { get; set; }
    }
}
