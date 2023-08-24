using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class FoodDetailMap : BaseMap<FoodDetail>
    {
        public override void Configure(EntityTypeBuilder<FoodDetail> builder)
        {
            builder.ToTable("FoodDetail");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.Property(q => q.Adress).HasMaxLength(100).IsRequired();
            builder.HasOne(q => q.FoodCategory).WithMany(x => x.FoodDetail).HasForeignKey(q => q.FoodCategoryID).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
