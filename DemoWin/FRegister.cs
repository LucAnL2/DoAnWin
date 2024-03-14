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

namespace DemoWin
{
    public partial class FRegister : Form
    {
        Modify modify = new Modify();
        PaintColor makeColor = new PaintColor();
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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string confirmPassword = txtConfirmPassword.Text;
            makeColor.ActivateButton(sender);
            if (!CheckAccount(userName)) { MessageBox.Show("Vui lòng nhập tài khoản từ năm ký tự trở lên bao gồm của chữ và sô !!!"); return; }
            if (!CheckAccount(password)) { MessageBox.Show("Vui lòng nhập mật khẩu từ năm ký tự trở lên bao gồm của chữ và sô !!!"); return; }
            if (confirmPassword != password) { MessageBox.Show("Vui lòng nhập chính xác mật khẩu !!!"); return ; }
            if (!CheckEmail(email)) { MessageBox.Show("Email không hợp lệ !!!"); return; }
            if (modify.Accounts("Select * from Account where Email = '" + email + "'").Count != 0) { MessageBox.Show("Email này đã được sử dụng vui lòng dùng Email khác !!!"); return; }
            try
            {
                string query = "Insert into Account values ('" + userName + "','" + password + "','" + email + "')";
                modify.Command(query);
                if (MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập luôn không?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch 
            {
                MessageBox.Show("Tài khoản này đã tồn tại !!!");
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
