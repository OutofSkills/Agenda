using System;

namespace DBDataAccess
{
    public interface IEvent
    {
        void CreateEvent(string name, DateTime date, DateTime time, string description);
        void DeleteEvent(DateTime date, DateTime time);
        void DisplayEvents(DateTime date, DateTime time);
        void UpdateEvent(string name, DateTime date, DateTime time, string description);
    }
}