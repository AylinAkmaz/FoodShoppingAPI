using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class StoreProductMap : BaseMap<StoreProduct>
    {
        public override void Configure(EntityTypeBuilder<StoreProduct> builder)
        {
            builder.ToTable("StoreProduct");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.HasOne(q => q.StoreDetail).WithMany(x => x.StoreProduct).HasForeignKey(q => q.StoreDetailID).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
