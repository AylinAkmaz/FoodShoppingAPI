using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class OrderDetail : AuditableEntity
    {
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double Quantity { get; set; }
        public double? Discount { get; set; }
        public int OrderID { get; set; }




        public virtual Order Order { get; set; }

    }
}
