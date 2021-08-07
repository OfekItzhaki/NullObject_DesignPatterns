using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns.shared
{
    public class UserList
    {
        // List of users
        static readonly User[] users = {
            new User("1", "Rob", "Yoqneam"),
            new User("2", "Joe", "TelAviv"),
            new User("3", "Jun", "Reeshon")
        };

        public static User[] Users
        {
            get { return users; }
        }
    }
}
