using FirstProject.BL.Service;
using Microsoft.Extensions.DependencyInjection; // هنا طبقنا مبدأ الاكستنشن ميثود
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL
{
    public static class DependencyInjectionBL
    {
        public static void AddBussinesLogic(this IServiceCollection service)
        {
            service.AddScoped<ITicketService, TicketService>();
            service.AddScoped<IDepartmentService, DepartmentService>();
        }
    }
}
