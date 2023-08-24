using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IUnitOfWork _uow;

        public OrderDetailManager(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<OrderDetail> AddAsync(OrderDetail Entity)
        {
            await _uow.OrderDetailRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<OrderDetail>> GetAllAsync(Expression<Func<OrderDetail, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.OrderDetailRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<OrderDetail> GetAsync(Expression<Func<OrderDetail, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.OrderDetailRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(OrderDetail Entity)
        {
            await _uow.OrderDetailRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(OrderDetail Entity)
        {
            await _uow.OrderDetailRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
