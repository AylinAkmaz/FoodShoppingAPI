using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class StoreDetailManager : IStoreDetailService
    {
        private readonly IUnitOfWork _uow;

        public StoreDetailManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<StoreDetail> AddAsync(StoreDetail Entity)
        {
            await _uow.StoreDetailRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<StoreDetail>> GetAllAsync(Expression<Func<StoreDetail, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreDetailRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<StoreDetail> GetAsync(Expression<Func<StoreDetail, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreDetailRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(StoreDetail Entity)
        {
            await _uow.StoreDetailRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(StoreDetail Entity)
        {
            await _uow.StoreDetailRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
