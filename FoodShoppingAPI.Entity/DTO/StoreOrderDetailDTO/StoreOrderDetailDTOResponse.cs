using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO
{
    public class StoreOrderDetailDTOResponse:StoreOrderDetailDTOBase
    {
        public Guid Guid { get; set; }
        public string StoreOrderName { get; set; }
        public bool? IsActive { get; set; }
    }
}
