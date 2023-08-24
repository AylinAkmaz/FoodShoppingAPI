using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFFoodDetailRepository : EFRepository<FoodDetail>, IFoodDetailRepository
    {
        public EFFoodDetailRepository(DbContext context) : base(context)
        {
        }
    }

}
