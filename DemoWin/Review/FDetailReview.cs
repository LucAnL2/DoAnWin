using DemoWin.Review;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FDetailReview : Form
    {
        public FDetailReview()
        {
            InitializeComponent();
        }

        private void FDetailReview_Load(object sender, EventArgs e)
        {
            //for (int i = 0; i < 3; i++)
            //{
            //    UCSendDetailReview uCSendDetailReview = new UCSendDetailReview();
            //    flowLayoutPanel1.Controls.Add(uCSendDetailReview);
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

            string hiredID = FWorkerDetail.hiredID;
            MessageBox.Show(hiredID);

            // Xóa hết các UCWorkerInfo cũ ra khỏi flowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            string query = string.Format("SELECT DanhGia.TenNguoiThue, DanhGiaNguoiLam, BinhLuan, NgayDanhGia, HinhAnh,HinhAnh2,HinhAnh3 " +
                "FROM DanhGia INNER JOIN DangViec ON DanhGia.IDNguoiDuocThue = DangViec.ID " +
                "WHERE DanhGia.IDNguoiDuocThue = N'{0}' ", hiredID);

            //MessageBox.Show(query);

            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo một đối tượng UCDetailReview mới
                            UCDetailReview uc = new UCDetailReview();

                            // Hiển thị dữ liệu lên các control trong UCDetailReview
                            uc.lblUserName.Text = reader["TenNguoiThue"].ToString();
                            uc.guna2txtVote.Text = reader["DanhGiaNguoiLam"].ToString();
                            uc.txtData.Text = reader["BinhLuan"].ToString();
                            uc.lblDate.Text = reader["NgayDanhGia"].ToString();

                            // Kiểm tra xem cột HinhAnh1 có dữ liệu hay không trước khi chuyển đổi
                            if (reader["HinhAnh"] != DBNull.Value)
                            {
                                byte[] imageData1 = (byte[])reader["HinhAnh"];
                                Image image1 = ByteArrayToImage(imageData1);
                                uc.pictureBox1.Image = image1;
                            }
                            else
                            {
                                // Nếu không có dữ liệu hình ảnh, hiển thị hình ảnh mặc định
                                uc.pictureBox1.Image = Properties.Resources.Logo1; // DefaultImage là hình ảnh mặc định trong dự án
                            }

                            if (reader["HinhAnh2"] != DBNull.Value)
                            {
                                byte[] imageData2 = (byte[])reader["HinhAnh2"];
                                Image image2 = ByteArrayToImage(imageData2);
                                uc.pictureBox2.Image = image2;
                            }
                            else
                            {
                                uc.pictureBox2.Image = Properties.Resources.Logo1; // DefaultImage là hình ảnh mặc định trong dự án
                            }

                            if (reader["HinhAnh3"] != DBNull.Value)
                            {
                                byte[] imageData3 = (byte[])reader["HinhAnh3"];
                                Image image3 = ByteArrayToImage(imageData3);
                                uc.pictureBox3.Image = image3;
                            }
                            else
                            {
                                uc.pictureBox3.Image = Properties.Resources.Logo1; // DefaultImage là hình ảnh mặc định trong dự án
                            }

                            flowLayoutPanel1.Controls.Add(uc);
                        }

                    }
                }
            }
        }
    }
}

   




