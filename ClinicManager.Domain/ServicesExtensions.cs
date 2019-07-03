using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicManager.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public static class ServicesExtensions
    {
        /// <summary>
        /// Коллекция сервисов
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static  IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IClinicService, ClinicService>();
            return services;
        }
        
    }
}