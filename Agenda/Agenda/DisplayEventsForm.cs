using System;
using System.Windows.Forms;
using System.Diagnostics;
using AgendaErrors;
using AgendaLogic;

namespace AgendaForms
{
    public partial class DisplayEventsForm : Form
    {
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
            IAgenda agenda = new CAgenda();
            DateTime date = dateTimePicker.Value;

            string intervalChoice = GetUserChoice();
            var availableEvents = agenda.GetEvents(date.Date, intervalChoice);

            ReloadWindow();

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
        private void ReloadWindow()
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
            DialogManager dialog = new DialogManager();
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
                dialog.ShowErrorWindow("No display option selected");
            }

            return intervalChoice;
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
