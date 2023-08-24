using FoodShoppingAPI.Busıness.Abstract.BaseService;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.Busıness.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        Task ProductAdd(Product product, List<Menu> menu);
    }
}
