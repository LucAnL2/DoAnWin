using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace DemoWin
{
    public class User : Person
    {
        private string hireID;
        private string hireName;
        private string vote;
        private string comment;
        private string position;
        private string salary;
        private string address;
        private string require;
        private string workingDay;
        private string workingHour;
        private string describe;
        private string status;
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
        public User(string id, string position, string salary, string address, string require, string workingDay, string workingHour, string describe, string status): base(id)
        {
            Position = position;
            Salary = salary;
            Address = address;
            Require = require;
            WorkingDay = workingDay;
            WorkingHour = workingHour;
            Describe = describe;
            Status = status;
        }
        public User(string id, string name, string sex, string phone,
            string address, string cccd, string date, string email, 
            string acNumber, string surplus) 
            : base(id, name, sex, phone, address, cccd, date, email, acNumber, surplus)
        {
        }
        public User(string id, string name, string email, string account, string pass
            , string confirmPassword, string role) : base(id,name,email,account,pass,confirmPassword,role)
        {
        }
        
        public string HireID { get => hireID; set => hireID = value; }
        public string HireName { get => hireName; set => hireName = value; }
        public string Vote { get => vote; set => vote = value; }
        public string Comment { get => comment; set => comment = value; }
        public string Position { get => position; set => position = value; }
        public string Salary { get => salary; set => salary = value; }
        public string Address1 { get => address; set => address = value; }
        public string Require { get => require; set => require = value; }
        public string WorkingDay { get => workingDay; set => workingDay = value; }
        public string WorkingHour { get => workingHour; set => workingHour = value; }
        public string Describe { get => describe; set => describe = value; }
        public string Status { get => status; set => status = value; }
        public static bool checkNullUserDangViec(User newUser)
        {
            string[] propertiesToCheck = { "Id", "Position", "Salary", "Address", "Require", "WorkingDay", "WorkingHour", "Describe", "Status" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newUser.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newUser) == null || string.IsNullOrEmpty(property.GetValue(newUser).ToString()))
                {
                    MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Experience")
                {
                    int experienceValue;
                    if (!int.TryParse(property.GetValue(newUser).ToString(), out experienceValue))
                    {
                        MessageBox.Show($"Thuộc tính {property.Name} phải là một số nguyên !!!");
                        return false;
                    }
                }
            }
            return true;
        }

    }
}