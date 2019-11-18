
using System.Collections.Generic;
using System.Threading.Tasks;
using EventsAPI.Models;
using EventsAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsService eventsService;

        public EventsController( IEventsService service)
        {
            this.eventsService = service;
        }

        // GET: api/Events
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventsModel>>> GetEvents()
        {
            return eventsService.GetAllEvents();
        }

        // GET: api/Events/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventsModel>> GetEventItem(int id)
        {
            EventsModel eventItem = eventsService.GetEvent(id);

            if (eventItem == null)
            {
                return NotFound();
            }

            return eventItem;
        }
    }
}