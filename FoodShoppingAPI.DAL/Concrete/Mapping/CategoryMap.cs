using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class CategoryMap : BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.Property(q => q.Name).HasMaxLength(50).IsRequired();
            builder.HasOne(q => q.FoodCategory).WithMany(x => x.Category).HasForeignKey(q => q.FoodCategoryID).OnDelete(DeleteBehavior.Cascade);

        }
    }
}
