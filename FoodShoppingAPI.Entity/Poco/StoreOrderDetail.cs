using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class StoreOrderDetail:AuditableEntity
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Discount { get; set; }
        public int StoreOrderID { get; set; }

        public virtual StoreOrder StoreOrder { get; set; }

    }
}
