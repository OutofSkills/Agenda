using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if(ValidateUser())
            {
                AgendaMenu menu = new AgendaMenu();
                menu.Show();
            }
            else
            {
                WrongCredentials errorWindow = new WrongCredentials();
                errorWindow.Show();
            }    
        }

        /// <summary>
        /// Comparing user data from database with the user provided data
        /// </summary>
        /// <returns></returns>
        private bool ValidateUser()
        {
            AgendaDBEntities db = new AgendaDBEntities();

            if (UsernameTextBox.Text != string.Empty || PasswordTextBox.Text != string.Empty)
            {
                var user = db.USER.Where(u => u.Username.Equals(UsernameTextBox.Text)).FirstOrDefault();

                if(user!= null)
                {
                    if(user.Password.Equals(PasswordTextBox.Text))
                    {
                        return true;
                    }
                }
            }
            else
            {
                return false;
            }

            return false;
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
    }
}
