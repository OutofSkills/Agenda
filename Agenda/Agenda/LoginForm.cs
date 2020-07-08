using System;
using System.Drawing;
using System.Windows.Forms;
using AgendaErrors;
using Security;
namespace AgendaForms
{
    public partial class LoginForm : Form
    {
        Point lastPoint;
        static WrongCredentials errorWindow;
        /// <summary>
        /// LoginForm Constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
        }
        #region Login methods  

        /// <summary>
        /// Method that opens the Agenda Menu if the login was successful or an error message if the credentials were wrong
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignInButton_Click(object sender, EventArgs e)
        {
            UserSecurity security = new UserSecurity();
  
            if (security.ValidateUser(UsernameTextBox.Text, PasswordTextBox.Text))
            {
                OpenAgendaApplication();
            }
            else
            {
                ShowLoginError();
            }
        }

        #endregion

        #region tools
        private void OpenAgendaApplication()
        {
            AgendaMenu menu = new AgendaMenu();
            menu.Show();
            this.Visible = false;
        }
        private static void ShowLoginError()
        {
            if(errorWindow == null)
                errorWindow = new WrongCredentials();
            errorWindow.ShowDialog();
        }
        private void UsernameTextBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                PasswordTextBox.Focus();
            }
        }

        private void PasswordTextBox_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SignInButton.Focus();
            }
        }
       
        private void ExitMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeMenuButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        #endregion
    }
}
