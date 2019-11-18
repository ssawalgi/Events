using System;
using System.Collections.Generic;
using System.Linq;
using EventsAPI.Models;
using EventsData;

namespace EventsAPI.Services
{
    public class EventsService: IEventsService
    {
        private readonly EventContext dbcontext;

         public EventsService(EventContext context)
        {
            if (this.dbcontext != null)
            {
                this.dbcontext = context;
            }
        }

        public List<EventsModel> GetAllEvents()
        {
            IQueryable<EventsModel> query = (System.Linq.IQueryable<EventsAPI.Models.EventsModel>)dbcontext.Events.ToAsyncEnumerable();
            return query.ToList();
        }

        public EventsModel GetEvent(int eventId)
        {
            IQueryable<EventsModel> query = (System.Linq.IQueryable<EventsAPI.Models.EventsModel>)dbcontext.Events.Find(eventId);
            return (EventsAPI.Models.EventsModel)query;
        }
    }
}
