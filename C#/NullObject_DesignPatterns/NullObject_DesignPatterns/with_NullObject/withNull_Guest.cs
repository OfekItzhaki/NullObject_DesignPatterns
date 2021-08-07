using NullObject_DesignPatterns.shared;
using System;
using System.Collections.Generic;
using System.Text;


namespace NullObject_DesignPatterns
{
    public class withNull_Guest : AbstractUser
    {
        public withNull_Guest(string id) : base(id)
        {
            this.id = id;
            name = $"Guest" + id;
            pic = ".assets/images/guestPic.png";
        }

        public withNull_Guest(string id, string name) : base(id, name)
        {
            this.id = id;
            this.name = $"{name} is a Guest, ID: {id}";
        }

        public override string getName()
        {
            return name;
        }

       public override bool isUser()
        {
            return false;
        }
    }
}
