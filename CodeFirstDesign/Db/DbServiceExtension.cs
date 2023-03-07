using CodeFirstDesign.Interfaces;
using CodeFirstDesign.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CodeFirstDesign.Db
{
    public static class DbServiceExtension
    {
        public static IServiceCollection AddDatabaseService(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connectionString));

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IPlayerService , PlayerService>();

            return services;
        
        }

    }
}
    
