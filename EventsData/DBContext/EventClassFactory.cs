using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace EventsData.DBContext
{
    public class EventClassFactory: IDesignTimeDbContextFactory<EventContext>
    {
        public EventClassFactory()
        {
        }

        public EventContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<EventContext>();
            optionsBuilder.UseSqlServer("Server=localhost,1401; Database=EventDB;User=SA; Password=NewJob@2019");

            return new EventContext(optionsBuilder.Options);
        }
    }
}
