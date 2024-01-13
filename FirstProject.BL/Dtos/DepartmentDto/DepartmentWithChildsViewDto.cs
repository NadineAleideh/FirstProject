using FirstProject.BL.Dtos.TicketDto;
using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.DepartmentDto
{
    public class DepartmentWithChildsViewDto
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual IEnumerable<TicketWithinDepartmentViewDto> Tickets { get; set; } = new HashSet<TicketWithinDepartmentViewDto>();
    }
}
