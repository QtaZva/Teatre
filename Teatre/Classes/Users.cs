using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teatre.Classes
{
    internal class Users
    {
        public int id {  get; set; }
        public string login, password;
        public int accessLevel;
        public string Login
        {
            get { return login; }
            set { login = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public int AccessLevel
        {
            get { return accessLevel; }
            set { accessLevel = value; }
        }
        Users() { }
        public Users (string  login, string password, int accessLevel)
        {
            this.login = login;
            this.password = password;
            this.accessLevel = accessLevel;
        }
    }
}
