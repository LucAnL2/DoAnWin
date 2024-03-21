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

namespace DemoWin.ChildFormsWorker
{
    public partial class FWork : Form
    {
        private string connectionString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=theGioiTho;Integrated Security=True";

        public FWork()
        {
            InitializeComponent();
        }
       
        private void FWork_Load(object sender, EventArgs e)
        {
            panelRight.BackColor = ThemeColors.PrimaryColor;
            panelBoundary.BackColor = ThemeColors.PrimaryColor;
            for (int i = 0; i < 2; i++)
            {
                UCPostJob uc = new UCPostJob();
                uc.Margin = new Padding(20);
                uc.BackColor = ThemeColors.PrimaryColor;
                flowPanelContain.Controls.Add(uc);
            }

            LoadDataIntoTextBoxes();
        }
        public void LoadDataIntoTextBoxes()
        {
            string id = ThemeColors.IncomeID;

            string query = string.Format("select Worker.Ten, DangViec.NgheNghiep from Worker, DangViec Where Worker.ID = '{0}' and DangViec.ID = '{0}'", id);
            using (SqlConnection connection = new SqlConnection(connectionString))
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
                                UCPostJob job = new UCPostJob();
                                job.lblPersonPostData.Text = reader["Ten"].ToString();
                                job.lblGroupWorkData.Text = reader["NgheNghiep"].ToString();
                                loadPostJob(job);
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

        public void loadPostJob(  UCPostJob uc)
        {
            panelRight.BackColor = ThemeColors.PrimaryColor;
            panelBoundary.BackColor = ThemeColors.PrimaryColor;
            uc.Margin = new Padding(20);
            uc.BackColor = ThemeColors.PrimaryColor;
            flowPanelContain.Controls.Add(uc);
        }
        private void btnPostJob_Click(object sender, EventArgs e)
        {
            FPostWork postWork = new FPostWork();
            postWork.ShowDialog();
 
        }
    }
}
