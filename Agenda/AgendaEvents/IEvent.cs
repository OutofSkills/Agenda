using AgendaEvents;
using Security;
using System;
using System.Collections.Generic;

namespace DBDataAccess
{
    public interface IEvent
    {
        void CreateEvent(string name, DateTime date, DateTime time, string description);
        void DeleteEvent(int id);
        List<Event> GetEvents(DateTime date, string dayOrWeek);
        void UpdateEvent(int id, string name, DateTime date, DateTime time, string description);
    }
}