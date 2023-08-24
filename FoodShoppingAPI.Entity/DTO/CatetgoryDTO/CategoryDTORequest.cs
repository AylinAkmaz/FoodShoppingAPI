using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.CatetgoryDTO
{
    public class CategoryDTORequest
    { 
        public string Name { get; set; }
        public Guid FoodCategoryGuid { get; set; }
    }
}
