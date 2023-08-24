using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreDetailDTO
{
    public class StoreDetailDTORequest:StoreDetailDTOBase
    {
        public Guid StoreCategoryGuid { get; set; }

    }
}
