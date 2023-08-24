using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.DAL.Abstract.DataManagment
{
    public interface IUnitOfWork
    {
        IFoodCategoryRepository FoodCategoryRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IFoodDetailRepository FoodDetailRepository { get; }
        IMenuRepository MenuRepository { get; }
        IUserRepository UserRepository { get; }
        IOrderRepository OrderRepository { get; }
        IStoreOrderRepository StoreOrderRepository { get; }
        IStoreOrderDetailRepository StoreOrderDetailRepository { get; }
        IOrderDetailRepository OrderDetailRepository { get; }
        IProductRepository ProductRepository { get; }
        IRoleRepository RoleRepository { get; }
        IStoreDetailRepository StoreDetailRepository { get; }
        IStoresRepository StoresRepository { get; }
        IStoreCategoryRepository StoreCategoryRepository { get; }
        IStoreProductRepository StoreProductRepository { get; }
        IFoodProductRepository FoodProductRepository { get; }
        Task<int> SaveChangeAsync();


    }
}
