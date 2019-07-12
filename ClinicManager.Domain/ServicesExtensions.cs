using ClinicManager.Domain.Interfaces;
using ClinicManager.Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace ClinicManager.Domain
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddDomain(this IServiceCollection services)
        {
            services.AddScoped<IPictureService, PictureService>();
            services.AddScoped<IClinicsService, ClinicService>();

            return services;
        }
    }
}