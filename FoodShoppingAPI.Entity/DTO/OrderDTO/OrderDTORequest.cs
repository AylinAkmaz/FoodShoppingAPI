using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.OrderDTO
{
    public class OrderDTORequest:OrderDTOBase
    {
        public Guid UserGuid { get; set; }
        public Guid FoodDetailGuid { get; set; }
    }
}
