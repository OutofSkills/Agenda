﻿using AgendaErrors;
using AgendaLogic;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class DeleteEventForm : Form
    {
        private int selectedRowId;

        /// <summary>
        /// Class contructor
        /// </summary>
        public DeleteEventForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Load the events data into the table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteEventForm_Load(object sender, EventArgs e)
        {
            ReloadWindow();
        }
        /// <summary>
        /// Load the table with all events data
        /// </summary>
        private void AddDataToTable()
        {
            IAgenda agenda = new CAgenda();
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
        /// <summary>
        /// Will display the selected event's data into the delete fields
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewDelete_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewDelete.Rows[e.RowIndex];
                DateTime date = ConvertToDate(row.Cells["EventDate"].Value.ToString());

                this.selectedRowId = (int)row.Cells["EventID"].Value;
                DeleteNameTextBox.Text = row.Cells["EventName"].Value.ToString();
                DeleteDatePicker.Value = date;
            }
        }

        /// <summary>
        /// Delete the selected event from the Database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            IAgenda agenda = new CAgenda();
            DialogManager dialog = new DialogManager();

            if (selectedRowId == default)
                dialog.ShowErrorWindow("No selected item to delete");
            else
                dialog.ShowSuccessWindow("Event successfully deleted");
            
            agenda.RemoveEvent(selectedRowId);
            ReloadWindow();
        }


        #region Tools
        private DateTime ConvertToDate(string v)
        {
            return Convert.ToDateTime(v);
        }
        /// <summary>
        /// Reload the data from the table
        /// </summary>
        private void ReloadWindow()
        {
            dataGridViewDelete.Rows.Clear();
            AddDataToTable();
            dataGridViewDelete.Update();
            DeleteNameTextBox.ResetText();
            DeleteDatePicker.Value = DateTimePicker.MinimumDateTime;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
