using AutoMapper;
using FoodShoppingAPI.Entity.DTO.MenuDTO;
using FoodShoppingAPI.Entity.DTO.OrderDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.MenuMapper
{
    public class MenuRequestMapper : Profile
    {

        public MenuRequestMapper()
        {
            CreateMap<Menu, MenuDTORequest>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
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
             }).ForMember(dest => dest.FoodDetailGUID, opt =>
             {
                 opt.MapFrom(src => src.FoodDetail.Guid);
             }).ForMember(dest => dest.FoodProductGuid, opt =>
             {
                 opt.MapFrom(src => src.FoodProduct.Guid);
             })
             .ReverseMap();

        }
    }
}
