using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class MenuMap : BaseMap<Menu>
    {
        public override void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.ToTable("Menu");
            builder.Property(q => q.Name).HasMaxLength(35).IsRequired();
            builder.HasOne(q => q.FoodProduct).WithMany(q => q.Menu).HasForeignKey(q => q.FoodProductID).OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(q => q.FoodDetail).WithMany(q => q.Menu).HasForeignKey(q => q.FoodDetailID);

        }
    }
}
