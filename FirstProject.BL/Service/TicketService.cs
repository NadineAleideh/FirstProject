using FirstProject.BL.Dtos.TicketDto;
using FirstProject.DAL.Models;
using FirstProject.BL.Service;
using FirstProject.DAL.Repository;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.BL.Service
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketService(ITicketRepository ticketRepository)
        {
            this._ticketRepository = ticketRepository;
        }

        public void Add(TicketAddDto entity)
        {
            var ticketModel = new Ticket()
            {
                Title = entity.Title,
                Description = entity.Description

            };

            _ticketRepository.Add(ticketModel);
        }


        public void Delete(TicketViewDto entity)
        {
            var ticketModel = new Ticket()
            {
                Title = entity.Title,
                Description = entity.Description
            };

            _ticketRepository.Delete(ticketModel);
        }


        public IEnumerable<TicketViewDto> GetAll(int skip, int take)
        {
            var ticketsToView = _ticketRepository.GetAll().Select(t => new TicketViewDto()
            {
                Id = t.Id,
                Description = t.Description,
                Title = t.Title
            }).Skip(skip).Take(take).ToList();

            return ticketsToView;
        }


        public TicketViewDto GetByID(int id)
        {
            var ticketModel = _ticketRepository.GetByID(id);

            var ticketToView = new TicketViewDto()
            {
                Id = ticketModel.Id,
                Title = ticketModel.Title,
                Description = ticketModel.Description
            };

            return ticketToView;
        }

        public void SaveChange()
        {
            _ticketRepository.SaveChange();
        }



        public void update(TicketUpdateDto entity)
        {
            var ticket = _ticketRepository.GetByID(entity.Id);
            ticket.Id = entity.Id;
            ticket.Title = entity.Title;
            ticket.Description = entity.Description;



        }

        public void updateWithDevelopers(TicketUpdateWithDevelopersDto entity)
        {
            var ticketToUpdate = new Ticket()
            {
                Id = entity.Id,
                Title = entity.Title,
                Description = entity.Description,
                Developers = entity.Developers

            };
        }

    }
}
