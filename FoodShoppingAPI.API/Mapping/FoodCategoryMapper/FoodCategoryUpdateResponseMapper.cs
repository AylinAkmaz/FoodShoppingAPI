using AutoMapper;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.FoodCategoryMapper
{
    public class FoodCategoryUpdateResponseMapper : Profile
    {
        public FoodCategoryUpdateResponseMapper()
        {
            CreateMap<FoodCategory, FoodCategoryUpdateDTOResponse>()
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
