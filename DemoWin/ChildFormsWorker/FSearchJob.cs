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

namespace DemoWin.ChildFormsWorker
{
    public partial class FSearchJob : Form
    {
        public FSearchJob()
        {
            InitializeComponent();
        }
        public void LoadDataIntoTextBoxes()
        {
            string query = string.Format("select Worker.ID, Worker.Ten, Worker.SDT, DangViec.NgheNghiep, Worker.DanhGiaTrungBinh\r\n" +
                    "from Worker\r\ninner join DangViec on Worker.ID = DangViec.ID " +
                    "where DangViec.NgheNghiep = N'{0}'");
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
                                UCWorkerInfo uc = new UCWorkerInfo();
                                uc.lblName.Text = reader["Ten"].ToString();
                                uc.lblPhone.Text = reader["SDT"].ToString();
                                uc.lblID.Text = reader["ID"].ToString();
                                uc.lblRate.Text = reader["DanhGiaTrungBinh"].ToString();
                                //uc.btnDetail.Click += btnOpenDetail_Click;
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
        public void loadWorkerInfo(UCWorkerInfo uc)
        {
            uc.Margin = new Padding(35);
            uc.BackColor = ThemeColors.PrimaryColor;
            flowPanelContain.Controls.Add(uc);
        }
    }
}
