using AgendaEvents;
using System;
using System.Collections.Generic;

namespace DBDataAccess
{
    public interface IEvent
    {
        void CreateEvent(string name, DateTime date, DateTime time, string description);
        void DeleteEvent(DateTime date, DateTime time);
        List<Event> DisplayEvents(DateTime date, string dayOrWeek);
        void UpdateEvent(string name, DateTime date, DateTime time, string description);
    }
}