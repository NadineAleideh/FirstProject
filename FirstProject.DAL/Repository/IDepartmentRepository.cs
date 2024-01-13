using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL.Repository
{
    public interface IDepartmentRepository
    {
        Department GetByIdWithChilds(int id);
    }
}
