using AutoMapper;
using FoodShoppingAPI.Entity.DTO.MenuDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.MenuMapper
{
    public class MenuResponseMapper : Profile
    {

        public MenuResponseMapper()
        {
            CreateMap<Menu, MenuDTOResponse>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             }).ForMember(dest => dest.Guid, opt =>
             {
                 opt.MapFrom(src => src.Guid);
             })
             .ForMember(dest => dest.Quantity, opt =>
             {
                 opt.MapFrom(src => src.Quantity);
             }).ForMember(dest => dest.UnitPrice, opt =>
             {
                 opt.MapFrom(src => src.UnitPrice);
             }).ForMember(dest => dest.Description, opt =>
             {
                 opt.MapFrom(src => src.Description);
             }).ForMember(dest => dest.FeaturedImage, opt =>
             {
                 opt.MapFrom(src => src.FeaturedImage);
             }).ForMember(dest => dest.FoodDetailName, opt =>
             {
                 opt.MapFrom(src => src.FoodDetail.Name);
             }).ForMember(dest => dest.FoodProductName, opt =>
             {
                 opt.MapFrom(src => src.FoodProduct.Name);
             })
             .ReverseMap();

        }
    }
}
