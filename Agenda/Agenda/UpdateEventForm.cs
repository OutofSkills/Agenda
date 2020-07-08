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
        SuccesWindow succesWindow;
        CEvent _event;
        /// <summary>
        /// Class constructor
        /// </summary>
        public UpdateEventForm()
        {
            InitializeComponent();
            _event = new CEvent();
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

                _event.id = (int)row.Cells["EventID"].Value;
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
            ReloadWindow();
        }

        /// <summary>
        /// Load the table with all events data
        /// </summary>
        private void AddEventsToTable()
        {
            IAgenda agenda = new CAgenda();
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
            IAgenda agenda = new CAgenda();

            _event.name = UpdEventNameTextBox.Text;
            _event.date = UpdDatePicker.Value;
            _event.time = UpdTimePicker.Value;
            _event.description = UpdDescriptionTextBox.Text;

            if (_event.name == string.Empty || _event.date == DateTimePicker.MinimumDateTime)
                ShowError("No selected item to update or invalid introduced event data");
            else if (_event.date.Date < DateTime.Now.Date)
                ShowError("Invalid introduced date");
            else
            {
                agenda.UpdateEvent(_event.id, _event.name, _event.date, _event.time, _event.description);
                ShowSuccess("Event successfully modified");
            }
            ReloadWindow();
        }

        #region Tools
        private void ShowSuccess(string v)
        {
            if (succesWindow == null)
                succesWindow = new SuccesWindow();
            succesWindow.SetSuccessLabel(v);
            succesWindow.ShowDialog();
        }
        private void ShowError(string v)
        {
            if(errorForm == null)
               errorForm = new ErrorForm();

            errorForm.setLabelText(v);
            errorForm.ShowDialog();
        }

        private void ReloadWindow()
        {
            dataGridViewUpdate.Rows.Clear();
            AddEventsToTable();
            dataGridViewUpdate.Update();

            UpdEventNameTextBox.ResetText();
            UpdDescriptionTextBox.ResetText();
            UpdDatePicker.Value = DateTimePicker.MinimumDateTime;
            UpdTimePicker.Value = DateTimePicker.MinimumDateTime;
        }

        private DateTime ConvertToDate(string v)
        {
            return Convert.ToDateTime(v);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
