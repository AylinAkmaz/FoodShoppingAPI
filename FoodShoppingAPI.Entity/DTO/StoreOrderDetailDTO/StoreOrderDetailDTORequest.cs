using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO
{
    public class StoreOrderDetailDTORequest:StoreOrderDetailDTOBase
    {
        public Guid StoreOrderGuid { get; set; }
  
    }
}
