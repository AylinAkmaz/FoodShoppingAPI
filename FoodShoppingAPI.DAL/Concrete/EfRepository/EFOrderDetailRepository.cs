using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFOrderDetailRepository : EFRepository<OrderDetail>, IOrderDetailRepository
    {
        public EFOrderDetailRepository(DbContext context) : base(context)
        {
        }
    }

}
