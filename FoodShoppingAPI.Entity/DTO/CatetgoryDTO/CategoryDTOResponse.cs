using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.CatetgoryDTO
{
    public class CategoryDTOResponse
    {
        public string Name { get; set; }
        public string FoodCategoryName { get; set; }
        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }

    }

}
