using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO
{
    public class StoreOrderDetailDTOUpdateResponse : StoreOrderDetailDTOBase
    {
        public Guid Guid { get; set; }
        public Guid StoreOrderGuid { get; set; }
        public bool? IsActive { get; set; }
    }
}
