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
    public partial class CreateEventForm : Form
    {
        public CreateEventForm()
        {
            InitializeComponent();
        }

        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            InitializeTimePicker();
        }

        /// <summary>
        /// Will asign the data introduced by the user to the database handler method to save
        /// a new event
        /// </summary>
        private void CreateNewEvent()
        {
            Agenda agenda = new Agenda();

            string name = EventNameTextBox.Text;
            DateTime date = DatePicker.Value;
            DateTime time = TimePicker.Value;
            string description = DescriptionTextBox.Text;

            if(name != string.Empty && date != default && time != default)
            {
                agenda.CreateEvent(name, date, time, description);
            }

            ClearFields();
        }

        #region Tools
        private void InitializeTimePicker()
        {
            TimePicker.CustomFormat = "HH:mm";
        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateNewEvent();
        }
        private void ClearFields()
        {
            EventNameTextBox.Clear();
            DatePicker.ResetText();
            TimePicker.ResetText();
            DescriptionTextBox.Clear();
        }
        #endregion
    }
}
