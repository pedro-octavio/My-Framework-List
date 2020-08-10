using Autofac;
using MyFrameworkList.Application;
using MyFrameworkList.Application.Interfaces;
using MyFrameworkList.Application.Interfaces.Mappers;
using MyFrameworkList.Application.Mappers;
using MyFrameworkList.Domain.Core.Interfaces.Repositories;
using MyFrameworkList.Domain.Core.Interfaces.Services;
using MyFrameworkList.Domain.Services.Services;
using MyFrameworkList.Infra.Data.Repositories;

namespace MyFrameworkList.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceLanguage>().As<IApplicationServiceLanguage>();
            builder.RegisterType<ApplicationServiceFramework>().As<IApplicationServiceFramework>();
            builder.RegisterType<ApplicationServiceFrameworkLanguage>().As<IApplicationServiceFrameworkLanguage>();

            builder.RegisterType<ServiceLanguage>().As<IServiceLanguage>();
            builder.RegisterType<ServiceFramework>().As<IServiceFramework>();
            builder.RegisterType<ServiceFrameworkLanguage>().As<IServiceFrameworkLanguage>();

            builder.RegisterType<RepositoryLanguage>().As<IRepositoryLanguage>();
            builder.RegisterType<RepositoryFramework>().As<IRepositoryFramework>();
            builder.RegisterType<RepositoryFrameworkLanguage>().As<IRepositoryFrameworkLanguage>();

            builder.RegisterType<MapperLanguage>().As<IMapperLanguage>();
            builder.RegisterType<MapperFramework>().As<IMapperFramework>();
            builder.RegisterType<MapperFrameworkLanguage>().As<IMapperFrameworkLanguage>();
        }
    }
}
