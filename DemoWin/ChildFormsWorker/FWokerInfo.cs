using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DemoWin.ChildFormsWorker
{
    public partial class FWokerInfo : Form
    {
        private string[] listTitle = { "ID", "Tên", "Số ĐT", "Ngày sinh", "Email", "Giới tính", "Địa chỉ", "CCCD", "Tài khoản", "Mật khẩu" };
        //private string[] listData = { "2030442", "Phạm D", "12/12/2002", "Nam", "Hà Nội", "07220400", "03xxxxxx14", "D123@gmail.com", "Worker", "xxxxxx" };
        //private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=theGioiTho;Integrated Security=True";
        //private string query = "SELECT ID, Ten, NgaySinh, GioiTinh, DiaChi, SDT, Email, CCCD, TenTaiKhoan, MatKhau FROM Worker";
        private string query = "SELECT ID, Ten, NgaySinh, GioiTinh, DiaChi, SDT, Email, CCCD, TenTaiKhoan, MatKhau FROM Worker Where ID = '"+ThemeColors.IncomeID+"'";
        public FWokerInfo()
        {
            InitializeComponent();
        }
        private void FWokerInfo_Load(object sender, EventArgs e)
        {
            int i =9;
            picWorkerCard.IconColor = ThemeColors.PrimaryColor;
            panelRight.BackColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(UCTxtWorker))
                {
                    UCTxtWorker uc = (UCTxtWorker)previousBtn;
                    uc.lblTitle.Text = listTitle[i];
                    //uc.txtData.Text = listData[i];
                    uc.txtData.BorderColor = ThemeColors.PrimaryColor;
                    uc.txtData.ForeColor = ThemeColors.SecondaryColor;
                    uc.lblTitle.ForeColor = ThemeColors.PrimaryColor;
                    i--;
                }
            }
            LoadDataIntoTextBoxes();
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

                            ucTxtWorkerID.txtData.Text = reader["ID"].ToString();
                            ucTxtWorkerName.txtData.Text = reader["Ten"].ToString();
                            ucTxtWorkerPhone.txtData.Text = reader["SDT"].ToString();
                            ucTxtWorkerDate.txtData.Text = reader["NgaySinh"].ToString();
                            ucTxtWorkerEmail.txtData.Text = reader["Email"].ToString();
                            ucTxtWorkerSex.txtData.Text = reader["GioiTinh"].ToString();
                            ucTxtWorkerAddress.txtData.Text = reader["DiaChi"].ToString();
                            ucTxtWorkerCCCD.txtData.Text = reader["CCCD"].ToString();
                            ucTxtWorkerAccount.txtData.Text = reader["TenTaiKhoan"].ToString();
                            ucTxtWorkerPass.txtData.Text = reader["MatKhau"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu được trả về!");
                        }
                    }
                }
            }
        }
        private void ucTxtWorker10_Load(object sender, EventArgs e)
        {

        }

        private void ucTxtWorker8_Load(object sender, EventArgs e)
        {

        }
        
        private void btnUpdateInfo_Click(object sender, EventArgs e)
        {
            Worker wk = new Worker(ThemeColors.IncomeID, ucTxtWorkerName.txtData.Text, ucTxtWorkerSex.txtData.Text,
                                    ucTxtWorkerPhone.txtData.Text, ucTxtWorkerAddress.txtData.Text, ucTxtWorkerCCCD.txtData.Text,
                                    ucTxtWorkerDate.txtData.Text, ucTxtWorkerEmail.txtData.Text, ucTxtWorkerAccount.txtData.Text,
                                       ucTxtWorkerPass.txtData.Text);
            //MessageBox.Show(ucTxtWorkerEmail.txtData.Text);
            WokerDAO HSD = new WokerDAO();
            HSD.updateInfo(wk);
            LoadDataIntoTextBoxes();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
        public bool checkNullTextBox()
        {
            LoadDataIntoTextBoxes();
            Worker wk = new Worker(ThemeColors.IncomeID, ucTxtWorkerName.txtData.Text, ucTxtWorkerSex.txtData.Text,
                                   ucTxtWorkerPhone.txtData.Text, ucTxtWorkerAddress.txtData.Text, ucTxtWorkerCCCD.txtData.Text,
                                   ucTxtWorkerDate.txtData.Text, ucTxtWorkerEmail.txtData.Text, ucTxtWorkerAccount.txtData.Text,
                                      ucTxtWorkerPass.txtData.Text);
            if (Worker.checkNullInfo(wk))
                return true;
            return false;
        }
        public void chayChoi()
        {
            MessageBox.Show(ucTxtWorkerName.txtData.Text);
        }
    }
}
