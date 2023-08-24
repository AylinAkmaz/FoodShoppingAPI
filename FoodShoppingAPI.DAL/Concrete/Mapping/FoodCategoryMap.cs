using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class FoodCategoryMap : BaseMap<FoodCategory>
    {
        public override void Configure(EntityTypeBuilder<FoodCategory> builder)
        {
            builder.ToTable("FoodCategory");
            builder.Property(q => q.Name).HasMaxLength(50).IsRequired();

        }
    }
}
