using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class StoreDetailMap : BaseMap<StoreDetail>
    {
        public override void Configure(EntityTypeBuilder<StoreDetail> builder)
        {
            builder.ToTable("StoreDetail");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.HasOne(q => q.StoreCategory).WithMany(x => x.StoreDetail).HasForeignKey(q => q.StoreCategoryID);
           

        }
    }
}
