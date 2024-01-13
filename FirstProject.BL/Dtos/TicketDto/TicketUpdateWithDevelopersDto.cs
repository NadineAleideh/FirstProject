using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Dtos.TicketDto
{
    public class TicketUpdateWithDevelopersDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public virtual IEnumerable<Developer> Developers { get; set; } = new HashSet<Developer>();
    }
}
