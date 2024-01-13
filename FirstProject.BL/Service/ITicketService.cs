using FirstProject.BL.Dtos.TicketDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject.BL.Service
{
    public interface ITicketService
    {
        IEnumerable<TicketViewDto> GetAll(int take, int skip);
        TicketViewDto GetByID(int id);
        void update(TicketUpdateDto entity);
        void updateWithDevelopers(TicketUpdateWithDevelopersDto entity);
        void Add(TicketAddDto entity);
        void Delete(TicketViewDto entity);
        void SaveChange();
    }
}
