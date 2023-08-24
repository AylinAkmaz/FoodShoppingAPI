using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFOrderRepository : EFRepository<Order>, IOrderRepository
    {
        public EFOrderRepository(DbContext context) : base(context)
        {
        }
    }

}
