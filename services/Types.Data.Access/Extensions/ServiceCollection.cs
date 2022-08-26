using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types.Data.Access.Abstractions;
using Types.Data.Access.Concretes;
using Types.Entities;

namespace Types.Data.Access.Extensions
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddDataServices(this IServiceCollection services)
        {
            services.AddSingleton<IAdminService, AdminService>();
            services.AddSingleton<IDutyService, DutyService>();

            return services;
        }
    }
}