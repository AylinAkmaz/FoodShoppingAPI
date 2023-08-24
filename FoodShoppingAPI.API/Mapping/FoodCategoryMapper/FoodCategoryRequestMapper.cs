using AutoMapper;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;
using FoodShoppingAPI.Entity.DTO.RoleDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.FoodCategoryMapper
{
    public class FoodCategoryRequestMapper : Profile
    {
        public FoodCategoryRequestMapper()
        {
            CreateMap<FoodCategory, FoodCategoryDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ReverseMap();

        }
    }
}
