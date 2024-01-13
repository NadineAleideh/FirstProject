using FirstProject.DAL.Data;
using FirstProject.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _appDbContext;

        public DepartmentRepository(AppDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }
        public Department GetByIdWithChilds(int id)
        {
            return _appDbContext.Departments.Include(t => t.Tickets).ThenInclude(d => d.Developers).FirstOrDefault(d => d.Id == id);
        }
    }
}
