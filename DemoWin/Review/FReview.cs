using System;
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

namespace DemoWin.Review
{
    public partial class FReview : Form
    {
        private static string stringConnection = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=theGioiTho;Integrated Security=True";

        string hiredID;
        string hiredName;
        public FReview()
        {
            InitializeComponent();
        }
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox3.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            hiredID =   UCWaittingReiew.id;
            hiredName = UCWaittingReiew.name;
            MessageBox.Show(hiredID, hiredName);

            //using (SqlConnection conn = GetSqlConnection())
            //{
            byte[] b = ImageToByteArray(pictureBox1.Image);
            byte[] b2 = ImageToByteArray(pictureBox2.Image);
            byte[] b3 = ImageToByteArray(pictureBox3.Image);

            FLogin fLogin = Application.OpenForms.OfType<FLogin>().FirstOrDefault();
            if (fLogin != null)
            {
                string hireID = fLogin.HireID;
                string hireName = fLogin.HireName;
                // Sử dụng hireID và hireName ở đây
                //string sqlStr = string.Format("INSERT INTO DanhGia (IDNguoiThue,TenNguoiThue,IDNguoiDuocThue,TenNguoiDuocThue,DanhGiaNguoiLam,BinhLuan,NgayDanhGia,HinhAnh)" +
                //        "VALUES (N'{0}', N'{1}',N'{2}', N'{3}',N'{4}', N'{5}',N'{6}', '{7}')", hireID, hireName, hiredID, hiredName,guna2txtVote.Text,txtData.Text,lblDate.Text, b);
                //try
                //{
                //    using (SqlConnection connection = GetSqlConnection())
                //    {
                //        connection.Open();
                //        SqlCommand cmd2 = new SqlCommand(sqlStr, connection);
                //        if (cmd2.ExecuteNonQuery() > 0)
                //            MessageBox.Show("Thao tác thành công");
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Thao tác thất bại: " + ex.Message);
                //}
                //finally
                //{
                //    using (SqlConnection connection = GetSqlConnection())
                //    {
                //        connection.Close();
                //    }
                //}
                string sqlStr = "INSERT INTO DanhGia (IDNguoiThue,TenNguoiThue,IDNguoiDuocThue,TenNguoiDuocThue,DanhGiaNguoiLam,BinhLuan,NgayDanhGia,HinhAnh) " +
                "VALUES (@HireID, @HireName, @HiredID, @HiredName, @DanhGiaNguoiLam, @BinhLuan, @NgayDanhGia, @HinhAnh)";
                using (SqlConnection connection = GetSqlConnection())
                {
                    connection.Open();
                    SqlCommand cmd2 = new SqlCommand(sqlStr, connection);
                    cmd2.Parameters.AddWithValue("@HireID", hireID);
                    cmd2.Parameters.AddWithValue("@HireName", hireName);
                    cmd2.Parameters.AddWithValue("@HiredID", hiredID);
                    cmd2.Parameters.AddWithValue("@HiredName", hiredName);
                    cmd2.Parameters.AddWithValue("@DanhGiaNguoiLam", guna2txtVote.Text);
                    cmd2.Parameters.AddWithValue("@BinhLuan", txtData.Text);
                    cmd2.Parameters.AddWithValue("@NgayDanhGia", lblDate.Text);
                    cmd2.Parameters.AddWithValue("@HinhAnh", b);
                    cmd2.Parameters.AddWithValue("@HinhAnh2", b2);
                    cmd2.Parameters.AddWithValue("@HinhAnh3", b3);

                    if (cmd2.ExecuteNonQuery() > 0)
                        MessageBox.Show("Thao tác thành công");
                }

            }
        }

        private void FReview_Load(object sender, EventArgs e)
        {
            FLogin fLogin = Application.OpenForms.OfType<FLogin>().FirstOrDefault();
            lblUserName.Text = fLogin.HireName;
            lblDate.Text = DateTime.Now.ToString();
        }
    }
}
