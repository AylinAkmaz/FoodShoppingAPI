using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class StoreProduct : AuditableEntity
    {
        public StoreProduct()
        {
            StoreOrder= new HashSet<StoreOrder>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public string FeaturedImage { get; set; }
        public int StoreDetailID { get; set; }



        public virtual StoreDetail StoreDetail { get; set; }
        public virtual IEnumerable<StoreOrder> StoreOrder { get; set; }
        

    }
}
