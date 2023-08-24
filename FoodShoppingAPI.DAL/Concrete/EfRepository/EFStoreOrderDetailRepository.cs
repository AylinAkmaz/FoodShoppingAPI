using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFStoreOrderDetailRepository : EFRepository<StoreOrderDetail>, IStoreOrderDetailRepository
    {
        public EFStoreOrderDetailRepository(DbContext context) : base(context)
        {
        }
    }
}
