using AgendaEvents;
using DBDataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaLogic
{
    public class CAgenda : IAgenda
    {
        public bool CreateNewEvent(CEvent _event)
        {
            bool success = true;
            IAgendaDB agenda = new AgendaDB();

            if (_event.name != string.Empty && _event.date.Date >= DateTime.Now.Date)
            {
                agenda.AddRecordToDB(_event.name, _event.date, _event.time, _event.description);
                return success;
            }
            else
                return !success;
        }
        public void RemoveEvent(int eventID)
        {
            AgendaDB dB = new AgendaDB();
            dB.DeleteRecordFromDB(eventID);
        }
        public List<Event> GetEvents(DateTime date, string choice)
        {
            AgendaDB db = new AgendaDB();
            var events = db.GetRecordsFromDB(date, choice);

            return events;
        }
        public bool EditEventDetails(CEvent _event)
        {
            bool success = true;
            AgendaDB dB = new AgendaDB();

            if (_event.name == string.Empty || _event.date == DateTimePicker.MinimumDateTime)
                return !success;
            else if (_event.date.Date < DateTime.Now.Date)
                return !success;
            
            dB.UpdateRecord(_event.id, _event.name, _event.date, _event.time, _event.description);

            return success;
        }
    }
}
