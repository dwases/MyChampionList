using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MyChampionList.Application.Interfaces;
using MyChampionList.Application.Services;

namespace MyChampionList.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IChampionService, ChampionService>();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            return services;
        }
    }
}
