using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns
{
    public class UserFactory
    {
        // List of users
        public static readonly User[] users = {
            new User("1", "Rob", "Yoqneam"),
            new User("2", "Joe", "TelAviv"),
            new User("3", "Jun", "Reeshon")
        };

        // Generating a random ID for a Guest

        public static AbstractUser getUser(string name)
        {

            for (int i = 0; i < users.Length; i++)
            {
                // If the user exists
                if (users[i].getName().Equals(name))
                {
                    return users[i];
                }
            }

            // If the user doesn't exist -> return null
            return null;
        }
    }
}