using AgendaEvents;
using Security;
using System;
using System.Collections.Generic;

namespace DBDataAccess
{
    public interface IAgendaDB
    {
        void AddRecordToDB(string name, DateTime date, DateTime time, string description);
        void DeleteRecordFromDB(int id);
        List<Event> GetRecordsFromDB(DateTime date, string dayOrWeek);
        void UpdateRecord(int id, string name, DateTime date, DateTime time, string description);
    }
}