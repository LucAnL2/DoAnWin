using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWin
{
    public class Person
    {
        private string id;
        private string name;
        private string sex;
        private string phone;
        private string address;
        private string cccd;
        private string date;
        private string email;
        private string acNumber;
        private string surplus;
        private string account; 
        private string pass; 
        private string role;
        public Person(string id, string name, string sex, string phone, string address, string cccd, string date, string email, string acNumber, string surplus)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.phone = phone;
            this.address = address;
            this.cccd = cccd;
            this.date = date;
            this.email = email;
            this.acNumber = acNumber;
            this.surplus = surplus;
        }
        public Person(string id)
        {
            this.id=id;
        }
        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Sex { get => sex; set => sex = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Cccd { get => cccd; set => cccd = value; }
        public string Date { get => date; set => date = value; }
        public string Email { get => email; set => email = value; }
        public string AcNumber { get => acNumber; set => acNumber = value; }
        public string Surplus { get => surplus; set => surplus = value; }
        public string Account { get => account; set => account = value; }
        public string Pass { get => pass; set => pass = value; }
        public string Role { get => role; set => role = value; }
    }
}
