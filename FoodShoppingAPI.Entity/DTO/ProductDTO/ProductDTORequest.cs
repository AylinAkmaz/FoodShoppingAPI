using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.ProductDTO
{
    public class ProductDTORequest:ProductDTOBase
    {
        public Guid FoodDetailGuid { get; set; }

    }
}
