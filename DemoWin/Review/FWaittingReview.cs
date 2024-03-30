using DemoWin.Review;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FWaittingReview : Form
    {
        public FWaittingReview()
        {
            InitializeComponent();
        }

        private void FWaittingReview_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 3;i++)
            //{
            //    UCSendDetailReview uCDetailReview = new UCSendDetailReview();
            //    flowLayoutPanel1.Controls.Add(uCDetailReview);
            //}
            LoadReview();
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        void LoadReview()
        {

            FLogin fLogin = Application.OpenForms.OfType<FLogin>().FirstOrDefault();
            if (fLogin != null)
            {
                string hireID = fLogin.HireID;
                MessageBox.Show(hireID);

                // Xóa hết các UCWorkerInfo cũ ra khỏi flowLayoutPanel
                flowLayoutPanel1.Controls.Clear();

                string query = string.Format("select DangViec.ID, Ten , SDT,DangViec.IDNguoiThue from DangViec inner join worker on DangViec.ID = Worker.ID" +
                    " where DangViec.IDNguoiThue = N'{0}' and DangViec.TrangThai = N'{1}'", hireID, "Hoàn thành");

                MessageBox.Show(query);

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
                                    UCWaittingReiew uc = new UCWaittingReiew();
                                    uc.lblName.Text = reader["Ten"].ToString();
                                    uc.lblPhone.Text = reader["SDT"].ToString();
                                    uc.lblID.Text = reader["ID"].ToString();
                                    flowLayoutPanel1.Controls.Add(uc);
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
             
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
