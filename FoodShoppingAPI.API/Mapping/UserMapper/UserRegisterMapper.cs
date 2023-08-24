﻿using AutoMapper;
using FoodShoppingAPI.Entity.DTO.UserDTO;
using FoodShoppingAPI.Entity.Poco;

namespace FoodShoppingAPI.API.Mapping.UserMapper
{
    public class UserRegisterMapper : Profile
    {
        public UserRegisterMapper()
        {
            CreateMap<User, UserDTORequest>()
                .ForMember(dest => dest.FirstName, opt =>
                {
                    opt.MapFrom(src => src.FirstName);
                })
             .ForMember(dest => dest.LastName, opt =>
             {
                 opt.MapFrom(src => src.LastName);
             })
              .ForMember(dest => dest.UserName, opt =>
              {
                  opt.MapFrom(src => src.Username);
              })
               .ForMember(dest => dest.Password, opt =>
               {
                   opt.MapFrom(src => src.Password);
               })
               .ForMember(dest => dest.PhoneNumber, opt =>
               {
                   opt.MapFrom(src => src.PhoneNumber);
               })
               .ForMember(dest => dest.Email, opt =>
               {
                   opt.MapFrom(src => src.Email);
               })
               .ForMember(dest => dest.Adress, opt =>
               {
                   opt.MapFrom(src => src.Adress);
               }).ReverseMap();

        }

    }
}
