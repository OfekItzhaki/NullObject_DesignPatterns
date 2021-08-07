using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns.shared
{
    public abstract class AbstractUser
    {
        protected string id;
        protected string name;
        protected string pic;
        public abstract bool isUser();
        public abstract string getName();

        protected AbstractUser(string id)
        {
            this.id = id;
            name = "AbstractUser";
            pic = "AbstractUser";
        }

        protected AbstractUser(string id, string name)
        {
            this.id = id;
            this.name = name;
            pic = "AbstractUser";
        }
    }
}
