using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class StoreCategory : AuditableEntity
    {

        public StoreCategory()
        {
            StoreDetail = new HashSet<StoreDetail>();
            Stores= new HashSet<Stores>();
        }


        public string Name { get; set; }

        public virtual IEnumerable<StoreDetail> StoreDetail { get; set; }

        public virtual IEnumerable<Stores> Stores { get; set; }


    }
}
