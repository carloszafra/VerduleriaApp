using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerduleriaApp.Data.Context;

namespace VerduleriaApp.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            string connString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<DBcontext>(options =>
            {
                options.UseMySql(connString, ServerVersion.AutoDetect(connString));
            });
        }
    }
}
