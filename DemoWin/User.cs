using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoWin
{
    public class User : Person
    {
        private string hireID;
        private string hireName;
        private string vote;
        private string comment;

        public User(string id, string name, string sex, string phone,
            string address, string cccd, string date, string email,
            string acNumber, string surplus,string hireID, string hireName,
            string vote, string comment)
            : base(id, name, sex, phone, address, cccd, date, email, acNumber, surplus)
        {
            this.hireID = hireID;
            this.hireName = hireName;
            this.vote = vote;
            this.comment = comment;
        }

        public User(string id, string name, string sex, string phone,
            string address, string cccd, string date, string email, 
            string acNumber, string surplus) 
            : base(id, name, sex, phone, address, cccd, date, email, acNumber, surplus)
        {
        }
        public User(string id, string name, string email, string account, string pass, string role) : base(id,name,email,account,pass,role)
        {
           
        }

        public string HireID { get => hireID; set => hireID = value; }
        public string HireName { get => hireName; set => hireName = value; }
        public string Vote { get => vote; set => vote = value; }
        public string Comment { get => comment; set => comment = value; }
    }
}