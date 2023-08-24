using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.DAL.Concrete.Mapping
{
    public class StoreOrderMap: BaseMap<StoreOrder>
    {
        public override void Configure(EntityTypeBuilder<StoreOrder> builder)
        {
            builder.ToTable("StoreOrder");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.HasOne(q => q.StoreProduct).WithMany(x => x.StoreOrder).HasForeignKey(q => q.StoreProductID);
            builder.HasOne(q => q.User).WithMany(x => x.StoreOrder).HasForeignKey(q => q.UserID);


        }


    }
}
