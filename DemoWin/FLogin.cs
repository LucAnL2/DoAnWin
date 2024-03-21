using DemoWin.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DemoWin
{
    public partial class FLogin : Form
    {
        Modify modify = new Modify();
        public FLogin()
        {
            InitializeComponent();
        }
        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FForgotPassword forgotPassword = new FForgotPassword();
            forgotPassword.ShowDialog();
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            FRegister register = new FRegister();
            register.ShowDialog();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.White;
            string userName = txtUserName.Text;
            string password = txtPassword.Text;
            if (userName.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản !!!"); btnLogin.BackColor = Color.FromArgb(51, 51, 76); return; }
            else if (password.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu !!!"); btnLogin.BackColor = Color.FromArgb(51, 51, 76); return; }
            else
            {
                string query;
                if (rbtnUser.Checked)
                    query = "Select * from NguoiDung2 where TenTaiKhoan = '"+userName+"' and MatKhau = '"+password+"'";
                else if (rbtnWorker.Checked)
                    query = "Select * from Worker where TenTaiKhoan = '" + userName + "' and MatKhau = '" + password + "'";
                else if (rbtnWorker.Checked == false && rbtnUser.Checked == false) { MessageBox.Show("Vui lòng chọn vai trò !!!"); btnLogin.BackColor = Color.FromArgb(51, 51, 76); return; }
                else { MessageBox.Show("Vui lòng chỉ chọn một vai trò !!!"); btnLogin.BackColor = Color.FromArgb(51, 51, 76); return; }
                if (modify.Accounts(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.BackColor = Color.FromArgb(51, 51, 76);
                    this.Hide();
                    //string tenTK = txtUserName.Text;
                    //string incomeID = "SELECT id FROM Worker2 WHERE TenTaiKhoan = '" + tenTK + "'";
                    //MessageBox.Show(incomeID);
                    //FPostWork fPostWork = new FPostWork(incomeID);

                    if (rbtnUser.Checked)
                    {
                        FUsers user = new FUsers();
                        user.ShowDialog();
                    }
                    else if (rbtnWorker.Checked)
                    {
                        string queryneo = "Select * from Worker where TenTaiKhoan = '" + userName + "'";
                        ThemeColors.IncomeID = modify.Accounts(queryneo)[0].UserName;
                        //MessageBox.Show(ThemeColors.IncomeID);
                        FWorker worker = new FWorker();
                        worker.ShowDialog();
                        
                    }
                    //this.Close();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLogin.BackColor = Color.FromArgb(51, 51, 76);
                }
            }
        }
        
        private void FLogin_Load(object sender, EventArgs e)
        {
            Clock.Start();
        }
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
        }
        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblClock_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void rbtnWorker_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
