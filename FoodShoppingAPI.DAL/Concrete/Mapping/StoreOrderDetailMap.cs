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
    public class StoreOrderDetailMap : BaseMap<StoreOrderDetail>
    {
        public override void Configure(EntityTypeBuilder<StoreOrderDetail> builder)
        {
            builder.ToTable("StoreOrderDetail");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.HasOne(q => q.StoreOrder).WithMany(x => x.StoreOrderDetail).HasForeignKey(q => q.StoreOrderID).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
