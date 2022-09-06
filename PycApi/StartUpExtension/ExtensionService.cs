using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PycApi.Mapper;
using PycApi.Service;

namespace PycApi.StartUpExtension
{
    public static class ExtensionService
    {
        public static void AddServices(this IServiceCollection services)
        {
            // services 
            services.AddScoped<IAccountService, AccountService>();
            services.AddScoped<ITokenService, TokenService>();

            // mapper
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new MappingProfile());
            });
            services.AddSingleton(mapperConfig.CreateMapper());
        }
    }
}
