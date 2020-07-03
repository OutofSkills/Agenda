using AgendaEvents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;


namespace DBDataAccess
{
    public class Agenda : IEvent
    {
        public void CreateEvent(string name, DateTime date, DateTime time, string description)
        {
            using (var context = new AgendaEntities())
            {
                var evnt = new Event()
                {
                    Name = name,
                    Date = date,
                    Time = time.TimeOfDay,
                    Description = description
                };
                context.Events.Add(evnt);

                context.SaveChanges();
            }
        }

        public List<Event> DisplayEvents(DateTime date, string dayOrWeek)
        {
            List<Event> events = null;
            AgendaEntities context = new AgendaEntities();
            //er;gjerigue
            if (dayOrWeek.ToLower() == "day")
            {
               events = context.Events.Where(e => e.Date == date.Date).ToList();
            }
            else if(dayOrWeek.ToLower() == "week")
            {
                events = context.Events.Where(e => e.Date >= date.Date.Date && e.Date < date.Date.AddDays(7)).ToList();
            }
            return events;
        }


        public void UpdateEvent(string name, DateTime date, DateTime time, string description)
        {
            using (var context = new AgendaEntities())
            {
                var evnt = new Event()
                {
                    Name = name,
                    Date = date,
                    Time = time.TimeOfDay,
                    Description = description
                };
                context.SaveChanges();
            }
        }
       
        public void DeleteEvent(DateTime date, DateTime time)
        {
            AgendaEntities context = new AgendaEntities();

            var eventToRemove = context.Events.Where(e => e.Date == date.Date && e.Time == time.TimeOfDay).FirstOrDefault();

            if (eventToRemove != null)
                context.Events.Remove(eventToRemove);
        }
    }
}
