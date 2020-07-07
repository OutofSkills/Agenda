using AgendaErrors;
using DBDataAccess;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class DeleteEventForm : Form
    {
        private int id;
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
            ReloadTable();
        }
        /// <summary>
        /// Load the table with all events data
        /// </summary>
        private void GridDisplayEvents()
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

                this.id = (int)row.Cells["EventID"].Value;
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
            Agenda agenda = new Agenda();

            if (id == default)
             ShowError("No selected item to delete");
            
            agenda.DeleteEvent(id);
            ReloadTable();
        }

        #region Tools
        private void ShowError(string v)
        {
            ErrorForm errorWindow = new ErrorForm();
            errorWindow.setLabelText(v);
            errorWindow.Show();
        }
        private DateTime ConvertToDate(string v)
        {
            return Convert.ToDateTime(v);
        }
        /// <summary>
        /// Reload the data from the table
        /// </summary>
        private void ReloadTable()
        {
            dataGridViewDelete.Rows.Clear();
            GridDisplayEvents();
            dataGridViewDelete.Update();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
