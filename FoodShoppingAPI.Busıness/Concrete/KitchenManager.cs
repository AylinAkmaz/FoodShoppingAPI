using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class KitchenManager : IKitchenService
    {
        private readonly IUnitOfWork _uow;

        public KitchenManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Kitchen> AddAsync(Kitchen Entity)
        {
            await _uow.KitchenRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Kitchen>> GetAllAsync(Expression<Func<Kitchen, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.KitchenRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<Kitchen> GetAsync(Expression<Func<Kitchen, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.KitchenRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(Kitchen Entity)
        {
            await _uow.KitchenRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Kitchen Entity)
        {
            await _uow.KitchenRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
