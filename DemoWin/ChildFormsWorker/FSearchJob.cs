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
            string query = string.Format("select NguoiDung2.ID, NguoiDungDangViec.Luong\r\n" +
                    "from NguoiDung2\r\ninner join NguoiDungDangViec on NguoiDung2.ID = NguoiDungDangViec.ID ");
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
                                UCUserJob uc = new UCUserJob();
                                uc.lblSalary.Text = reader["Luong"].ToString();
                                uc.lblID.Text = reader["ID"].ToString();
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
        public void loadWorkerInfo(UCUserJob uc)
        {
            uc.Margin = new Padding(20);
            uc.BackColor = ThemeColors.PrimaryColor;
            flowPanelContain.Controls.Add(uc);
        }

        private void FSearchJob_Load(object sender, EventArgs e)
        {
            LoadDataIntoTextBoxes();
        }
    }
}
