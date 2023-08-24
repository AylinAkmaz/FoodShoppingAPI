using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.OrderDetailDTO
{
    public class OrderDetailDTOUpdateResponse : OrderDetailDTOBase
    {
        public Guid OrderGuid { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
    }
}
