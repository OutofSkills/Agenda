using System;
using DBDataAccess;
using System.Windows.Forms;
using System.Diagnostics;

namespace AgendaForms
{
    public partial class DisplayEventsForm : Form
    {
        public DisplayEventsForm()
        {
            InitializeComponent();
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            DateTime date = dateTimePicker.Value;
            string intervalChoice = string.Empty;

            if (dayCheckBox.Checked)
            {
                intervalChoice = "day";
            }
            else if(weekCheckBox.Checked)
            {
                intervalChoice = "week";
            }else if(allEventsCheckBox.Checked)
            {
                intervalChoice = "all";
            }

            var availableEvents = agenda.DisplayEvents(date.Date, intervalChoice);

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

            //code for scrolling in the table
            dataGridView.FirstDisplayedScrollingRowIndex = dataGridView.RowCount - 1;

            if (availableEvents != null)
                for (int i = 0; i < availableEvents.Count; i++)
                {
                    dataGridView.Rows.Add(
                        new object[]
                        {
                            availableEvents[i].Id,
                            availableEvents[i].Name,
                            availableEvents[i].Date,
                            availableEvents[i].Time,
                            availableEvents[i].Description
                        }
                        );
                }
        }
        
    }
}
