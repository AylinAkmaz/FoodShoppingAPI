using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreProductDTO
{
    public class StoreProductUpdateDTOResponse:StoreProductDTOBase
    {
        public StoreProductUpdateDTOResponse()
        {
            this.Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }

        public Guid StoreDetailGuid { get; set; }



    }
}
