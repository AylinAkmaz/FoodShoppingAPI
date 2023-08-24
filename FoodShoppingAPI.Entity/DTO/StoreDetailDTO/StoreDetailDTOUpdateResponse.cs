using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreDetailDTO
{
    public class StoreDetailDTOUpdateResponse : StoreDetailDTOBase
    {
        public StoreDetailDTOUpdateResponse()
        {
            this.Guid = Guid.NewGuid();
        }

        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string StoreCategoryName { get; set; }

    }
}
