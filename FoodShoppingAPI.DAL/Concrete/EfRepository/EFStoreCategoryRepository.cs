using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFStoreCategoryRepository : EFRepository<StoreCategory>, IStoreCategoryRepository
    {
        public EFStoreCategoryRepository(DbContext context) : base(context)
        {
        }
    }

}
