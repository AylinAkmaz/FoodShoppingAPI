using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class StoreProductManager : IStoreProductService
    {
        private readonly IUnitOfWork _uow;

        public StoreProductManager(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public async Task StoreProductAdd(StoreProduct storeProduct, List<StoreDetail> storeDetails)
        {
            foreach (var storeDetail in storeDetails)
            {
                storeDetail.StoreProduct = storeProduct;
                await _uow.StoreDetailRepository.AddAsync(storeDetail);
            }

            await _uow.StoreProductRepository.AddAsync(storeProduct);

            await _uow.SaveChangeAsync();
        }
        public async Task<StoreProduct> AddAsync(StoreProduct Entity)
        {
            await _uow.StoreProductRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<StoreProduct>> GetAllAsync(Expression<Func<StoreProduct, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreProductRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<StoreProduct> GetAsync(Expression<Func<StoreProduct, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreProductRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(StoreProduct Entity)
        {
            await _uow.StoreProductRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(StoreProduct Entity)
        {
            await _uow.StoreProductRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
