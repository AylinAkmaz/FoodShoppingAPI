using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class ProductMap : BaseMap<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.Property(q => q.Name).HasMaxLength(100).IsRequired();
            builder.HasOne(q => q.FoodDetail).WithMany(x => x.Product).HasForeignKey(q => q.FoodDetailID);


        }

    }
}
