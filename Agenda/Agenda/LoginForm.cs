using System;
using System.Windows.Forms;
using Security;
namespace Agenda
{
    public partial class LoginForm : Form
    {
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
                AgendaMenu menu = new AgendaMenu();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                WrongCredentials errorWindow = new WrongCredentials();
                errorWindow.Show();
            }    
        }
        
        #endregion

        #region tools
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
        #endregion

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void UsernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
