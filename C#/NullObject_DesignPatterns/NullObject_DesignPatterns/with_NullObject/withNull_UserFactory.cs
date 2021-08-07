using NullObject_DesignPatterns.shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns
{
    public class withoutNull_UserFactory
    {

        // Generating a random ID for a Guest
        static string generate_Random_Guest_ID()
        {
            Random rand = new Random();
            return rand.Next(1, 100000).ToString();
        }

        public static AbstractUser getUser(string name)
        {

            User[] userList = UserList.Users;
            AbstractUser user = null;
            for (int i = 0; i < userList.Length; i++)
            {
                // If the user exists
                if (userList[i].getName().Equals(name))
                {
                    user = userList[i];
                }
            }

            // If the user doesn't exist -> is a Guest
            return user != null ? user : new withNull_Guest(generate_Random_Guest_ID(), name);
        }
    }
}