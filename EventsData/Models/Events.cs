using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventsData.Models
{
    public class Events
    {
        [Key]
        public int EventId { get; set; }

        [StringLength(50, ErrorMessage = "Title can't be longer than 50 characters")]
        public string Title { get; set; }

        public string Description { get; set; }

        public string Notes { get; set; }

        public DateTime Date { get; set; }

        public ICollection<EventType> EventType { get; set; }
    }
}