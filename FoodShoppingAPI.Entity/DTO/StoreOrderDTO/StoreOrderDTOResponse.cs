using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreOrderDTO
{
    public class StoreOrderDTOResponse
    {
        public string Name { get; set; }
        public string StoreProductName { get; set; }
        public string UserName { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }

    }
}
