using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace Educational_Software.Models
{
    internal class Server
    {
        private DatabaseHandler db;
        private User? user;
        public Server()
        {
            DatabaseHandler db = new DatabaseHandler();
            user = null;
        }
        public void sign_up(string name, string lastname, string email, string password)
        {
            if (db.add_user(name, lastname, email, password))
            {
                user = new User(0, name, lastname, email, password);
            }
        }

        public void sign_in(string email, string password)
        {
            List<User> users = db.get_user(email, password);
            if (users.Count > 0) user = users[0];
        }

        public void sign_out()
        {
            user = null;
        }

    }
}
