﻿using DemoWin.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DemoWin
{
    public partial class FLogin : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private string hireID;
        private string hireName;
        Modify modify = new Modify();

        public string HireID { get => hireID; set => hireID = value; }
        public string HireName { get => hireName; set => hireName = value; }

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
                using (SqlConnection connection = Connection.GetSqlConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    HireID = reader["ID"].ToString();
                                    HireName = reader["Ten"].ToString();
                                    MessageBox.Show(HireID, HireName);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu được trả về!");
                            }
                        }
                    }
                }

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
                        string queryneo = "Select * from NguoiDung2 where TenTaiKhoan = '" + userName + "'";
                        ThemeColors.IncomeID = modify.Accounts(queryneo)[0].UserName;
                        FUsers user = new FUsers();
                        user.ShowDialog();
                    }
                    else if (rbtnWorker.Checked)
                    {
                        string queryneo = "Select * from Worker where TenTaiKhoan = '" + userName + "'";
                        ThemeColors.IncomeID = modify.Accounts(queryneo)[0].UserName;
                        //MessageBox.Show(ThemeColors.IncomeID);
                        FWorkers worker = new FWorkers();
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

                ///// lấy id và mật khẩu nếu đăng nhập thành công
                

            }
        }
        
        private void FLogin_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
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

        private void FLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRegister fRegister = new FRegister();
            fRegister.ShowDialog();
        }
    }
}
