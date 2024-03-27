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

namespace DemoWin.ChildFormsUser
{
    public partial class FUserJob : Form
    {
        public FUserJob()
        {
            InitializeComponent();
        }

        private void FUserPostJob_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadDataIntoTextBoxes();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
            panelRight.BackColor = Color.FromArgb(32, 104, 230);
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
        }

        private void flowLayoutPanelContain_Paint(object sender, PaintEventArgs e)
        {

        }
        public void LoadDataIntoTextBoxes()
        {
            string id = ThemeColors.IncomeID;

            string query = string.Format("select NguoiDung2.Ten, NguoiDungDangViec.ViTri from NguoiDung2, NguoiDungDangViec Where NguoiDung2.ID = '{0}' and NguoiDungDangViec.ID = '{0}'", id);
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
                                UCPostJob job = new UCPostJob();
                                job.lblPersonPostData.Text = reader["Ten"].ToString();
                                job.lblGroupWorkData.Text = reader["ViTri"].ToString();
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
        public void loadPostJob(UCPostJob uc)
        {
            panelRight.BackColor = ThemeColors.PrimaryColor;
            uc.Margin = new Padding(20);
            uc.BackColor = ThemeColors.PrimaryColor;
            flowPanelContain.Controls.Add(uc);
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            FUserPostJob fUserPostJob = new FUserPostJob();
            fUserPostJob.ShowDialog();
        }
    }
}
