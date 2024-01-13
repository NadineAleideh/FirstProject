using FirstProject.BL.Dtos.DepartmentDto;
using FirstProject.BL.Dtos.TicketDto;
using FirstProject.DAL.Models;
using FirstProject.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Service
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public DepartmentWithChildsViewDto GetByIdWithChilds(int id)
        {
            var departmentModel = _departmentRepository.GetByIdWithChilds(id);

            var departmentToView = new DepartmentWithChildsViewDto()
            {
                Id = departmentModel.Id,
                Name = departmentModel.Name,
                Tickets = departmentModel.Tickets.Select(t => new TicketWithinDepartmentViewDto
                {
                    Id = t.Id,
                    Description = t.Description,
                    DevelopersCount = t.Developers.Count()

                })
            };

            return departmentToView;
        }
    }
}
