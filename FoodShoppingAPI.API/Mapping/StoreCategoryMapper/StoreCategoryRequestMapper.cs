using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreCategoryDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreCategoryMapper
{
    public class StoreCategoryRequestMapper : Profile
    {
        public StoreCategoryRequestMapper()
        {
            CreateMap<StoreCategory, StoreCategoryDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  })
                  .ReverseMap();

        }


    }
}
