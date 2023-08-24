﻿using FoodShoppingAPI.Busıness.Abstract.BaseService;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.Busıness.Abstract
{
    public interface IStoreProductService : IGenericService<StoreProduct>
    {
        Task StoreProductAdd(StoreProduct storeProduct, List<StoreDetail> storeDetails);

    }
}
