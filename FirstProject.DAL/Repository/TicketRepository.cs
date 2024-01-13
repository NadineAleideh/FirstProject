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
    public class TicketRepository : ITicketRepository
    {

        private readonly AppDbContext _appDbContext;
        public TicketRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void Add(Ticket entity)
        {
            _appDbContext.Add(entity);
        }

        public void Delete(Ticket entity)
        {
            _appDbContext.Remove(entity);
        }

        public IQueryable<Ticket> GetAll()
        {

            return _appDbContext.Tickets;
        }

        public Ticket GetByID(int id)
        {
            return _appDbContext.Tickets.Find(id);
        }

        public void SaveChange()
        {
            _appDbContext.SaveChanges();
        }

        public void update(Ticket entity)
        {
            //_appDbContext.Update(entity);
        }
        public void updateWithDevelopers(Ticket entity)
        {
            //_appDbContext.Update(entity);
        }

    }
}
