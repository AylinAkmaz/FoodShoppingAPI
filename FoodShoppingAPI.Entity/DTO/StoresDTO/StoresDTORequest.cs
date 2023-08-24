using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoresDTO
{
    public class StoresDTORequest
    {
        public string Name { get; set; }
        public Guid StoreCategoryGuid { get; set; }


    }
}
