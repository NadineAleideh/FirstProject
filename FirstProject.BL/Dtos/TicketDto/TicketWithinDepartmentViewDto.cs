using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.TicketDto
{
    public class TicketWithinDepartmentViewDto
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int DevelopersCount { get; set; }
    }
}
