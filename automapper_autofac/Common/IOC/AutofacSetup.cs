using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using automapper_autofac.Common.AutoMap;
using automapper_autofac.Controllers;
using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;

namespace automapper_autofac.Common.IOC
{
    public class AutofacSetup
    {
        private static IContainer container { get; set; }
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();            

            builder.RegisterInstance(AutoMapperConfig.Mapper)
                .As<IMapper>()
                .SingleInstance();

            builder.RegisterType<HomeController>();  
            container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}