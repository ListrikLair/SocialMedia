using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class Data
    {
        List<User> userList = new List<User>();
        public void GenerateData()
        {
            userList.Add(new User("Kevin", new Birthdate(1996, 9, 16), "Hi is me", "He/Him"));
            userList.Add(new User("Johanne", new Birthdate(1987, 3, 28), "Hi is me, Johanne this time", "She/Her"));
            userList.Add(new User("Alex", new Birthdate(2001, 5, 22), "Hello is Alex, Whoooo!", "They/Them"));
        }

        public void DisplayData()
        {
            foreach (var user in userList)
            {
                Console.WriteLine("\nName: " + user.Name + $" ({user.Pronouns})");
                Console.WriteLine("Age: " + (2023 - user.Birthday.year));
                Console.WriteLine("Birthday: " + user.Birthday.day + ". " + ((Birthdate.Months)user.Birthday.month - 1));
                Console.WriteLine("Description: " + user.Description);
            }
        }
    }
}
