using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.FoodCategoryDTO
{
    public class FoodCategoryDTOResponse:FoodCategoryDTOBase
    {

        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }



    }
}
