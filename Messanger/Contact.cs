using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    class Contact
    {
        private int id;
        private User[] users;
        private string name;

        public Contact(int id, User u1, User u2, int userId)
        {
            this.id = id;
            users = new User[] { u1, u2 };

            if (userId == u1.ID)
            {
                this.name = u2.Name;
            }
            else
            {
                this.name = u1.Name;
            }
        }

        public bool Confirm(User u1, User u2)
        {
            if ((u1.ID == users[0].ID && u2.ID == users[1].ID) || (u1.ID == users[1].ID && u2.ID == users[0].ID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public User[] Users
        {
            get
            {
                return users;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
    }
}

