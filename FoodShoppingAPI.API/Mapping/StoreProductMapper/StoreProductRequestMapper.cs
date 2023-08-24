using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreProductMapper
{
    public class StoreProductRequestMapper : Profile
    {

        public StoreProductRequestMapper()
        {
            CreateMap<StoreProduct, StoreProductDTORequest>()
             .ForMember(dest => dest.Quantity, opt =>
             {
                 opt.MapFrom(src => src.Quantity);
             })
             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.Description, opt =>
             {
                 opt.MapFrom(src => src.Description);
             })
             .ForMember(dest => dest.UnitPrice, opt =>
             {
                 opt.MapFrom(src => src.UnitPrice);
             }).ForMember(dest => dest.FeaturedImage, opt =>
             {
                 opt.MapFrom(src => src.FeaturedImage);
             }).ForMember(dest => dest.StoreDetailGuid, opt =>
             {
                 opt.MapFrom(src => src.StoreDetail.Guid);
             })
             .ReverseMap();

        }


    }
}
