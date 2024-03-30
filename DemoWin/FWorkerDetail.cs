using DemoWin.Forms;
using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DemoWin
{
    public partial class FWorkerDetail : Form
    { 

        public static string hiredID;
        public static string hiredName;
        string query = "select Worker.Ten, Worker.GioiTinh, Worker.NgaySinh, Worker.Email, Worker.ID, DangViec.NamKinhNghiem, DangViec.GiaThue, DangViec.GioLam, DangViec.NgayLamViec, Worker.DiaChi, Worker.SDT, DangViec.MoTa, DangViec.GiaThue\r\nfrom Worker\r\ninner join DangViec on Worker.ID = DangViec.ID\r\nwhere Worker.ID = '"+ThemeColors.OpenID+"'";
        public FWorkerDetail()
        {
            InitializeComponent();
        }

        private void FWorkerDetail_Load(object sender, EventArgs e)
        {
            ChangeColor();
            LoadDataIntoTextBoxes();
        }
        private void ChangeColor()
        {
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
            iconWorkDay.IconColor = ThemeColors.PrimaryColor;
            iconWorkHour.IconColor = ThemeColors.PrimaryColor;
            iconPhone.IconColor = ThemeColors.PrimaryColor;
            iconHireCost.IconColor = ThemeColors.PrimaryColor;
            iconAddress.IconColor = ThemeColors.PrimaryColor;
            iconMedal.IconColor = ThemeColors.PrimaryColor;
            iconStar.IconColor = ThemeColors.PrimaryColor;
            iconHireTime.IconColor = ThemeColors.PrimaryColor;
            btnBack.BackColor = ThemeColors.PrimaryColor;
            btnBack.FillColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(Label))
                {
                    if (previousBtn.Text == "")
                        previousBtn.BackColor = ThemeColors.PrimaryColor;
                    else
                        previousBtn.ForeColor = ThemeColors.PrimaryColor;
                }
                else if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    previousBtn.ForeColor = ThemeColors.PrimaryColor;
                    Guna2Button Button = (Guna2Button)previousBtn; // Ép kiểu về IconButton
                    Button.BorderColor = ThemeColors.PrimaryColor; // Gán giá trị cho thuộc tính IconColor
                }
                else if (previousBtn.GetType() == typeof(Guna2Panel))
                {
                    previousBtn.ForeColor = ThemeColors.PrimaryColor;
                    Guna2Panel Button = (Guna2Panel)previousBtn; // Ép kiểu về IconButton
                    Button.BorderColor = ThemeColors.PrimaryColor; // Gán giá trị cho thuộc tính IconColor
                    foreach (Control item in previousBtn.Controls)
                    {
                        if (item.GetType() == typeof(Label))
                        { 
                            item.ForeColor = ThemeColors.PrimaryColor;
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //this.Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            FMail mail = new FMail();
            mail.ShowDialog();
        }

        private void FWorkerDetail_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnClose1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void btnHire_Click_1(object sender, EventArgs e)
        {
            FConfirmHire fConfirmHire = new FConfirmHire();
            fConfirmHire.ShowDialog();

           
        }
        private void LoadDataIntoTextBoxes()
        {
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();

                            lblName.Text = reader["Ten"].ToString();
                            lblSex.Text = "Giới tính: " + reader["GioiTinh"].ToString();
                            lblAge.Text = "Tuổi: " + reader["NgaySinh"].ToString();
                            lblEmail.Text = "Email: " + reader["Email"].ToString();
                            lblID.Text = "ID: " + reader["ID"].ToString();
                            lblYearExpirience.Text = "Năm kinh nghiệm: " + reader["NamKinhNghiem"].ToString();
                            lblCostHire.Text = "Mức lương: " + reader["GiaThue"].ToString();
                            lblWorkingHour.Text = "Giờ làm: " + reader["GioLam"].ToString();
                            lblWorkingDay.Text = "Ngày làm việc: " + reader["NgayLamViec"].ToString();
                            lblAddress.Text = "Địa chỉ: " + reader["DiaChi"].ToString();
                            lblPhone.Text = "Số điện thoại: " + reader["SDT"].ToString();
                            lblDescribe.Text = reader["MoTa"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu được trả về!");
                        }
                    }
                }
            }
        }

        private void iconStar_Click(object sender, EventArgs e)
        {
           
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
                                hiredID = reader["ID"].ToString();
                                hiredName = reader["Ten"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu được trả về!");
                        }
                    }
                }
            }
            FDetailReview fDetailReview = new FDetailReview();
            fDetailReview.Show();
           
           
        }
    }
}
