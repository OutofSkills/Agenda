using AgendaErrors;
using DBDataAccess;
using System;
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

            if(name != string.Empty || date != default || time != default)
                ShowErrorWindow("Invalid provided event data");
            else if (date < DateTime.Now.Date)
                ShowErrorWindow("Invalid introduced date");
                agenda.CreateEvent(name, date, time, description);
            
            ClearFields();
        }

        #region Tools
        private void ShowErrorWindow(string v)
        {
            ErrorForm errorWindow = new ErrorForm();
            errorWindow.setLabelText(v);
            errorWindow.Show();
        }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
