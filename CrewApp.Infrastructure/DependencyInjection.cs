using CrewApp.Domain.Interfaces;
using CrewApp.Infrastructure.Data;
using CrewApp.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrewApp.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureDI(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-DB6VEGP\\SQLEXPRESS ; DataBase=CrewApiDb; Trusted_Connection=True; TrustServerCertificate=true; MultipleActiveResultSets=True;");

            });

            services.AddScoped<ICrewRepository, CrewRepository>();

            return services;
        }
    }
}
