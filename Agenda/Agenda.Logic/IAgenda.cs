using AgendaEvents;
using System;
using System.Collections.Generic;

namespace AgendaLogic
{
    public interface IAgenda
    {
        bool CreateNewEvent(CEvent _event);
        void RemoveEvent(int eventID);
        List<Event> GetEvents(DateTime date, string choice);
        bool EditEventDetails(CEvent _event);
    }
}