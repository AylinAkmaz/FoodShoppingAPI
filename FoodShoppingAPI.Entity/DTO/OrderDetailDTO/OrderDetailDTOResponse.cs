using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.OrderDetailDTO
{
    public class OrderDetailDTOResponse : OrderDetailDTOBase
    {
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string OrderName { get; set; }
    }
}
