using FoodShoppingAPI.Entity.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Entity.Poco
{
    public class StoreOrder:AuditableEntity
    {
        public StoreOrder()
        {
            StoreOrderDetail=new HashSet<StoreOrderDetail>();
        }
        public string Name { get; set; }
        public int StoreProductID { get; set; }
        public int UserID { get; set; }


        public virtual StoreProduct StoreProduct { get; set; }
        public virtual IEnumerable<StoreOrderDetail> StoreOrderDetail { get; set;}
        public virtual User User { get; set; }

    }
}
