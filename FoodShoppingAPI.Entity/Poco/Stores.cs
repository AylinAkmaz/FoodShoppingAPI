using FoodShoppingAPI.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.Poco
{
    public class Stores:AuditableEntity
    {
       


        public string Name { get; set; }
        public int StoreCategoryID { get; set; }

        public virtual StoreCategory StoreCategory { get; set; }
    }
}
