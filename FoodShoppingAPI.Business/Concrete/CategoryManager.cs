﻿using FoodShoppingAPI.Business.Abstract;
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
    public class CategoryManager : ICategoryService
    {

        private readonly IUnitOfWork _uow;

        public CategoryManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Category> AddAsync(Category Entity)
        {
            await _uow.CategoryRepository.AddAsync(Entity);
            await _uow.SaveChangeAsync();
            return Entity;
        }

        public async Task<IEnumerable<Category>> GetAllAsync(Expression<Func<Category, bool>> filter = null, params string[] IncludeProperties)
        {
            return await _uow.CategoryRepository.GetAllAsync(filter, IncludeProperties);

        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> filter, params string[] IncludeProperties)
        {
            return await _uow.CategoryRepository.GetAsync(filter, IncludeProperties);

        }

        public async Task RemoveAsync(Category Entity)
        {
            await _uow.CategoryRepository.RemoveAsync(Entity);
            await _uow.SaveChangeAsync();
        }

        public async Task UpdateAsync(Category Entity)
        {
            await _uow.CategoryRepository.UpdateAsync(Entity);
            await _uow.SaveChangeAsync();
        }
    }
}
