using AutoMapper;
using FoodShoppingAPI.Entity.DTO.CatetgoryDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.CategoryMapper
{
    public class CategoryResponseMapper : Profile
    {
        public CategoryResponseMapper()
        {
            CreateMap<Category, CategoryDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ForMember(dest => dest.FoodCategoryName, opt =>
                  {
                      opt.MapFrom(src => src.FoodCategory.Name);
                  }).ReverseMap();

        }
    }
}
