using AutoMapper;
using FoodShoppingAPI.Entity.DTO.ProductDTO;
using FoodShoppingAPI.Entity.DTO.StoresDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.ProductMapper
{
    public class ProductRequestMapper : Profile
    {

        public ProductRequestMapper()
        {
            CreateMap<Product, ProductDTORequest>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.UnitPrice, opt =>
             {
                 opt.MapFrom(src => src.UnitPrice);
             }).ForMember(dest => dest.Description, opt =>
             {
                 opt.MapFrom(src => src.Description);
             }).ForMember(dest => dest.FeaturedImage, opt =>
             {
                 opt.MapFrom(src => src.FeaturedImage);
             }).ForMember(dest => dest.Quantity, opt =>
             {
                 opt.MapFrom(src => src.Quantity);
             }).ForMember(dest => dest.FoodDetailGuid, opt =>
             {
                 opt.MapFrom(src => src.FoodDetail.Guid);
             })
             .ReverseMap();

        }
    }
}
