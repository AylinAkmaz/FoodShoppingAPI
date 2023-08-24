using AutoMapper;
using FoodShoppingAPI.Entity.DTO.OrderDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.OrderMapper
{
    public class OrderResponseMapper : Profile
    {

        public OrderResponseMapper()
        {
            CreateMap<Order, OrderDTOResponse>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.FoodDetailName, opt =>
             {
                 opt.MapFrom(src => src.FoodDetail.Name);
             }).ForMember(dest => dest.UserName, opt =>
             {
                 opt.MapFrom(src => src.User.FirstName);
             })
             .ForMember(dest => dest.Guid, opt =>
             {
                 opt.MapFrom(src => src.Guid);
             })
             .ReverseMap();

        }
    }
}
