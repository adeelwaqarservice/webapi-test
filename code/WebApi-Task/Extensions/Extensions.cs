using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Task.Data;
using WebApi_Task.Mock;
using WebApi_Task.Models.Interfaces;

namespace WebApi_Task.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddWebRepository(this IServiceCollection services, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                services.AddSingleton<IWebRepository, MockWebRepository>();
            }
            else
            {
                services.AddSingleton<IWebRepository, WebRepository>();
            }
            return services;
        }
    }
}
