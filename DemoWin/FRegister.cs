using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Media;
using static DemoWin.Worker;
using System.Xml.Linq;

namespace DemoWin
{
    public partial class FRegister : Form
    {
        Random random = new Random();
        Modify modify = new Modify();
        PaintColor makeColor = new PaintColor();
        private string[] dataRole = { "Người dùng", "Thợ" };
        public FRegister()
        {
            InitializeComponent();
        }
        public bool CheckAccount( string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{5,24}$");
        }
        public bool CheckEmail( string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void load()
        {
            //comboBox1.Text = "Mặc định";
            PerSonDAO psd = new PerSonDAO();
            dataGridView1.DataSource = psd.load();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id;
            if (cbbVaiTro.Text == "Người dùng")
                id = (100000 + random.Next(1, 101)).ToString();
            else
                id = (200000 + random.Next(1, 101)).ToString();
            //string name = txtLastName.Text + txtFirstName.Text;
            //string userName = txtAccount.Text;
            //string password = txtPassword.Text;
            //string email = txtEmail.Text;
            //string confirmPassword = txtConfirmPassword.Text;
            //Person person = new Person(id, name, txtEmail.Text, txtAccount.Text, txtPassword.Text, cbbVaiTro.Text);
            //makeColor.ActivateButton(sender);
            //if (!CheckAccount(userName)) { MessageBox.Show("Vui lòng nhập tài khoản từ năm ký tự trở lên bao gồm của chữ và sô !!!"); return; }
            //if (!CheckAccount(password)) { MessageBox.Show("Vui lòng nhập mật khẩu từ năm ký tự trở lên bao gồm của chữ và sô !!!"); return; }
            //if (confirmPassword != password) { MessageBox.Show("Vui lòng nhập chính xác mật khẩu !!!"); return ; }
            //if (!CheckEmail(email)) { MessageBox.Show("Email không hợp lệ !!!"); return; }
            //if(person.Role == "Người dùng")
            //    if (modify.Accounts("Select * from NguoiDung2 where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được sử dụng vui lòng dùng Email khác !!!"); return; }
            //else
            //    if (modify.Accounts("Select * from Worker2 where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được sử dụng vui lòng dùng Email khác !!!"); return; }
            //try
            //{
            //    if (person.Role == "Người dùng")
            //    {    
            //        string query = string.Format("Insert into NguoiDung2(ID , Ten, Email, TenTaiKhoan, MatKhau, VaiTro) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}')", person.Id, person.Name, person.Email, person.Account, person.Pass, person.Role);
            //        modify.Command(query);
            //        if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //        {
            //            this.Close();
            //        }
            //    }
            //    else
            //    {
            //        string query = string.Format("Insert into Worker2(ID , Ten, Email, TenTaiKhoan, MatKhau, VaiTro) VALUES ('{0}', '{1}', '{2}','{3}','{4}','{5}')", person.Id, person.Name, person.Email, person.Account, person.Pass, person.Role);
            //        modify.Command(query);
            //        if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            //        {
            //            this.Close();
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Tài khoản này đã tồn tại !!!" + ex);
            //}
            string name  = txtLastName.Text + " " + txtFirstName.Text;
            Person person = new Person(id, name, txtEmail.Text, txtAccount.Text, txtPassword.Text,txtConfirmPassword.Text, cbbVaiTro.Text);
            PerSonDAO PSD = new PerSonDAO();
            PSD.DangKi(person);
            load();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            clock.Start();
            cbbVaiTro.DataSource = dataRole;

            load();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
