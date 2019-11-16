using EventsData.Models;
using Microsoft.EntityFrameworkCore;

namespace EventsData
{
    public class EventContext : DbContext
    {
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        public DbSet<Events> Events { get; set; }

        public DbSet<EventType> EventType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost,1401; Database=EventDB;User=SA; Password=NewJob@2019");
        }
    }
}