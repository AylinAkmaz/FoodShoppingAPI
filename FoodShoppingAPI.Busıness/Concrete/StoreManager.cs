using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class StoreManager : IStoreService
    {
        private readonly IUnitOfWork _uow;

        public StoreManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Store> AddAsync(Store Entity)
        {
            await _uow.StoreRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Store>> GetAllAsync(Expression<Func<Store, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<Store> GetAsync(Expression<Func<Store, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(Store Entity)
        {
            await _uow.StoreRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Store Entity)
        {
            await _uow.StoreRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }

}
