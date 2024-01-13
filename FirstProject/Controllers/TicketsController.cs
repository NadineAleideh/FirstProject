using FirstProject.BL.Dtos.TicketDto;
using FirstProject.BL.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace FirstProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            this._ticketService = ticketService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_ticketService.GetAll(1, 3));// status code 200
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_ticketService.GetByID(id));
        }

        [HttpPost]
        public IActionResult Add(TicketAddDto ticketAddDto)
        {
            _ticketService.Add(ticketAddDto);

            _ticketService.SaveChange();

            return Ok("Ticket Added Succesfully");


        }

        [HttpDelete]
        public IActionResult Delete(TicketViewDto ticketViewDto)
        {
            _ticketService.Delete(ticketViewDto);

            return NoContent(); // status code 204
        }

        [HttpPut("Edit")]
        //[Route("{id}")]
        public IActionResult Edit(TicketUpdateDto ticketUpdateDto)
        {
            //if (id != ticketUpdateDto.Id)
            //{
            //    return BadRequest();
            //}


            _ticketService.update(ticketUpdateDto);
            _ticketService.SaveChange();
            return Ok("Ticket Updated Succesfully");
        }

        [HttpPut("EditWithDevelopers")]
        public IActionResult EditWithDevelopers(TicketUpdateWithDevelopersDto ticketUpdateWithDevelopersDto)
        {
            _ticketService.updateWithDevelopers(ticketUpdateWithDevelopersDto);

            return Ok("Ticket Updated Succesfully");
        }


    }
}
