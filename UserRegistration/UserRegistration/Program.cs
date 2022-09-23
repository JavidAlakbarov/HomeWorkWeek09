using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class Program
    {
        private static Account account = new Account();

        public static void Main(string[] args)
        {
            bool checking = true;
            while (checking)
            {
                Console.WriteLine("1: Register");
                Console.WriteLine("2: Forget password");
                Console.WriteLine("3: Check login and password");
                int menu = int.Parse(Console.ReadLine());
                try
                {
                    switch (menu)
                    {

                        case 1:
                            Register();
                            checking = false;
                            break;
                        case 2:
                            ForgedPassword(account.user);
                            checking = false;
                            break;
                        case 3:
                            CheckloginAndPassword(account.user);
                            checking = false;
                            break;
                        default:
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Try later");
                }
            }

        }

        public static void Register()
        {
            try
            {
                Console.Write("Enter the login: ");
                string name = Console.ReadLine();
                string username = name;
                Console.Write("Enter the password: ");
                string password = Console.ReadLine();
                int userpassword = int.Parse(password);
                if (name == username && int.Parse(password) == userpassword)
                {
                    Console.WriteLine("You signed in");
                    Console.WriteLine(" ");
                }
                User use1 = new User(name, password);
                account.Registration(use1);

            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect login and password");
            }
        }
        public static void ForgedPassword(List<User> user)
        {
            Console.Write("Enter the login: ");
            string ad = Console.ReadLine();
            Console.Write("Enter the password: ");
            string pass = Console.ReadLine();
            try
            {
                User user1 = user.Where(u => u.Username == ad).FirstOrDefault();
                user1.Password = pass;
                Console.WriteLine("Password has been changed");
                Console.WriteLine(" ");
            }
            catch (FormatException)
            {
                Console.WriteLine("Incorrect login or password");
            }
        }
        public static void CheckloginAndPassword(List<User> user)
        {
            while (true)
            {
                Console.Write("Enter the login: ");
                string login = Console.ReadLine();
                Console.Write("Enter the password: ");
                string password = Console.ReadLine();
                User user1 = user.Where(u => u.Username == login).FirstOrDefault();
                if (user1 != null)
                {
                    if (user1.Password == password)
                    {
                        Console.WriteLine("Successfully logged in");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password");
                    }
                }
                else
                {
                    Console.WriteLine("User not found");
                }
            }
        }
    }
}
