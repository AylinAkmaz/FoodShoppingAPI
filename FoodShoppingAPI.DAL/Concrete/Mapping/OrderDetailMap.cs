using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class OrderDetailMap : BaseMap<OrderDetail>
    {
        public override void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.Property(q => q.Name).HasMaxLength(50).IsRequired();
            builder.HasOne(q => q.Order).WithMany(q => q.OrderDetails).HasForeignKey(q => q.OrderID).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
