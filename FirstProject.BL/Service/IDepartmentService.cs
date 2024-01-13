using FirstProject.BL.Dtos.DepartmentDto;
using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Service
{
    public interface IDepartmentService
    {
        DepartmentWithChildsViewDto GetByIdWithChilds(int id);
    }
}
