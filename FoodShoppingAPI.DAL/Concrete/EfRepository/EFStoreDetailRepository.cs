﻿using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFStoreDetailRepository : EFRepository<StoreDetail>, IStoreDetailRepository
    {
        public EFStoreDetailRepository(DbContext context) : base(context)
        {
        }
    }

}
