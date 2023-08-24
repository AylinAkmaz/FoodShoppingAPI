using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class StoreCategoryManager : IStoreCategoryService
    {
        private readonly IUnitOfWork _uow;

        public StoreCategoryManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<StoreCategory> AddAsync(StoreCategory Entity)
        {
            await _uow.StoreCategoryRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<StoreCategory>> GetAllAsync(Expression<Func<StoreCategory, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreCategoryRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<StoreCategory> GetAsync(Expression<Func<StoreCategory, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreCategoryRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(StoreCategory Entity)
        {
            await _uow.StoreCategoryRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(StoreCategory Entity)
        {
            await _uow.StoreCategoryRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }

}
