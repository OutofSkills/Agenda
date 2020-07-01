using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Security
{
        public class UserSecurity
        {
            public bool ValidateUser(string username, string password)
            {
                AgendaDBEntities db = new AgendaDBEntities();

                if (username != string.Empty || password != string.Empty)
                {
                    var user = db.USER.Where(u => u.Username == username).FirstOrDefault();

                    if (user != null)
                    {
                        if (user.Password.Equals(password))
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
