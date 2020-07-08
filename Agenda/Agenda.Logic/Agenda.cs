using AgendaEvents;
using DBDataAccess;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AgendaLogic
{
    public class CAgenda : IAgenda
    {
        /// <summary>
        /// Will get a event data from the user and pass it to the database
        /// </summary>
        /// <param name="_event"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Will call the removing from database method for a given item
        /// </summary>
        /// <param name="eventID"></param>
        public void RemoveEvent(int eventID)
        {
            AgendaDB dB = new AgendaDB();
            dB.DeleteRecordFromDB(eventID);
        }

        /// <summary>
        /// Will get a list a list of events from the database data access method
        /// </summary>
        /// <param name="date"></param>
        /// <param name="choice"></param>
        /// <returns></returns>
        public List<Event> GetEvents(DateTime date, string choice)
        {
            AgendaDB db = new AgendaDB();
            var events = db.GetRecordsFromDB(date, choice);

            return events;
        }

        /// <summary>
        /// Will pass a new event data to the database update method to update a event by an ID
        /// </summary>
        /// <param name="_event"></param>
        /// <returns></returns>
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
