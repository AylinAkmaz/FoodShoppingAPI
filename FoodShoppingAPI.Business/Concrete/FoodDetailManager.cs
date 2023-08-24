using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class FoodDetailManager : IFoodDetailService
    {
        private readonly IUnitOfWork _uow;

        public FoodDetailManager(IUnitOfWork uow)
        {
            _uow = uow;
        }



        public async Task<FoodDetail> AddAsync(FoodDetail Entity)
        {
            await _uow.FoodDetailRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<FoodDetail>> GetAllAsync(Expression<Func<FoodDetail, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.FoodDetailRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<FoodDetail> GetAsync(Expression<Func<FoodDetail, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.FoodDetailRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(FoodDetail Entity)
        {
            await _uow.FoodDetailRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(FoodDetail Entity)
        {
            await _uow.FoodDetailRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
