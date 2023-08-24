using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreOrderDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreOrderMapper
{
    public class StoreOrderUpdateResponseMapper : Profile
    {
        public StoreOrderUpdateResponseMapper()
        {
            CreateMap<StoreOrder, StoreOrderDTOUpdateResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.StoreProductGuid, opt =>
                  {
                      opt.MapFrom(src => src.StoreProduct.Guid);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }
    }
}
