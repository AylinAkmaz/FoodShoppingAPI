using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO
{
    public class StoreOrderDetailDTOBase
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Discount { get; set; }
    }
}
