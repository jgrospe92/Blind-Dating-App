using System;
using System.Collections.Generic;

namespace AppDevTeamProject
{
    public class User
    {

        // Unique user Identifier
        public int ID { set; get; }

        // User Info to fill in
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public string Location { set; get; }
        public string Bio { set; get; }
        public string[] Traits { set; get; }

        // User logins
        public string Username { set; get; }
        public int Password { set; get; }


        // User preferences
        public string[] Likes { set; get; }


        // Constructor
        public User(int iD, string firstName, string lastName, int age, string location, string bio, string username, int password)
        {
            ID = iD;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Location = location;
            Bio = bio;
            Username = username;
            Password = password;

        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
