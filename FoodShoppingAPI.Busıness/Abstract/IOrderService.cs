using FoodShoppingAPI.Busıness.Abstract.BaseService;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.Busıness.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        Task OrderAdd(Order order, List<OrderDetail> orderDetail);
    }
}
