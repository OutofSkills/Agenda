using AgendaErrors;
using AgendaEvents;
using AgendaLogic;
using DBDataAccess;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AgendaForms
{
    public partial class CreateEventForm : Form
    {
        CEvent _event;
        ErrorForm errorWindow;
        SuccesWindow succesWindow;
        public CreateEventForm()
        {
            _event = new CEvent();
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
        private void SetNewEventDetails()
        {
            IAgenda agenda = new CAgenda();

            _event.name = EventNameTextBox.Text;
            _event.date = DatePicker.Value;
            _event.time = TimePicker.Value;
            _event.description = DescriptionTextBox.Text;

            bool validate = agenda.CreateNewEvent(_event);

            if (validate)
            {
                ShowSuccess("Event successfully created");
            }
            else
                ShowError("Invalid provided event data");

            ClearFields();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            SetNewEventDetails();
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
        private void ShowSuccess(string v)
        {
            if (succesWindow == null)
                succesWindow = new SuccesWindow();
            succesWindow.SetSuccessLabel(v);
            succesWindow.ShowDialog();
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
