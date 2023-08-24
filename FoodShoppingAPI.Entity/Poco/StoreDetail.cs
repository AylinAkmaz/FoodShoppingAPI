using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class StoreDetail : AuditableEntity
    {
       
        public StoreDetail()
        {
            StoreProduct= new HashSet<StoreProduct>();

        }



        public string Name { get; set; }

        public int StoreCategoryID { get; set; }





        public virtual StoreCategory StoreCategory { get; set; }
        public virtual IEnumerable<StoreProduct> StoreProduct { get; set; }
        

    }
}
