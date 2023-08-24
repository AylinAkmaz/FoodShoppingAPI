using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDTO
{
    public class StoreOrderDTOUpdateResponse
    {
        public string Name { get; set; }
        public Guid UserGuid { get; set; }
        public Guid StoreProductGuid { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
    }
}
