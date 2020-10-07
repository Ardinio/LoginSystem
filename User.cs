namespace ConsoleTemplate
{
    public class User
    {
        public int ID
        {
            get;
            set;
        }
        public static int Count = 0;
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public Adress Adress
        {
            get;
            set;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Count++;
        }

        /*   public string username;
           private string password;
           public string Password
           {
               get
               {
                   return password;
               }
           }*/
    }
}