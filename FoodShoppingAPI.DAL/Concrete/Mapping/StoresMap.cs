﻿using FoodShoppingAPI.DAL.Concrete.Mapping.BaseMap;
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
    public class StoresMap : BaseMap<Stores>
    {
        public override void Configure(EntityTypeBuilder<Stores> builder)
        {
            builder.ToTable("Stores");
            builder.Property(q => q.Name).HasMaxLength(30).IsRequired();
            builder.HasOne(q => q.StoreCategory).WithMany(x => x.Stores).HasForeignKey(q => q.StoreCategoryID).OnDelete(DeleteBehavior.Cascade);


        }
    }
}
