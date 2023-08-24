using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreOrderDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreOrderDetailMapper
{
    public class StoreOrderDetailResponseMapper : Profile
    {
        public StoreOrderDetailResponseMapper()
        {
            CreateMap<StoreOrderDetail, StoreOrderDetailDTOResponse>()
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
                  }).ForMember(dest => dest.StoreOrderName, opt =>
                  {
                      opt.MapFrom(src => src.StoreOrder.Name);
                  }).ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }
    }
}
