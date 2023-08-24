using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreCategoryDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreCategoryMapper
{
    public class StoreCategoryResponseMapper : Profile
    {
        public StoreCategoryResponseMapper()
        {
            CreateMap<StoreCategory, StoreCategoryDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  })
                  .ReverseMap();

        }


    }
}
