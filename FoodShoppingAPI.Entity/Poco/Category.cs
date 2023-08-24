using FoodShoppingAPI.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.Poco
{
    public class Category:AuditableEntity
    {

        public string Name { get; set; }
        public int FoodCategoryID { get; set; }



        public virtual FoodCategory FoodCategory { get; set; }
    }
}
