using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoresDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoresMapper
{
    public class StoresResponseMapper : Profile
    {

        public StoresResponseMapper()
        {
            CreateMap<Stores, StoresDTOResponse>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.StoreCategoryName, opt =>
             {
                 opt.MapFrom(src => src.StoreCategory.Name);
             }).ForMember(dest => dest.Guid, opt =>
             {
                 opt.MapFrom(src => src.Guid);
             })
             .ReverseMap();

        }
    }
}
