using AutoMapper;
using FoodShoppingAPI.Entity.DTO.OrderDTO;
using FoodShoppingAPI.Entity.DTO.ProductDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.OrderMapper
{
    public class OrderRequestMapper : Profile
    {

        public OrderRequestMapper()
        {
            CreateMap<Order, OrderDTORequest>()

             .ForMember(dest => dest.Name, opt =>
             {
                 opt.MapFrom(src => src.Name);
             })
             .ForMember(dest => dest.FoodDetailGuid, opt =>
             {
                 opt.MapFrom(src => src.FoodDetail.Guid);
             }).ForMember(dest => dest.UserGuid, opt =>
             {
                 opt.MapFrom(src => src.User.Guid);
             })
             .ReverseMap();

        }
    }
}