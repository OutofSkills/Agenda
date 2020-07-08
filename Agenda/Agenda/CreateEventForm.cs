using AgendaErrors;
using AgendaEvents;
using DBDataAccess;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class CreateEventForm : Form
    {
        ErrorForm errorWindow;
        SuccesWindow succesWindow;
        public CreateEventForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Will change the DateTimePicker format to HH:mm time format
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateEventForm_Load(object sender, EventArgs e)
        {
            InitializeTimePicker();
            InitializeDatePicker();
        }

        /// <summary>
        /// Will asign the data introduced by the user to the database handler method to save
        /// a new event
        /// </summary>
        private void CreateNewEvent()
        {
            IAgenda agenda = new CAgenda();
            CEvent _event = new CEvent();

            _event.name = EventNameTextBox.Text;
            _event.date = DatePicker.Value;
            _event.time = TimePicker.Value;
            _event.description = DescriptionTextBox.Text;

            if (_event.name != string.Empty && _event.date.Date >= DateTime.Now.Date)
            {
                agenda.CreateEvent(_event.name, _event.date, _event.time, _event.description);
                ShowSuccess("Event successfully created");
            }
            else
                ShowError("Invalid provided event data");

            ClearFields();
        }

        private void ShowSuccess(string v)
        {
            if(succesWindow == null)
                succesWindow = new SuccesWindow();
            succesWindow.SetSuccessLabel(v);
            succesWindow.ShowDialog();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateNewEvent();
        }

        #region Tools
        /// <summary>
        /// Will open a window with an error text wether there is a error
        /// </summary>
        /// <param name="v"></param>
        private void ShowError(string v)
        {
            if (errorWindow == null)
            {
                errorWindow = new ErrorForm();
            }
            errorWindow.setLabelText(v);
            errorWindow.ShowDialog();
        }
        private void InitializeTimePicker()
        {
            TimePicker.CustomFormat = "HH:mm";
            TimePicker.Value = DateTimePicker.MinimumDateTime;
        }
        private void InitializeDatePicker()
        {
            DatePicker.Value = DateTimePicker.MinimumDateTime;
        }
        /// <summary>
        /// Will clean all the text fields 
        /// </summary>
        private void ClearFields()
        {
            EventNameTextBox.Clear();
            InitializeDatePicker();
            InitializeTimePicker();
            DescriptionTextBox.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
