using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.DAL.Concrete.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.Context
{
    public class FoodShopContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("data source= LAPTOP-3MT9G9C1\\SQLEXPRESS;Initial Catalog=FoodShopping;" +
                    "Integrated Security=True; TrustServerCertificate=True ");
            }





            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FoodCategoryMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new StoreDetailMap());
            modelBuilder.ApplyConfiguration(new StoreOrderMap());
            modelBuilder.ApplyConfiguration(new StoreOrderDetailMap());
            modelBuilder.ApplyConfiguration(new StoreCategoryMap());
            modelBuilder.ApplyConfiguration(new StoresMap());
            modelBuilder.ApplyConfiguration(new RoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new MenuMap());
            modelBuilder.ApplyConfiguration(new OrderMap());
            modelBuilder.ApplyConfiguration(new OrderDetailMap());
            modelBuilder.ApplyConfiguration(new StoreProductMap());
            modelBuilder.ApplyConfiguration(new FoodProductMap());
            modelBuilder.ApplyConfiguration(new FoodDetailMap());



            base.OnModelCreating(modelBuilder);
        }

    }
}

