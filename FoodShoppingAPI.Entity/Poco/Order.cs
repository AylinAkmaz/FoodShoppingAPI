using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class Order : AuditableEntity
    {
        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }

        public string Name { get; set; }
        public int UserID { get; set; }
        public int FoodDetailID { get; set; }


        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
        public virtual User User { get; set; }
        public virtual FoodDetail FoodDetail { get; set; }

    }
}
