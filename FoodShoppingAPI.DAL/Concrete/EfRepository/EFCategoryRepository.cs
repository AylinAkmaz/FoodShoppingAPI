using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShoppingAPI.DAL.Concrete.EfRepository
{
    public class EFCategoryRepository : EFRepository<Category>, ICategoryRepository
    {
        public EFCategoryRepository(DbContext context) : base(context)
        {
        }
    }
}
