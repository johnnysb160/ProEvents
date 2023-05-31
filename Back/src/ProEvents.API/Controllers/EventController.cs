using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEvents.API.Models;

namespace ProEvents.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
      public IEnumerable<Event> _event = new Event[]{
        new Event{
                EventId = 1,
                EventDate = DateTime.UtcNow.AddDays(2).ToString(),
                Local = "Santo André",
                Theme = "Colorfull",
                ImageUrl = "www.eventyear.com",
                CountPerson = 20,
                Lot = "10"
            },
        new Event{
                EventId = 2,
                EventDate = DateTime.UtcNow.AddDays(230).ToString(),
                Local = "São Caetano",
                Theme = "BlackDay",
                ImageUrl = "www.eventblack.com",
                CountPerson = 30,
                Lot = "12"
            }
      };

        public EventController()
        {
        }



        [HttpGet]
        public IEnumerable<Event> Get()
        {
            return _event;
        }

        [HttpGet("{id}")]
        public IEnumerable<Event> GetById(int id)
        {
            return _event.Where(x => x.EventId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "Exemplo com Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo com Put com o id: {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo com Delete com o id: {id}";
        }
    }
}
