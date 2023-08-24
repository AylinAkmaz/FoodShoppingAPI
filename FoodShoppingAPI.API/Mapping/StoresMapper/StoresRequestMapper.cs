using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.DTO.StoresDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoresMapper
{
    public class StoresRequestMapper : Profile
    {

        public StoresRequestMapper()
        {
            CreateMap<Stores, StoresDTORequest>()
             
             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.StoreCategoryGuid, opt =>
             {
                 opt.MapFrom(src => src.StoreCategory.Guid);
             })
             .ReverseMap();

        }
    }
}
