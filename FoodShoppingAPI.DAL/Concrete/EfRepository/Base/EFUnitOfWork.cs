using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.Entity.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using FoodShoppingAPI.DAL.Concrete.Context;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository.Base
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly FoodShopContext _foodShopcontext;
        private readonly IHttpContextAccessor _contextAccessor;
        public EFUnitOfWork(FoodShopContext foodShopcontext, IHttpContextAccessor contextAccessor)
        {
            _foodShopcontext = foodShopcontext;
            _contextAccessor = contextAccessor;

            FoodCategoryRepository = new EFFoodCategoryRepository(_foodShopcontext);
            UserRepository = new EFUserRepository(_foodShopcontext);
            OrderRepository = new EFOrderRepository(_foodShopcontext);
            OrderDetailRepository = new EFOrderDetailRepository(_foodShopcontext);
            ProductRepository = new EFProductRepository(_foodShopcontext);
            StoreProductRepository = new EFStoreProductRepository(_foodShopcontext);
            RoleRepository = new EFRoleRepository(_foodShopcontext);
            MenuRepository = new EFMenuRepository(_foodShopcontext);
            FoodDetailRepository = new EFFoodDetailRepository(_foodShopcontext);
            StoreCategoryRepository = new EFStoreCategoryRepository(_foodShopcontext);
            CategoryRepository = new EFCategoryRepository(_foodShopcontext);
            StoreDetailRepository = new EFStoreDetailRepository(_foodShopcontext);
            StoreOrderDetailRepository = new EFStoreOrderDetailRepository(_foodShopcontext);
            StoreOrderRepository = new EFStoreOrderRepository(_foodShopcontext);
            StoresRepository = new EFStoresRepository(_foodShopcontext);
            FoodProductRepository = new EFFoodProductRepository(_foodShopcontext);



        }
        public IFoodCategoryRepository FoodCategoryRepository { get; }
        public ICategoryRepository CategoryRepository { get; }
        public IStoreProductRepository StoreProductRepository { get; }
        public IRoleRepository RoleRepository { get; }
        public IOrderRepository OrderRepository { get; }
        public IStoreOrderRepository StoreOrderRepository { get; }
        public IStoreOrderDetailRepository StoreOrderDetailRepository { get; }
        public IOrderDetailRepository OrderDetailRepository { get; }
        public IProductRepository ProductRepository { get; }
        public IUserRepository UserRepository { get; }
        public IStoreCategoryRepository StoreCategoryRepository { get; }
        public IStoresRepository StoresRepository { get; }
        public IStoreDetailRepository StoreDetailRepository { get; }
        public IFoodDetailRepository FoodDetailRepository { get; }
        public IMenuRepository MenuRepository { get; }
        public IFoodProductRepository FoodProductRepository { get; }




        public async Task<int> SaveChangeAsync()
        {
            foreach (var item in _foodShopcontext.ChangeTracker.Entries<AuditableEntity>())
            {
                if (item.State == Microsoft.EntityFrameworkCore.EntityState.Added)
                {
                    item.Entity.AddedTime = DateTime.Now;
                    item.Entity.UpdateTime = DateTime.Now;
                    item.Entity.AddedUser = 1;
                    item.Entity.UpdatedUser = 1;
                    item.Entity.AddedIPV4Adress = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
                    item.Entity.UpdatedIPV4Adress = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();

                    if (item.Entity.IsActive == null)
                    {
                        item.Entity.IsActive = true;
                    }

                    item.Entity.IsDeleted = false;

                }
                else if (item.State == EntityState.Modified)
                {
                    item.Entity.UpdateTime = DateTime.Now;
                    item.Entity.UpdatedUser = 1;
                    item.Entity.UpdatedIPV4Adress = _contextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
                }

            }
            return await _foodShopcontext.SaveChangesAsync();

        }
    }
}
