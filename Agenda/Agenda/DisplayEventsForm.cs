using System;
using DBDataAccess;
using System.Windows.Forms;
using System.Diagnostics;
using AgendaErrors;

namespace AgendaForms
{
    public partial class DisplayEventsForm : Form
    {
        ErrorForm errorForm;
        /// <summary>
        /// Form Constructor
        /// </summary>
        public DisplayEventsForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Display the events from the Database based on a Day/Week/All user choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            DateTime date = dateTimePicker.Value;

            string intervalChoice = GetUserChoice();
            var availableEvents = agenda.GetEvents(date.Date, intervalChoice);

            ReloadTable();

            if (availableEvents != null)
                for (int i = 0; i < availableEvents.Count; i++)
                {
                    dataGridViewDisplay.Rows.Add(
                        new object[]
                        {
                            availableEvents[i].Id,
                            availableEvents[i].Name,
                            ConvertDateFormat(availableEvents[i].Date.Value),
                            ConvertTimeFormat(availableEvents[i].Time.Value),
                            availableEvents[i].Description
                        }
                        );
                }
        }
        

        #region Tools
        /// <summary>
        /// Tool used to refresh the grid table
        /// </summary>
        private void ReloadTable()
        {
            dataGridViewDisplay.Rows.Clear();
            dataGridViewDisplay.Refresh();
        }

        /// <summary>
        /// Getting the interval choice from user to display the events
        /// </summary>
        /// <returns></returns>
        private string GetUserChoice()
        {
            string intervalChoice = string.Empty;

            if (DayRadioButton.Checked)
            {
                intervalChoice = "day";
            }
            else if (WeekRadioButton.Checked)
            {
                intervalChoice = "week";
            }
            else if (AllEventsRadioButton.Checked)
            {
                intervalChoice = "all";
            }
            else
            {
                ShowError("You have to choose events from a Day/Week/All");
            }

            return intervalChoice;
        }

        private void ShowError(string v)
        {
            if (errorForm == null)
            {
                errorForm = new ErrorForm();
            }
            errorForm.setLabelText(v);
            errorForm.ShowDialog();
        }

        public string ConvertDateFormat(DateTime date)
        {
            return date.ToString("dd-MM-yyyy");
        }

        public string ConvertTimeFormat(TimeSpan time)
        {
            return time.ToString(@"hh\:mm\:ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
