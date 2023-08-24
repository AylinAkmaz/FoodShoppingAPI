using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.FoodProductDTO
{
    public class FoodProductDTOUpdateResponse:FoodProductDTOBase
    {
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
    }
}
