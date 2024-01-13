using FirstProject.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.DAL.Repository
{
    public interface ITicketRepository
    {
        IQueryable<Ticket> GetAll();
        Ticket GetByID(int id);
        void update(Ticket entity);
        void updateWithDevelopers(Ticket entity);
        void Add(Ticket entity);
        void Delete(Ticket entity);
        void SaveChange();
    }
}
