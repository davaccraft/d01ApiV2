using System;
using Microsoft.Extensions.DependencyInjection;

namespace d01ApiV2.Repository
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection RegisterRepositoryService(this IServiceCollection service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service));

            // Example registrations (replace with your actual repository interfaces and implementations):
            // service.AddScoped<IMyRepository, MyRepository>();
            // service.AddScoped<IOtherRepository, OtherRepository>();

            #region Main
            //service.AddTransient<ISharedRepository, SharedRepository>();
            //service.AddTransient<IDashboardRepository, DashboardRepository>();
            #endregion Main

            #region Profile
            //service.AddTransient<IBrandRepository, BrandRepository>();
            #endregion Profile

            #region Transaction
            #endregion Transaction

            #region Setting
            #endregion Setting

            #region Report
            #endregion Report

            return service;
        }
    }
}
