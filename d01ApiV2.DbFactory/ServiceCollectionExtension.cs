using d01ApiV2.DbFactory.Implementation;
using d01ApiV2.DbFactory.Interface;
using Microsoft.Extensions.DependencyInjection;

namespace d01ApiV2.DbFactory
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterDbFactoryService(this IServiceCollection service)
        {
            service.AddTransient<IAppDbFactory, AppDbFactory>();
            //service.AddTransient<IBaseDbFactory, LoginDbFactory>();

            return service;
        }
    }
}
