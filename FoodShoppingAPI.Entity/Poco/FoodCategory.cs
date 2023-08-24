using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class FoodCategory:AuditableEntity
    {
        public FoodCategory()
        {
            FoodDetail = new HashSet<FoodDetail>();
            Category= new HashSet<Category>();
        }


        public string Name { get; set; }
     


        public virtual IEnumerable<FoodDetail> FoodDetail { get; set; }
        public virtual IEnumerable<Category> Category { get; set; }


    }
}
