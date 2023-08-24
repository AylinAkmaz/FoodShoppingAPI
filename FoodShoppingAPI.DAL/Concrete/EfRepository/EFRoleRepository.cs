using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFRoleRepository : EFRepository<Role>, IRoleRepository
    {
        public EFRoleRepository(DbContext context) : base(context)
        {
        }
    }

}
