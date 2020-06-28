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
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if(ValidateUser())
            {
                AgendaMenu menu = new AgendaMenu();
                menu.Show();
            }
            else
            {
                //open window and display an error message "Wrong Username or Password"
                WrongCredentials errorWindow = new WrongCredentials();
                errorWindow.Show();
            }    
        }

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
    }
}
