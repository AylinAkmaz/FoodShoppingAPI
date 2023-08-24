using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreDetailMapper
{
    public class StoreDetailUpdateResponseMapper : Profile
    {
        public StoreDetailUpdateResponseMapper()
        {
            CreateMap<StoreDetail, StoreDetailDTOUpdateResponse>()
                 .ForMember(dest => dest.Name, opt =>
                 {
                     opt.MapFrom(src => src.Name);
                 })
                  .ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ForMember(dest => dest.StoreCategoryName, opt =>
                  {
                      opt.MapFrom(src => src.StoreCategory.Name);
                  }).ReverseMap();

        }
    }
}
