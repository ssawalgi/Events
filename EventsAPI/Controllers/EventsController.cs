using EventsServices.Events;
using Microsoft.AspNetCore.Mvc;

namespace EventsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private IEventsService eventsService;

        public  EventsController( IEventsService  eventsService )
        {
            this.eventsService = eventsService;
        }
    }
}