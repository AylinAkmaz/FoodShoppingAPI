using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class FoodDetail:AuditableEntity
    {
        public FoodDetail()
        {
           
            Orders = new HashSet<Order>();
            Product = new HashSet<Product>();
            Menu = new HashSet<Menu>();


        }

        public string Name { get; set; }
        public int RoleID { get; set; }
        public int FoodCategoryID { get; set; }
        public string Adress { get; set; }
        public string DeliveryTıme { get; set; }
        public string Openning { get; set; }
        public string Closing { get; set; }
        public string About { get; set; }


       
        public virtual Role Role { get; set; }
        public virtual IEnumerable<Product> Product { get; set; }
        public virtual IEnumerable<Menu> Menu { get; set; }
        public virtual FoodCategory FoodCategory { get; set; }
        public virtual IEnumerable<Order> Orders { get; set; }


    }
}
