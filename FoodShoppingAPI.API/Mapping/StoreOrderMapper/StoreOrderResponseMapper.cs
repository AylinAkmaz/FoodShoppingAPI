using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreOrderDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreOrderMapper
{
    public class StoreOrderResponseMapper : Profile
    {
        public StoreOrderResponseMapper()
        {
            CreateMap<StoreOrder, StoreOrderDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.StoreProductName, opt =>
                  {
                      opt.MapFrom(src => src.StoreProduct.Name);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }
    }
}
