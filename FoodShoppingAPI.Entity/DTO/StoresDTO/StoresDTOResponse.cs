using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.DTO.StoresDTO
{
    public class StoresDTOResponse
    {

        public Guid Guid { get; set; }
        public bool? IsActive { get; set; }
        public string Name { get; set; }
        public string StoreCategoryName { get; set; }



    }
}
