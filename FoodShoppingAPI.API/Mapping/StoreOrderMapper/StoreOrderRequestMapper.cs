using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.DTO.StoreOrderDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreOrderMapper
{
    public class StoreOrderRequestMapper : Profile
    {
        public StoreOrderRequestMapper()
        {
            CreateMap<StoreOrder, StoreOrderDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.StoreProductGuid, opt =>
                  {
                      opt.MapFrom(src => src.StoreProduct.Guid);
                  }).ReverseMap();

        }
    }
}
