using AutoMapper;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;
using FoodShoppingAPI.Entity.DTO.RoleDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.FoodCategoryMapper
{
    public class FoodCategoryResponseMapper : Profile
    {
        public FoodCategoryResponseMapper()
        {
            CreateMap<FoodCategory, FoodCategoryDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  })
                  .ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }
    }
}
