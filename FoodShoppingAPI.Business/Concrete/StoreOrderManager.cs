using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Business.Concrete
{
    public class StoreOrderManager : IStoreOrderService
    {
        private readonly IUnitOfWork _uow;

        public StoreOrderManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<StoreOrder> AddAsync(StoreOrder Entity)
        {
            await _uow.StoreOrderRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<StoreOrder>> GetAllAsync(Expression<Func<StoreOrder, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreOrderRepository.GetAllAsync(filter, IncludeProperties);

        }

        public async Task<StoreOrder> GetAsync(Expression<Func<StoreOrder, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreOrderRepository.GetAsync(filter, IncludeProperties);

        }

        public async Task RemoveAsync(StoreOrder Entity)
        {
            await _uow.StoreOrderRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(StoreOrder Entity)
        {
            await _uow.StoreOrderRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
