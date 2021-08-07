using System;
using System.Collections.Generic;
using System.Text;

namespace NullObject_DesignPatterns.shared
{
    public class User : AbstractUser {

       string address;
        public User(string id, string name) : base(id, name)
        {
            this.id = id;
            this.name = name;
            address = "";
            pic = "./assets/images/userPic.png";
        }

        public User(string id, string name, string address) : base(id, name)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            pic = "./assets/images/userPic.png";
        }


        public string getID()
        {
            return id;
        }

        public override string getName()
        {
            return name;
        }

        public string getAddress()
        {
            return address;
        }

        public string getPic()
        {
            return pic;
        }

        public override bool isUser()
        {
            return true;
        }

    }
}
