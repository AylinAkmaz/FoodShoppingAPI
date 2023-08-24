using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.MenuDTO
{
    public class MenuDTOUpdateResponse : MenuDTOBase
    {
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string FoodProductName { get; set; }
        public string FoodDetailName { get; set; }

    }
}
