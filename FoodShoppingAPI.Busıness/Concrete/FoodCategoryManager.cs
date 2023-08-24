using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class FoodCategoryManager : IFoodCategoryService
    {
        private readonly IUnitOfWork _uow;

        public FoodCategoryManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<FoodCategory> AddAsync(FoodCategory Entity)
        {
            await _uow.FoodCategoryRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<FoodCategory>> GetAllAsync(Expression<Func<FoodCategory, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.FoodCategoryRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<FoodCategory> GetAsync(Expression<Func<FoodCategory, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.FoodCategoryRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(FoodCategory Entity)
        {
            await _uow.FoodCategoryRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(FoodCategory Entity)
        {
            await _uow.FoodCategoryRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
