using FoodShoppingAPI.Business.Abstract;
using FoodShoppingAPI.Busıness.Abstract;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.Business.Concrete
{
    public class StoresManager : IStoresService
    {
        private readonly IUnitOfWork _uow;

        public StoresManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Stores> AddAsync(Stores Entity)
        {
            await _uow.StoresRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Stores>> GetAllAsync(Expression<Func<Stores, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.StoresRepository.GetAllAsync(filter, IncludeProperties);

        }

        public async Task<Stores> GetAsync(Expression<Func<Stores, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.StoresRepository.GetAsync(filter, IncludeProperties);

        }

        public async Task RemoveAsync(Stores Entity)
        {
            await _uow.StoresRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Stores Entity)
        {
            await _uow.StoresRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
