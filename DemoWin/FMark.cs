using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FMark : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FMark()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void FMark_Load(object sender, EventArgs e)
        {
            LoadDataIntoTextBoxes();
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void LoadDataIntoTextBoxes()
        {
            string query =  string.Format("select DanhDau.IDNguoiDung, DanhDau.IDTho, Worker.Ten, Worker.ID, Worker.Email\r\nfrom DanhDau\r\ninner join Worker on DanhDau.IDTho = Worker.ID\r\nwhere DanhDau.IDNguoiDung = N'{0}'", ThemeColors.IncomeID);
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
                                UCMark uc = new UCMark();
                                uc.lblName.Text = reader["Ten"].ToString();
                                uc.lblID.Text = reader["ID"].ToString();
                                uc.lblEmail.Text = reader["Email"].ToString();
                                loadWorkerInfo(uc);
                                //connection.Open();
                                //SqlDataAdapter adapter = new SqlDataAdapter(query,connection);
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
        
        public void loadWorkerInfo(UCMark uc)
        {
            uc.Margin = new Padding(35);
            flowPanelContain.Controls.Add(uc);
        }
    }
}
