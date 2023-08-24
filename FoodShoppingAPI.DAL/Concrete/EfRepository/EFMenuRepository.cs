using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFMenuRepository : EFRepository<Menu>, IMenuRepository
    {
        public EFMenuRepository(DbContext context) : base(context)
        {
        }
    }

}
