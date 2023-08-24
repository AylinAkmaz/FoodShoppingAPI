using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class RoleManager : IRoleService
    {
        private readonly IUnitOfWork _uow;

        public RoleManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Role> AddAsync(Role Entity)
        {
            await _uow.RoleRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Role>> GetAllAsync(Expression<Func<Role, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.RoleRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<Role> GetAsync(Expression<Func<Role, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.RoleRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(Role Entity)
        {
            await _uow.RoleRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();

        }

        public async Task UpdateAsync(Role Entity)
        {
            await _uow.RoleRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }

}
