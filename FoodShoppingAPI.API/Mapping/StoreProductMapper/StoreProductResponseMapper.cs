using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreProductDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreProductMapper
{
    public class StoreProductResponseMapper : Profile
    {

        public StoreProductResponseMapper()
        {
            CreateMap<StoreProduct, StoreProductDTOResponse>()
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
             })
              .ForMember(dest => dest.Guid, opt =>
              {
                  opt.MapFrom(src => src.Guid);
              }).ForMember(dest => dest.FeaturedImage, opt =>
              {
                  opt.MapFrom(src => src.FeaturedImage);
              }).ReverseMap();

        }


    }
}
