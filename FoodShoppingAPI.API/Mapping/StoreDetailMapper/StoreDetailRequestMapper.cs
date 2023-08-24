
using AutoMapper;
using FoodShoppingAPI.Entity.DTO.StoreDetailDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.StoreDetailMapper
{
    public class StoreDetailRequestMapper:Profile
    {
        public StoreDetailRequestMapper()
        {
            CreateMap<StoreDetail, StoreDetailDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ForMember(dest => dest.StoreCategoryGuid, opt =>
                  {
                      opt.MapFrom(src => src.StoreCategory.Guid);
                  }).ReverseMap();

        }
    }
}
