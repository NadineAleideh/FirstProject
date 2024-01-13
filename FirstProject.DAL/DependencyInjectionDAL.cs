using FirstProject.DAL.Data;
using FirstProject.DAL.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL
{
    public static class DependencyInjectionDAL
    {

        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            services.AddScoped<ITicketRepository, TicketRepository>();



        }

    }
}
