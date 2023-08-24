using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFFoodCategoryRepository : EFRepository<FoodCategory>, IFoodCategoryRepository
    {
        public EFFoodCategoryRepository(DbContext context) : base(context)
        {
        }
    }

}
