using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using automapper_autofac.Models;
using automapper_autofac.Models.ViewModel;
using AutoMapper;

namespace automapper_autofac.Common.AutoMap
{
    public class AutoMapperConfig
    {
        public static IMapper Mapper;
        public static void ConfigureAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });

            Mapper = config.CreateMapper();            
        }
    }

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<UserModel, UserViewModel>()
                .ForMember(x => x.UserName, opt => opt.MapFrom(y => y.FirstName + " " + y.MiddleName + " " + y.LastName))
                .ForMember(x => x.UserAddress, opt => opt.MapFrom(y => y.AddressLine1 + " " + y.AddressLine2 + " " + y.PinCode));
        }
    }
}