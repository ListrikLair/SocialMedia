using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialMedia
{
    internal class User
    {
        public string Name;
        public Birthdate Birthday;
        public string Description;
        public string Pronouns;

        public User(string name,Birthdate birthday, string description, string pronouns)
        {
            Name = name;
            Birthday = birthday;
            Description = description;
            Pronouns = pronouns;
        }

        public User(string name, Birthdate birthday, string pronouns)
        {
            Name = name;
            Birthday = birthday;
            Pronouns = pronouns;
        }
    }
}
