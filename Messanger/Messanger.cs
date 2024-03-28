using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    class Messenger
    {
        private string login = "admin";
        private string password = "12345";

        private List<User> users;
        private List<Message> messages;

        private List<Message> chat;

        private List<Contact> contacts;
        private Contact currentContact;

        private User user;

        public Messenger()
        {
            users = new List<User>();
            contacts = new List<Contact>();
            messages = new List<Message>();
            chat = new List<Message>();
        }

        public Messenger(List<Contact> contacts, List<Message> messages, List<User> users)
        {
            this.users = users;
            this.contacts = contacts;
            this.messages = messages;
            this.chat = new List<Message>();
        }

        public bool Login(string login, string password)
        {
            if (this.login == login && this.password == password)
            {
                LoadUsers();
                user = users[0];

                LoadContacts();

                LoadMessages();

                return true;
            }
            else
            {
                return false;
            }
        }

        private void LoadUsers()
        {
            users.Add(new User(1, "Evgenii", ""));
            users.Add(new User(2, "Victoria", ""));
            users.Add(new User(3, "John", ""));
            users.Add(new User(4, "Boris", ""));
            users.Add(new User(5, "Igor", ""));
        }

        private void LoadMessages()
        {
            //Contact 1
            messages.Add(new Message(1, "Hi!", users[0], users[1], contacts[0], user.ID));
            messages.Add(new Message(2, "Hello.", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(3, "How are you?", users[0], users[1], contacts[0], user.ID));
            messages.Add(new Message(4, "Fine.", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(5, "Is everything okay?", users[0], users[1], contacts[0], user.ID));
            messages.Add(new Message(6, "Yes.", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(7, "Are you sure?", users[0], users[1], contacts[0], user.ID));
            messages.Add(new Message(8, "Yes.", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(9, "If you say so...", users[0], users[1], contacts[0], user.ID));
            messages.Add(new Message(10, "Ah! You never cared about me!", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(11, "Forget my number!", users[1], users[0], contacts[0], user.ID));
            messages.Add(new Message(12, "...", users[0], users[1], contacts[0], user.ID));

            //Contact 2
            messages.Add(new Message(13, "Hello!", users[0], users[2], contacts[1], user.ID));
            messages.Add(new Message(14, "Hello!", users[2], users[0], contacts[1], user.ID));

            //Contact 3
            messages.Add(new Message(15, "Hello! My name is John, would you like to see my goods?", users[3], users[0], contacts[0], user.ID));
            messages.Add(new Message(16, "Um... No, thank you.", users[0], users[3], contacts[0], user.ID));
            messages.Add(new Message(17, "Sad to hear it. Please contact me, if you change your mind.", users[3], users[0], contacts[0], user.ID));
            messages.Add(new Message(18, "I will.", users[0], users[3], contacts[0], user.ID));
        }

        private void LoadContacts()
        {
            contacts.Add(new Contact(1, users[0], users[1], users[0].ID));
            contacts.Add(new Contact(2, users[0], users[2], users[0].ID));
            contacts.Add(new Contact(3, users[0], users[3], users[0].ID));
        }

        public void ChangeContact(int index)
        {
            this.currentContact = this.contacts[index];
        }

        public void LoadChat()
        {
            chat = new List<Message>();

            foreach (Message message in messages)
            {
                if ((currentContact.Users[0] == message.Reciever || currentContact.Users[1] == message.Reciever)
                    && (currentContact.Users[0] == message.Sender || currentContact.Users[1] == message.Sender))
                {
                    chat.Add(message);
                }
            }
        }

        public bool Send(Message message)
        {
            return true;
        }

        public void Update()
        {

        }

        public User User
        {
            get
            {
                return this.user;
            }
        }

        public List<Contact> Contacts
        {
            get
            {
                return this.contacts;
            }
        }

        public Contact CurrentContact
        {
            get
            {
                return this.currentContact;
            }
        }

        public List<Message> Messages
        {
            get
            {
                return this.messages;
            }
        }

        public List<Message> Chat
        {
            get
            {
                return this.chat;
            }
        }
    }
}
