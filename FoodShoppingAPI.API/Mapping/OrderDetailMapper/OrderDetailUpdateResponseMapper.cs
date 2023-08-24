using AutoMapper;
using FoodShoppingAPI.Entity.DTO.OrderDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.OrderDetailMapper
{
    public class OrderDetailUpdateResponseMapper : Profile
    {

        public OrderDetailUpdateResponseMapper()
        {
            CreateMap<OrderDetail, OrderDetailDTOUpdateResponse>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.Quantity, opt =>
             {
                 opt.MapFrom(src => src.Quantity);
             }).ForMember(dest => dest.Discount, opt =>
             {
                 opt.MapFrom(src => src.Discount);
             }).ForMember(dest => dest.UnitPrice, opt =>
             {
                 opt.MapFrom(src => src.UnitPrice);
             }).ForMember(dest => dest.OrderGuid, opt =>
             {
                 opt.MapFrom(src => src.Order.Guid);
             })
             .ReverseMap();

        }
    }
}
