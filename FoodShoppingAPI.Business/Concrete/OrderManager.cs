using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class OrderManager : IOrderService
    {
        private readonly IUnitOfWork _uow;
        public OrderManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Order> AddAsync(Order Entity)
        {
            await _uow.OrderRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Order>> GetAllAsync(Expression<Func<Order, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.OrderRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<Order> GetAsync(Expression<Func<Order, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.OrderRepository.GetAsync(filter, IncludeProperties);
        }

        

        public async Task RemoveAsync(Order Entity)
        {
            await _uow.OrderRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Order Entity)
        {
            await _uow.OrderRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
