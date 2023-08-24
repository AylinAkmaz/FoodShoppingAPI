using AutoMapper;
using FoodShoppingAPI.Entity.DTO.CatetgoryDTO;
using FoodShoppingAPI.Entity.DTO.FoodCategoryDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.CategoryMapper
{
    public class CategoryRequestMapper : Profile
    {
        public CategoryRequestMapper()
        {
            CreateMap<Category, CategoryDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.FoodCategoryGuid, opt =>
                  {
                      opt.MapFrom(src => src.FoodCategory.Guid);
                  }).ReverseMap();

        }
    }
}
