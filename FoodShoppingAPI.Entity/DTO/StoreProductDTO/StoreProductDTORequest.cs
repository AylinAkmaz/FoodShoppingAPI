using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreProductDTO
{
    public class StoreProductDTORequest:StoreProductDTOBase
    {
        public Guid StoreDetailGuid { get; set; }
    }
}
