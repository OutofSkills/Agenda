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

            var availableEvents = agenda.DisplayEvents(date.Date, IntervalListBox.SelectedItem.ToString());

            dataGridView.Rows.Clear();
            dataGridView.Refresh();

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
