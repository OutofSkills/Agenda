using AgendaForms;
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
    public partial class AgendaMenu : Form
    {
        private Form activeForm = null;
        Point lastPoint;

        /// <summary>
        /// Class Contructor
        /// </summary>
        public AgendaMenu()
        {
            InitializeComponent();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #region Move window tools
        private void AgendaMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void AgendaMenu_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion

        /// <summary>
        /// Will change current menu window to the one selected by user
        /// </summary>
        /// <param name="childForm"></param>
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();

            childForm.Show();
        }
        #region Agenda menu features windows
        private void CreateButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CreateEventForm());
        }

        private void DisplayButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DisplayEventsForm());
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new UpdateEventForm());
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DeleteEventForm());
        }
        #endregion
    }
}
