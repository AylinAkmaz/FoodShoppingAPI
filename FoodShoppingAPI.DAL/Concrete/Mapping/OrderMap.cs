using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class OrderMap : BaseMap<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.Property(q => q.Name).HasMaxLength(20).IsRequired();
            builder.HasOne(q => q.User).WithMany(q => q.Orders).HasForeignKey(q => q.UserID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.FoodDetail).WithMany(q => q.Orders).HasForeignKey(q => q.FoodDetailID);



        }
    }
}
