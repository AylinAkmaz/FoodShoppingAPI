using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class Menu : AuditableEntity
    {
        


        public string Name { get; set; }
        public int FoodProductID { get; set; }
        public int FoodDetailID { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public string FeaturedImage { get; set; }

        public virtual FoodProduct FoodProduct { get; set; }
        public virtual FoodDetail FoodDetail { get; set; }
       

    }
}
