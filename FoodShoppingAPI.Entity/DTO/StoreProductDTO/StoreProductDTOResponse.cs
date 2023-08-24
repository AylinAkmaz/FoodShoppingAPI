using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreProductDTO
{
    public class StoreProductDTOResponse:StoreProductDTOBase
    {

        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string StoreDetailName { get; set; }

    }
}
