﻿using AgendaEvents;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DBDataAccess
{
    public class AgendaDB : IAgendaDB
    {
        /// <summary>
        /// Will add a record into the Database containing data that describes an agenda event
        /// </summary>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="description"></param>
        public void AddRecordToDB(string name, DateTime date, DateTime time, string description)
        {
            try
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
            }catch(Exception e)
            {
                MessageBox.Show("Exception Details: " + e);
            }
        }
        /// <summary>
        /// Returns a list of events from the Database based on a time choice
        /// </summary>
        /// <param name="date"></param>
        /// <param name="dayOrWeek"></param>
        /// <returns></returns>
        public List<Event> GetRecordsFromDB(DateTime date, string dayOrWeek)
        {
            List<Event> events = null;
            AgendaEntities context = new AgendaEntities();
            DateTime limitDate = date.Date.AddDays(7);
            try
            {
                if (dayOrWeek.ToLower() == "day")
                {
                    events = context.Events.Where(e => e.Date == date.Date).ToList();
                }
                else if (dayOrWeek.ToLower() == "week")
                {
                    events = context.Events.Where(e => e.Date >= date.Date.Date && e.Date < limitDate.Date).ToList();
                }
                else if (dayOrWeek.ToLower() == "all")
                {
                    events = context.Events.Where(e => e.Id > 0).ToList();
                }
            }catch(Exception e)
            {
                MessageBox.Show("Exception Details: " + e);
            }
            return events;
        }

        /// <summary>
        /// Will edit a record(event) from the database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="date"></param>
        /// <param name="time"></param>
        /// <param name="description"></param>
        public void UpdateRecord(int id, string name, DateTime date, DateTime time, string description)
        {
            try
            {
                using (var context = new AgendaEntities())
                {
                    var evnt = context.Events.SingleOrDefault(e => e.Id == id);
                    if (evnt != null)
                    {
                        evnt.Name = name;
                        evnt.Date = date;
                        evnt.Time = time.TimeOfDay;
                        evnt.Description = description;

                        context.SaveChanges();
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show("Exception Details: " + e);
            }
        }
        /// <summary>
        /// Will delete a record(event) from the database based on a given ID
        /// </summary>
        /// <param name="id"></param>
        public void DeleteRecordFromDB(int id)
        {
            AgendaEntities context = new AgendaEntities();

            try
            {
                var eventToRemove = context.Events.FirstOrDefault(e => e.Id == id);

                if (eventToRemove != null)
                {
                    context.Events.Remove(eventToRemove);
                    context.SaveChanges();
                }
            }catch(Exception e)
            {
                MessageBox.Show("Exception Details: " + e);
            }
        }
    }
}
