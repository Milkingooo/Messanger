using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Messanger
{
    class Message
    {
        private int id;
        private string text;

        private User sender;
        private User reciever;

        private Contact contact;

        private HorizontalAlignment alignment;

        private DateTime date;

        public Message(int id, string text, User sender, User reciever, Contact contact, int userId)
        {
            this.id = id;
            this.text = text;
            this.sender = sender;
            this.reciever = reciever;
            this.contact = contact;

            if (userId == sender.ID)
            {
                alignment = HorizontalAlignment.Right;
            }
            else
            {
                alignment = HorizontalAlignment.Left;
            }

            date = new DateTime();
        }

        public string Text
        {
            get
            {
                return this.text;
            }
        }

        public string Date
        {
            get
            {
                return $"{date.Day}.{date.Month}.{date.Year}";
            }
        }

        public HorizontalAlignment Alignment
        {
            get
            {
                return this.alignment;
            }
        }

        public User Sender
        {
            get
            {
                return this.sender;
            }
        }

        public User Reciever
        {
            get
            {
                return this.reciever;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }
        }
    }
}
