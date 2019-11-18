using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Events.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var e1 = new EventsData.Models.Events( );
            e1.EventId = 1;
            e1.Title = "Event1";
            string dateInput = "January 28, 2019";
            DateTime parsedDate = DateTime.Parse(dateInput);
            e1.Date = parsedDate;
            e1.Description = "Social event";
            e1.Notes = "test";

        }
    }
}
