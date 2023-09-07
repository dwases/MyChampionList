using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MyChampionList.Domain.Interfaces;

namespace MyChampionList.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IChampionRepository, IChampionRepository>();
            //tu będzie jeszcze : services.AddTransient<IUserRepository, IUserRepository>();
            //
            return services;
        }
    }
}
