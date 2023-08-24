using AutoMapper;
using FoodShoppingAPI.Entity.DTO.FoodDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.FoodDetailMapper
{
    public class FoodDetailResponseMapper : Profile
    {
        public FoodDetailResponseMapper()
        {
            CreateMap<FoodDetail, FoodDetailDTOResponse>()
                 .ForMember(dest => dest.Name, opt =>
                 {
                     opt.MapFrom(src => src.Name);
                 })
                  .ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ForMember(dest => dest.Adress, opt =>
                  {
                      opt.MapFrom(src => src.Adress);
                  }).ForMember(dest => dest.DeliveryTıme, opt =>
                  {
                      opt.MapFrom(src => src.DeliveryTıme);
                  }).ForMember(dest => dest.About, opt =>
                  {
                      opt.MapFrom(src => src.About);
                  }).ForMember(dest => dest.Closing, opt =>
                  {
                      opt.MapFrom(src => src.Closing);
                  }).ForMember(dest => dest.Openning, opt =>
                  {
                      opt.MapFrom(src => src.Openning);
                  })
                   .ForMember(dest => dest.FoodCategoryName, opt =>
                   {
                       opt.MapFrom(src => src.FoodCategory.Name);
                   }).ForMember(dest => dest.RoleName, opt =>
                   {
                       opt.MapFrom(src => src.Role.Name);
                   }).ReverseMap();

        }


    }

}
