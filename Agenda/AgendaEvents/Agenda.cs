using AgendaEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBDataAccess
{
    public class Agenda : IEvent
    {
        public void CreateEvent(string name, DateTime date, DateTime time, string description)
        {
            using (var context = new AgendaDBEntities())
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
            AgendaDBEntities context = new AgendaDBEntities();

            if (dayOrWeek.ToLower() == "day")
            {
               events = context.Events.Where(e => e.Date == date.Date.Date).ToList();
            }
            else if(dayOrWeek.ToLower() == "week")
            {
                events = context.Events.Where(e => e.Date >= date.Date.Date && e.Date < date.Date.AddDays(7)).ToList();
            }
            return events;
        }


        public void UpdateEvent(string name, DateTime date, DateTime time, string description)
        {
            using (var context = new AgendaDBEntities())
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
            AgendaDBEntities context = new AgendaDBEntities();

            var eventToRemove = context.Events.Where(e => e.Date == date.Date && e.Time == time.TimeOfDay).FirstOrDefault();

            if (eventToRemove != null)
                context.Events.Remove(eventToRemove);
        }
    }
}
