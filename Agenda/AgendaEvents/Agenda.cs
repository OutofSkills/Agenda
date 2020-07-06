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

        public List<Event> GetEvents(DateTime date, string dayOrWeek)
        {
            List<Event> events = null;
            AgendaEntities context = new AgendaEntities();
            DateTime limitDate = date.Date.AddDays(7);
            
            if (dayOrWeek.ToLower() == "day")
            {
               events = context.Events.Where(e => e.Date == date.Date).ToList();
            }
            else if(dayOrWeek.ToLower() == "week")
            {
                events = context.Events.Where(e => e.Date >= date.Date.Date && e.Date < limitDate.Date).ToList();
            }else if(dayOrWeek.ToLower() == "all")
            {
                events = context.Events.Where(e => e.Date >= DateTime.Now).ToList();
            }
            return events;
        }


        public void UpdateEvent(int id, string name, DateTime date, DateTime time, string description)
        {
            using (var context = new AgendaEntities())
            {
                var evnt = context.Events.SingleOrDefault(e=>e.Id == id);
                if(evnt != null)
                {
                    evnt.Name = name;
                    evnt.Date = date;
                    evnt.Time = time.TimeOfDay;
                    evnt.Description = description;

                    context.SaveChanges();
                }
            }
        }
       
        public void DeleteEvent(int id)
        {
            AgendaEntities context = new AgendaEntities();

            var eventToRemove = context.Events.FirstOrDefault(e=>e.Id == id);

            if (eventToRemove != null)
            {
                context.Events.Remove(eventToRemove);
                context.SaveChanges();
            }
        }
    }
}
