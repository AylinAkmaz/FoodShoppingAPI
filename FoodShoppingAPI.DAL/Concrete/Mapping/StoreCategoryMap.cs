using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class StoreCategoryMap : BaseMap<StoreCategory>
    {
        public override void Configure(EntityTypeBuilder<StoreCategory> builder)
        {
            builder.ToTable("StoreCategory");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();


        }
    }
}
