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
    public class StoreOrderDetailManager:IStoreOrderDetailService
    {
        private readonly IUnitOfWork _uow;

        public StoreOrderDetailManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<StoreOrderDetail> AddAsync(StoreOrderDetail Entity)
        {
            await _uow.StoreOrderDetailRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<StoreOrderDetail>> GetAllAsync(Expression<Func<StoreOrderDetail, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoreOrderDetailRepository.GetAllAsync(filter, IncludeProperties);

        }

        public async Task<StoreOrderDetail> GetAsync(Expression<Func<StoreOrderDetail, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoreOrderDetailRepository.GetAsync(filter, IncludeProperties);

        }

        public async Task RemoveAsync(StoreOrderDetail Entity)
        {
            await _uow.StoreOrderDetailRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(StoreOrderDetail Entity)
        {
            await _uow.StoreOrderDetailRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
