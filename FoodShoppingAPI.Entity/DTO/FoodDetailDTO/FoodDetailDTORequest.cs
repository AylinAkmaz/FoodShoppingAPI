using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.FoodDetailDTO
{
    public class FoodDetailDTORequest:FoodDetailDTOBase
    {
        public Guid FoodCategoryGuid { get; set; }
        public Guid RoleGuid { get; set; }
    }
}
