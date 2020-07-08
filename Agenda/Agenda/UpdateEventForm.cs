using AgendaErrors;
using AgendaLogic;
using System;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class UpdateEventForm : Form
    {
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
        private void AddDataToTable()
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
            DialogManager dialog = new DialogManager();
            IAgenda agenda = new CAgenda();

            _event.name = UpdEventNameTextBox.Text;
            _event.date = UpdDatePicker.Value;
            _event.time = UpdTimePicker.Value;
            _event.description = UpdDescriptionTextBox.Text;

            bool validate = agenda.EditEventDetails(_event);

            if (validate)
                dialog.ShowSuccessWindow("Event successfully modified");
            else
                dialog.ShowErrorWindow("No selected item or invalid event data");

            ReloadWindow();
        }

        #region Tools
        private void ReloadWindow()
        {
            dataGridViewUpdate.Rows.Clear();
            AddDataToTable();
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
