using AgendaErrors;
using AgendaEvents;
using DBDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class UpdateEventForm : Form
    {
        ErrorForm errorForm;
        private int id;
        /// <summary>
        /// Class constructor
        /// </summary>
        public UpdateEventForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Display the selected row's data in the editing part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewUpdate.Rows[e.RowIndex];
                DateTime date = ConvertToDate(row.Cells["EventDate"].Value.ToString());
                DateTime time = ConvertToDate(row.Cells["EventTime"].Value.ToString());

                this.id = (int)row.Cells["EventID"].Value;
                UpdEventNameTextBox.Text = row.Cells["EventName"].Value.ToString();
                UpdDatePicker.Value = date;
                UpdTimePicker.Value = time;
                UpdDescriptionTextBox.Text = row.Cells["EventDescription"].Value.ToString();
            }
        }
        /// <summary>
        /// Will refresh the table to display the introduced data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateEventForm_Load(object sender, EventArgs e)
        {
            ReloadTable();
        }

        /// <summary>
        /// Load the table with all events data
        /// </summary>
        private void DisplayEvents()
        {
            Agenda agenda = new Agenda();
            DisplayEventsForm displayEvents = new DisplayEventsForm();
            DateTime date = UpdDatePicker.Value;

            var availableEvents = agenda.GetEvents(date.Date, "all");

            if (availableEvents != null)
                for (int i = 0; i < availableEvents.Count; i++)
                {
                    dataGridViewUpdate.Rows.Add(
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

        /// <summary>
        /// Modify a Event data on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            string name = UpdEventNameTextBox.Text;
            DateTime date = UpdDatePicker.Value;
            DateTime time = UpdTimePicker.Value;
            string description = UpdDescriptionTextBox.Text;

            if (name == string.Empty || date == default || time == default)
                ShowError("No selected item to update");
            else if (date < DateTime.Now.Date)
                ShowError("Invalid introduced date");

                Agenda agenda = new Agenda();
                agenda.UpdateEvent(this.id, name, date, time, description);

                ReloadTable();
        }

        #region Tools
        private void ShowError(string v)
        {
            if(errorForm == null)
               errorForm = new ErrorForm();

            errorForm.setLabelText(v);
            errorForm.ShowDialog();
        }

        private void ReloadTable()
        {
            dataGridViewUpdate.Rows.Clear();
            DisplayEvents();
            dataGridViewUpdate.Update();
        }

        private DateTime ConvertToDate(string v)
        {
            return Convert.ToDateTime(v);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
