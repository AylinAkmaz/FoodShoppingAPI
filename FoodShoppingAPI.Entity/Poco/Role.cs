using FoodShoppingAPI.Entity.Base;

namespace FoodShoppingAPI.Entity.Poco
{
    public class Role : AuditableEntity
    {
        public Role()
        {
            FoodDetails = new HashSet<FoodDetail>();
        }
        public string Name { get; set; }


        public virtual IEnumerable<FoodDetail> FoodDetails { get; set; }



    }
}
