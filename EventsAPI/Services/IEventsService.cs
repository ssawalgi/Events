using System.Collections.Generic;
using EventsAPI.Models;

namespace EventsAPI.Services
{
    public interface IEventsService
    {
        List<EventsModel> GetAllEvents();
        EventsModel GetEvent(int productId);
    }
}
