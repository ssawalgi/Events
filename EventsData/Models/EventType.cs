using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventsData.Models
{
    [Table("eventtype")]
    public class EventType
    {
        [Key]
        public int EventTypeId { get; set; }

        [StringLength(50, ErrorMessage = "Title can't be longer than 50 characters")]
        public string Title { get; set; }

        public string Description { get; set; }

        [ForeignKey(nameof(Events))]
        public int EventId { get; set; }
    }
}