using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.Business.Concrete
{
    public class FoodProductManager : IFoodProductService
    {
        private readonly IUnitOfWork _uow;

        public FoodProductManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<FoodProduct> AddAsync(FoodProduct Entity)
        {
            await _uow.FoodProductRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<FoodProduct>> GetAllAsync(Expression<Func<FoodProduct, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.FoodProductRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<FoodProduct> GetAsync(Expression<Func<FoodProduct, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.FoodProductRepository.GetAsync(filter, IncludeProperties);

        }

        public async Task RemoveAsync(FoodProduct Entity)
        {
            await _uow.FoodProductRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(FoodProduct Entity)
        {
            await _uow.FoodProductRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}

