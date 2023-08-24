using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreOrderDetailMapper
{
    public class StoreOrderDetailUpdateResponse : Profile
    {
        public StoreOrderDetailUpdateResponse()
        {
            CreateMap<StoreOrderDetail, StoreOrderDetailDTOUpdateResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.Quantity, opt =>
                  {
                      opt.MapFrom(src => src.Quantity);
                  }).ForMember(dest => dest.Discount, opt =>
                  {
                      opt.MapFrom(src => src.Discount);
                  }).ForMember(dest => dest.UnitPrice, opt =>
                  {
                      opt.MapFrom(src => src.UnitPrice);
                  }).ForMember(dest => dest.StoreOrderGuid, opt =>
                  {
                      opt.MapFrom(src => src.StoreOrder.Guid);
                  }).ReverseMap();

        }
    }
}
