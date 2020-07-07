using AgendaEvents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Security
{
    public class UserSecurity
    {
        /// <summary>
        /// Will return TRUE if the user introduced data is matching with the data from database
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool ValidateUser(string username, string password)
        {
            bool validation = true;
            AgendaEntities db = new AgendaEntities();

            try
            {
                if (username != string.Empty || password != string.Empty)
                {
                    var user = db.USER.Where(u => u.Username == username).FirstOrDefault();

                    if (user != null)
                        if (user.Password.Equals(password))
                            return validation;
                }
                else
                {
                    return !validation;
                }
            } catch (Exception e)
            {
                MessageBox.Show("Exception Details: " + e);
            }

            return !validation;
        }
    }
        


}
