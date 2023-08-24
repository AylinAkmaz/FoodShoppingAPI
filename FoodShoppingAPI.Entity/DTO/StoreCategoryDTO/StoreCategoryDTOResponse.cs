using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoreCategoryDTO
{
    public class StoreCategoryDTOResponse:StoreCategoryDTOBase
    {
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }


    }
}
