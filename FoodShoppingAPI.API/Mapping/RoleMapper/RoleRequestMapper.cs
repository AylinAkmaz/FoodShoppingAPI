using AutoMapper;
using FoodShoppingAPI.Entity.DTO.RoleDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.RoleMapper
{
    public class RoleRequestMapper : Profile
    {
        public RoleRequestMapper()
        {
            CreateMap<Role, RoleDTORequest>()
                  .ForMember(dest => dest.Name, opt =>
                  {
                      opt.MapFrom(src => src.Name);
                  }).ReverseMap();

        }
    }
}
