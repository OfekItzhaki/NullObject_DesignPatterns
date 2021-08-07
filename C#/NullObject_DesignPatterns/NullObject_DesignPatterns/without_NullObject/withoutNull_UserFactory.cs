using NullObject_DesignPatterns.shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns
{
    public class UserFactory
    {
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

            // If the user doesn't exist -> return null
            return user != null ? user : null;
        }
    }
}