using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class FoodProductMap:BaseMap<FoodProduct>
    {
        public override void Configure(EntityTypeBuilder<FoodProduct> builder)
        {
            builder.ToTable("FoodProduct");
            builder.Property(q => q.Name).HasMaxLength(50).IsRequired();


        }
    }
}
