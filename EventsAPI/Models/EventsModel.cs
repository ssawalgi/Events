using System;
using System.Collections.Generic;

namespace EventsAPI.Models
{
    public class EventsModel
    {
        public IEnumerable<EventsModel> Events { get; set; }

        public EventsModel(string Title, string description, string notes, DateTime dateTime )
        {

        }

    }
}
