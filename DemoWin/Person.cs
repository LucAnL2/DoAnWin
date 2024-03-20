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

        public Person(string id,string name, string email,  string account, string pass, string role) 
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.account = account;
            this.pass = pass;
            this.role = role;
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

        public static bool checkNullDangKi(Person newPerson)
        {
            string[] propertiesToCheck = { "Name", "Email", "Account", "Pass", "Role" };

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
                }
                if (property.Name == "Email")
                {
                    string email = property.GetValue(newPerson).ToString();
                    if (!Regex.IsMatch(email, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$"))
                    {
                        System.Windows.Forms.MessageBox.Show("Email không hợp lệ !!!");
                        return false;
                    }
                    else
                    {
                        var query1Result = ("SELECT * FROM NguoiDung2 WHERE Email = '" + email + "'");
                        var query2Result = ("SELECT * FROM Worker2 WHERE Email = '" + email + "'");

                        if (query1Result.Count() != 0 || query2Result.Count() != 0)
                        {
                            // Nếu có ít nhất một hàng được trả về từ bất kỳ truy vấn nào, tức là email đã tồn tại trong cơ sở dữ liệu
                            System.Windows.Forms.MessageBox.Show("Email đã tồn tại trong cơ sở dữ liệu !!!");
                            return false;
                        }
                    }
                   
                }
            }
            return true;
        }

       
      
        //private void btnRegister_Click(object sender, EventArgs e)
        //{
          
        //    string confirmPassword = txtConfirmPassword.Text;
        //    makeColor.ActivateButton(sender);
        //    if (!CheckAccount(password)) { MessageBox.Show("Vui lòng nhập mật khẩu từ năm ký tự trở lên bao gồm của chữ và sô !!!"); return; }
        //    if (confirmPassword != password) { MessageBox.Show("Vui lòng nhập chính xác mật khẩu !!!"); return; }
        //    if (!CheckEmail(email)) { MessageBox.Show("Email không hợp lệ !!!"); return; }
        //    if (modify.Accounts("Select * from Account where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được sử dụng vui lòng dùng Email khác !!!"); return; }
        //    try
        //    {
        //        string query = "Insert into Account values ('" + userName + "','" + password + "','" + email + "')";
        //        modify.Command(query);
        //        if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
        //        {
        //            this.Close();
        //        }
        //    }
        //    catch
        //    {
        //        MessageBox.Show("Tài khoản này đã tồn tại !!!");
        //    }
        //}
    }
    
}
