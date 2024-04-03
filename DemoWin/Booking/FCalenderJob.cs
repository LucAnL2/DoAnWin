using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Booking
{
    public partial class FCalenderJob : Form
    {
        public Form activeForm1;
        public Form activeForm2;
        public FCalenderJob()
        {
            InitializeComponent();
          
        }
       
        private void FCalenderJob_Load(object sender, EventArgs e)
        {
            FCalender fCalender = new FCalender();
            OpenChildForm(fCalender, guna2Panel1,activeForm1);
            loadInfoToTextBox();
        }
        public void OpenChildForm(Form childForm, Guna2Panel panel, Form activeForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void loadInfoToTextBox()
        {
            FLogin fLogin = Application.OpenForms.OfType<FLogin>().FirstOrDefault();
            if (fLogin != null)
            {
                string hiredID = fLogin.HireID;
                string hiredName = fLogin.HireName;
                string query = string.Format("select * from ThueViec where IDNguoiDuocThue = N'{0}' and TrangThaiThue = N'Chờ xác nhận'", hiredID);
                //MessageBox.Show(query);
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
                                    UCReceiveJob uc = new UCReceiveJob();
                                    uc.txtAddress.Text = reader["DiaChi"].ToString();
                                    uc.txtHireID.Text = reader["IDNguoiThue"].ToString();
                                    uc.txtHireName.Text = reader["TenNguoiThue"].ToString();
                                    uc.txtDay.Text = reader["NgayThue"].ToString();
                                    uc.txtMonth.Text = reader["ThangThue"].ToString();
                                    uc.txtYear.Text = reader["NamThue"].ToString();
                                    uc.txtPhone.Text = reader["SDT"].ToString();
                                    uc.txtJob.Text = reader["CongViecMuonThue"].ToString();
                                    flowLayoutPanel1.Controls.Add(uc);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không có dữ liệu được trả về!");
                            }
                        }
                    }
                }
            }
        }
        public void RefreshFlowLayoutPanel()
        {
            // Clear old controls
            flowLayoutPanel1.Controls.Clear();
            // Load new data
            this.loadInfoToTextBox();
            FCalender fCalender = new FCalender();
            OpenChildForm(fCalender, guna2Panel1, activeForm1);
        }
    }
}
