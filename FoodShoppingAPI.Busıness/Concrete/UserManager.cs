using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.Busıness
{
    public class UserManager : IUserService
    {

        private readonly IUnitOfWork _uow;

        public UserManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<User> AddAsync(User Entity)
        {
            await _uow.UserRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<User>> GetAllAsync(System.Linq.Expressions.Expression<Func<User, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.UserRepository.GetAllAsync(filter, IncludeProperties);
        }

        public async Task<User> GetAsync(System.Linq.Expressions.Expression<Func<User, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.UserRepository.GetAsync(filter, IncludeProperties);
        }

        public async Task RemoveAsync(User Entity)
        {
            await _uow.UserRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(User Entity)
        {
            await _uow.UserRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
