using DBDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class DeleteEventForm : Form
    {
        public DeleteEventForm()
        {
            InitializeComponent();
        }

        private void DeleteEventForm_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }
        private void ReloadTable()
        {
            dataGridViewDelete.Rows.Clear();
            DisplayEvents();
            dataGridViewDelete.Update();
        }
        /// <summary>
        /// Load the table with all events data
        /// </summary>
        private void DisplayEvents()
        {
            Agenda agenda = new Agenda();
            DisplayEventsForm displayEvents = new DisplayEventsForm();
            DateTime date = DeleteDatePicker.Value;

            var availableEvents = agenda.GetEvents(date.Date, "all");

            if (availableEvents != null)
                for (int i = 0; i < availableEvents.Count; i++)
                {
                    dataGridViewDelete.Rows.Add(
                        new object[]
                        {
                            availableEvents[i].Id,
                            availableEvents[i].Name,
                            displayEvents.ConvertDateFormat(availableEvents[i].Date.Value),
                            displayEvents.ConvertTimeFormat(availableEvents[i].Time.Value),
                            availableEvents[i].Description
                        }
                        );
                }
        }
    }
}
