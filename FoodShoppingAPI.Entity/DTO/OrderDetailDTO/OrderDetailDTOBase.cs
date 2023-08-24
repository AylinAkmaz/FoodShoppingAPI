using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.OrderDetailDTO
{
    public class OrderDetailDTOBase
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Discount { get; set; }
    }
}
