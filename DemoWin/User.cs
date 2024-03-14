using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoWin
{
    public class User : Person
    {
        public User(string id, string name, string sex, string phone, string address, string cccd, string date, string email, string acNumber, string surplus) : base(id, name, sex, phone, address, cccd, date, email, acNumber, surplus)
        {
        }
    }
}