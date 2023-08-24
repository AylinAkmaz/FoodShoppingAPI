using FoodShoppingAPI.DAL.Abstract;
using FoodShoppingAPI.DAL.Concrete.EfRepository.Base;
using FoodShoppingAPI.Entity.Poco;
using Microsoft.EntityFrameworkCore;

public class EFStoreProductRepository : EFRepository<StoreProduct>, IStoreProductRepository
{
    public EFStoreProductRepository(DbContext context) : base(context)
    {
    }
}
