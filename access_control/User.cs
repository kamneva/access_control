using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace access_control
{
    public class User
    {
        private String username;
        private String password;
        private bool blocked;
        private bool restricted;

        public User()
        {
            username = "";
            password = "";
            blocked = false;
            restricted = false;
        }

        public User(String uname)
        {
            username = uname;
            password = "";
            blocked = false;
            restricted = false;
        }

        public User(String uname, String pswd)
        {
            username = uname;
            password = pswd;
            blocked = false;
            restricted = false;
        }

        public User(User user)
        {
            username = user.Username;
            password = user.Password;
            blocked = user.Blocked;
            restricted = user.Restricted;
        }

        public String Username
        {
            get { return username; }
            set { username = value; }
        }

        public String Password
        {
            get { return password; }
            set { password = value; }
        }

        public bool Blocked
        {
            get { return blocked; }
            set { blocked = value; }
        }

        public bool Restricted
        {
            get { return restricted; }
            set { restricted = value; }
        }
    }
}
