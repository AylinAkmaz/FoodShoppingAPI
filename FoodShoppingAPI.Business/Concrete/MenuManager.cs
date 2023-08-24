using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System.Linq.Expressions;

namespace FoodShoppingAPI.Busıness
{
    public class MenuManager : IMenuService
    {
        private readonly IUnitOfWork _uow;

        public MenuManager(IUnitOfWork uow)
        {
            _uow = uow;
        }


        public async Task<Menu> AddAsync(Menu Entity)
        {
            await _uow.MenuRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Menu>> GetAllAsync(Expression<Func<Menu, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.MenuRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<Menu> GetAsync(Expression<Func<Menu, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.MenuRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(Menu Entity)
        {
            await _uow.MenuRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Menu Entity)
        {
            await _uow.MenuRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
