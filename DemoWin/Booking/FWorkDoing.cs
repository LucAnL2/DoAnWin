using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Booking
{
    public partial class FWorkDoing : Form
    {

        public FWorkDoing()
        {
            InitializeComponent();
        }

        private void FWorkDoing_Load(object sender, EventArgs e)
        {
            LoadWorkDoing();// lòa cong viec chua hoàn thành
        }
        void LoadWorkDoing()
        {
            UserDAO userDao = new UserDAO();
            guna2DataGridView1.DataSource = userDao.LoadWorkDoing();

        }
        void LoadWorkComplete()
        {
            UserDAO userDao = new UserDAO();
            guna2DataGridView1.DataSource = userDao.LoadWorkComplete();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xác định chỉ số cột "TrangThaiThue"
            int columnIndex = guna2DataGridView1.Columns["TrangThaiThue"].Index;

            // Kiểm tra xem người dùng đã click vào cột "TrangThaiThue" chưa
            if (e.ColumnIndex == columnIndex && e.RowIndex >= 0)
            {
                // Lấy giá trị hiện tại của ô được click
                string currentValue = guna2DataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value.ToString();

                // Kiểm tra nếu giá trị hiện tại là "đanglam"
                if (currentValue == "Đang làm")
                {
                    // Hiển thị MessageBox để xác nhận
                    DialogResult result = MessageBox.Show("Bạn chắc chắn đã hoàn thành công việc?", "Xác nhận hoàn thành công việc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Kiểm tra kết quả từ MessageBox
                    if (result == DialogResult.Yes)
                    {
                        guna2DataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value = "Hoàn thành";
                    }
                    // Nếu người dùng chọn "No", không làm gì cả
                }
                else
                {
                    if (currentValue == "Hoàn thành")
                    {
                        DialogResult result = MessageBox.Show("Bạn chắc chắn hủy hoàn thành công việc?", "Xác nhận hủy hoàn thành công việc", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.Yes)
                        {
                            guna2DataGridView1.Rows[e.RowIndex].Cells[columnIndex].Value = "Đang làm";
                        }
                    }
                }
            }
        }

        private void cbbStatusJob_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbbStatusJob.Text == "Đang làm")
            {
                LoadWorkDoing();
            }
            else
            {
                LoadWorkComplete();
            }
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            string searchText = guna2TextBox1.Text.ToLower();
            (guna2DataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"IDNguoiThue LIKE '%{searchText}%' or TenNguoiThue LIKE '%{searchText}%' ";
        }
        

    }
}
