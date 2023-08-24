using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.FoodDetailDTO
{
    public class FoodDetailDTOResponse:FoodDetailDTOBase
    {
        public string FoodCategoryName { get; set; }
        public string RoleName { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }

    }
}
