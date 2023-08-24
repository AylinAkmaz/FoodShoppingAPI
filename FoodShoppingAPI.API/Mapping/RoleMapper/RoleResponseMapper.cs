using AutoMapper;
using FoodShoppingAPI.Entity.DTO.RoleDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.RoleMapper
{
    public class RoleResponseMapper : Profile
    {
        public RoleResponseMapper()
        {
            CreateMap<Role, RoleDTOResponse>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  })
                  .ForMember(dest => dest.Guid, opt =>
                  {
                      opt.MapFrom(src => src.Guid);
                  }).ReverseMap();

        }
    }
}
