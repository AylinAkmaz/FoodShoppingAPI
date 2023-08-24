using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.MenuDTO
{
    public class MenuDTORequest:MenuDTOBase
    {
        public Guid FoodProductGuid { get; set; }
        public Guid FoodDetailGUID { get; set; }
    }
}
