using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DemoWin
{
    public class Person
    {
        public static Random random = new Random();
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
        private string confirmPassword;
        private string role;
        public Person(string id, string name, string sex, string phone, string address, string cccd, 
            string date, string email, string account, string pass)
        {
            this.id = id;
            this.name = name;
            this.sex = sex;
            this.phone = phone;
            this.address = address;
            this.cccd = cccd;
            this.date = date;
            this.email = email;
            this.account = account;
            this.pass = pass;
        }
        public Person(string id, string name, string email, string account, string pass, string confirmPassword, string role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.account = account;
            this.pass = pass;
            this.role = role;
            this.confirmPassword = confirmPassword;
        }
        public Person(string id, string name, string phone) 
        {
            Id = id;
            Name = name;
            Phone = phone;
        }
        //public Person(string id, string name, string date, string sex, string address, string phone, string email,
        //    string cccd, string acNumber, string pass)
        //{
        //    this.id= id;
        //    this.name = name;
        //    this.date= date;
        //    this.sex = sex;
        //    this.address = address;
        //    this.phone = phone;
        //    this.email = email;
        //    this.cccd = cccd;
        //    this.acNumber = acNumber;
        //    this.pass= pass;
        //}

        public Person()
        {
        }
        public Person(string id)
        {
            this.id= id;
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
        public string ConfirmPassword { get => confirmPassword; set => confirmPassword = value; }
        Modify modify = new Modify();
        public static bool checkNullDangKi(Person newPerson)
        {
            Modify modify = new Modify();
            string[] propertiesToCheck = { "ID", "Name", "Account", "Pass", "ConfirmPassword", "Email", "Role" };

            foreach (var propertyName in propertiesToCheck)
            {
                var property = newPerson.GetType().GetProperty(propertyName);
                if (property == null) continue; // Kiểm tra xem thuộc tính có tồn tại không

                if (property.GetValue(newPerson) == null || string.IsNullOrEmpty(property.GetValue(newPerson).ToString()))
                {
                    System.Windows.Forms.MessageBox.Show($"Thuộc tính {propertyName} không được để trống !!!");
                    return false;
                }
                if (property.Name == "Account")
                {
                    string ac = property.GetValue(newPerson).ToString();
                    if (!Regex.IsMatch(ac, "^[a-zA-Z0-9]{5,24}$"))
                    {
                        System.Windows.Forms.MessageBox.Show("Tên tài khoản có ít nhất 5 bao gồm chữ và số");
                        return false;
                    }
                    if (modify.Accounts("Select * from NguoiDung2 where TenTaiKhoan = '" + ac + "'").Count != 0 || modify.Accounts("Select * from Worker where TenTaiKhoan = '" + ac + "'").Count != 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Tên tài khoản này đã được sử dụng vui lòng sử dụng tên tài khoản khác !!!");
                        return false;
                    }
                }
                if (property.Name == "Email")
                {
                    string email = property.GetValue(newPerson).ToString();
                    if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
                    {
                        System.Windows.Forms.MessageBox.Show("Email không hợp lệ !!!");
                        return false;
                    }
                    if (modify.Accounts("Select * from NguoiDung2 where Email = '" + email + "'").Count != 0 || modify.Accounts("Select * from Worker where Email = '" + email + "'").Count != 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Email này đã được sử dụng vui lòng dùng Email khác !!!"); 
                        return false; 
                    }
                    //else
                    //{
                    //    var query1Result = ("SELECT * FROM NguoiDung2 WHERE Email = '" + email + "'");
                    //    var query2Result = ("SELECT * FROM Worker WHERE Email = '" + email + "'");

                    //    if (query1Result.Count() != 0 || query2Result.Count() != 0)
                    //    {
                    //        // Nếu có ít nhất một hàng được trả về từ bất kỳ truy vấn nào, tức là email đã tồn tại trong cơ sở dữ liệu
                    //        System.Windows.Forms.MessageBox.Show("Email đã được sử dụng !!!");
                    //        return false;
                    //    }
                    //}
                    //if (property.Name == "ID")
                    //{
                    //    if (modify.Accounts("Select * from NguoiDung2 where ID = '" + Id + "'").Count != 0 || modify.Accounts("Select * from Worker where ID = '" + Id + "'").Count != 0)
                    //    {
                    //        Id = Id + 100;
                    //    }
                    //}
                }
            }
            return true;
        }

        public static string CreateID(ComboBox cbbVaiTro)
        {
            Modify modify = new Modify();
            string id;

            if (cbbVaiTro.Text == "Người dùng")
                id = (100000 + random.Next(1, 101)).ToString();
            else
                id = (200000 + random.Next(1, 101)).ToString();
            while (modify.Accounts("Select * from NguoiDung2 where ID = '" + id + "'").Count != 0 || modify.Accounts("Select * from Worker where ID = '" + id + "'").Count != 0)
            {
                long temp = Int32.Parse(id) + 100;
                id = temp.ToString();
            }
            return id;
        }
      
      
    }
    
}
