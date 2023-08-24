using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class User : AuditableEntity
    {
        public User()
        {
            Orders = new HashSet<Order>();
            StoreOrder = new HashSet<StoreOrder>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }

        public virtual IEnumerable<Order> Orders { get; set; }
        public virtual IEnumerable<StoreOrder> StoreOrder { get; set; }


    }
}
