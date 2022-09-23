using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        List<User> user = new List<User>();
        
        public User(string username,string password)
        {
            this.Username = username;
            this.Password = password;
        }
    }
    public class Account
    {
        public List<User> user = new List<User>();
        public void Registration(User account)
        {
            user.Add(account);
        }
    }
}
