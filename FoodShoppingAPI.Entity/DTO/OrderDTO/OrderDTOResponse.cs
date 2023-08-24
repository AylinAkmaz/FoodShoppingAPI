using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.OrderDTO
{
    public class OrderDTOResponse : OrderDTOBase
    {
        public string UserName { get; set; }
        public string FoodDetailName { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
    }
}
