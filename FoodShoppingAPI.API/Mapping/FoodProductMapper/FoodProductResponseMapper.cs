using AutoMapper;
using FoodShoppingAPI.Entity.DTO.FoodProductDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.FoodProductMapper
{
    public class FoodProductResponseMapper : Profile
    {
        public FoodProductResponseMapper()
        {
            CreateMap<FoodProduct, FoodProductDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.UnitPrice, opt =>
                  {
                      opt.MapFrom(src => src.UnitPrice);
                  }).ForMember(dest => dest.Quantity, opt =>
                  {
                      opt.MapFrom(src => src.Quantity);
                  }).ForMember(dest => dest.Description, opt =>
                  {
                      opt.MapFrom(src => src.Description);
                  }).ForMember(dest => dest.FeaturedImage, opt =>
                  {
                      opt.MapFrom(src => src.FeaturedImage);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }

    }
}
