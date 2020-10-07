using System;

namespace ConsoleTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            Login login = new Login();

            login.AddUser("Ardi", "Password");
            login.AddUser("boi", "joke");
            login.AddUser("memes", "memez");

            bool isValidUser = login.TryValidateUser("Ardi", "Password");

            Console.WriteLine("User count:  " + User.Count);
            Console.WriteLine("IsvaildUser: " + isValidUser);
        }
    }
}