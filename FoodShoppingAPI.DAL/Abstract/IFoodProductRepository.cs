using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShoppingAPI.DAL.Abstract.DataManagment;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.DAL.Abstract
{
    public interface IFoodProductRepository:IRepository<FoodProduct>
    {
    }
}
