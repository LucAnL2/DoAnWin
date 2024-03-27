using DemoWin.Forms;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DemoWin
{
    public partial class FHire : Form
    {
        private bool isbtnHaNoi = false;
        private bool isbtnTpHCM = false;
        private bool isbtnHue = false;
        private bool isbtnNoiKhac = false;
        private bool isbtn1618 = false;
        private bool isbtn1825 = false;
        private bool isbtn25 = false;
        private bool isbtn8Tr = false;
        private bool isbtn810Tr = false;
        private bool isbtn1020Tr = false;
        private bool isbtn20Tr = false;
        private bool isbtn1Sao = false;
        private bool isbtn2Sao = false;
        private bool isbtn3Sao = false;
        private bool isbtn4Sao = false;
        private bool isbtn5Sao = false;
        private bool isbtnMonday = false;
        private bool isbtnTuesday = false;
        private bool isbtnWednesday = false;
        private bool isbtnThursday = false;
        private bool isbtnFriday = false;
        private bool isbtnSaturday = false;
        private bool isbtn7h10h30 = false;
        private bool isbtn12h305h = false;
        private bool isbtnOvertime = false;
        public static Form activeForm;
        string[] listTho = { "Thợ máy", "Thợ sơn", "Thợ sửa xe", "Thợ điện","Thợ điêu khắc" };
        public FHire()
        {
            InitializeComponent();
        }
        public FHire(string title)
        {
            InitializeComponent();
            lblTitle.Text = title;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FHome.panelContain.Visible = false;
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FHire_Load(object sender, EventArgs e)
        {
            ChangeColor();
            LoadDataIntoTextBoxes();
        }
        public void LoadDataIntoTextBoxes()
        {
            string query = "";
            if (listTho.Contains(lblTitle.Text))
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.SDT, DangViec.NgheNghiep, Worker.DanhGiaTrungBinh\r\n" +
                    "from Worker\r\ninner join DangViec on Worker.ID = DangViec.ID " +
                    "where DangViec.NgheNghiep = N'{0}'", lblTitle.Text);
            }
            else
            {
                query = string.Format("select Worker.ID, Worker.Ten, Worker.SDT, DangViec.NgheNghiep, Worker.DanhGiaTrungBinh\r\n" +
                    "from Worker\r\ninner join DangViec on Worker.ID = DangViec.ID " +
                    "where DangViec.NgheNghiep != N'Thợ máy' and DangViec.NgheNghiep != N'Thợ sơn' and DangViec.NgheNghiep != N'Thợ sửa xe' and DangViec.NgheNghiep != N'Thợ điện' and DangViec.NgheNghiep != N'Thợ điêu khắc'");
            }
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
                                uc.btnDetail.Click += btnOpenDetail_Click;
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
            flowLayoutPanel.Controls.Add(uc);
        }
        private void ChangeColor()
        {
            foreach (Control previousBtn in flowLayoutPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Label) || previousBtn.GetType() == typeof(Button) || previousBtn.GetType() == typeof(UCWorkerInfo))
                {
                    previousBtn.BackColor = ThemeColors.PrimaryColor;
                    if(previousBtn.Text == "")
                        previousBtn.BackColor = ThemeColors.PrimaryColor;
                }
            }
            txtSearch.BorderColor = ThemeColors.PrimaryColor;
            btnSearch.FillColor = ThemeColors.PrimaryColor;
            //
            ChangeColorComboButton(PanelComboAge, ThemeColors.PrimaryColor);
            ChangeColorComboButton(PanelComboAddress, ThemeColors.PrimaryColor);
            ChangeColorComboButton(PanelComboRate, ThemeColors.PrimaryColor);
            ChangeColorComboButton(PanelComboHireCost, ThemeColors.PrimaryColor);
            ChangeColorComboButton(PanelComboWorkDay, ThemeColors.PrimaryColor);
            ChangeColorComboButton(PanelComboWorkHour, ThemeColors.PrimaryColor);
            //
            panelMenu.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, +0.3);
            panelTop.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, +0.3);
            panelButtom.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, +0.3);
            btnBack.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, +0.3);
            btnHelp.BackColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, +0.3);
        }
        private void ChangeColorComboButton(FlowLayoutPanel panel, Color color)
        {
            foreach (Control previousBtn in panel.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.ForeColor = color;
                    IconButton iconButton = (IconButton)previousBtn; // Ép kiểu về IconButton
                    iconButton.IconColor = color; // Gán giá trị cho thuộc tính IconColor
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nhấn vào nhân viên bạn muốn thuê trong bảng hoặc nhập vào Id của người đó và nhấn nút thuê sau đó nhấn yes để thuê","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
        bool isBtnAgeExpand = false;
        private void RollBtnAge_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnAgeExpand, PanelComboAge, btnAge, RollBtnAge);
        }
        private void btnAge_Click(object sender, EventArgs e)
        {
            RollBtnAge.Start();
        }
        bool isBtnAddressExpand = false;
        private void RollBtnAddress_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnAddressExpand, PanelComboAddress, btnAddress, RollBtnAddress);
        }

        private void btnAddress_Click(object sender, EventArgs e)
        {
            RollBtnAddress.Start();
        }
        bool isBtnRateExpand = false;
        private void RollBtnRate_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnRateExpand, PanelComboRate, btnRate, RollBtnRate);
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            RollBtnRate.Start();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void CheckButtonActivate(ref bool check, IconButton iconButton)
        {
            if (check == false)
            {
                iconButton.IconChar = IconChar.SquareCheck;
                check = true;
            }
            else
            {
                iconButton.IconChar = IconChar.Square;
                check = false;
            }
        }
        public string CreateQueryFilter()
        {
            StringBuilder query = new StringBuilder($"SELECT DISTINCT DangViec.ID, Ten, SDT,DangViec.NgheNghiep FROM DangViec INNER JOIN Worker ON Worker.ID = DangViec.ID WHERE NgheNghiep = N'{lblTitle.Text}'");


            // Kiểm tra địa chỉ
            List<string> addressConditions = new List<string>();
            if (isbtnHaNoi)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnHaNoi.Text}'");
            }
            if (isbtnTpHCM)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnTpHCM.Text}'");
            }
            if (isbtnHue)
            {
                addressConditions.Add($"Worker.DiaChi = N'{btnHue.Text}'");
            }
            if (isbtnNoiKhac)
            {
                // Thêm điều kiện cho nơi khác
                addressConditions.Add($"Worker.DiaChi NOT IN (N'{btnHaNoi.Text}', N'{btnTpHCM.Text}', N'{btnHue.Text}')");
            }

            if (addressConditions.Any())
            {
                query.Append(" AND ");
                query.Append(string.Join(" OR ", addressConditions));
            }

            List<string> ageConditions = new List<string>();
            if (isbtn1618)
            {
                ageConditions.Add("YEAR(CONVERT(DATE, Worker.NgaySinh)) BETWEEN 2006 AND 2008");
            }
            if (isbtn1825)
            {
                ageConditions.Add("YEAR(CONVERT(DATE, Worker.NgaySinh)) BETWEEN 1999 AND 2006");
            }
            if (isbtn25)
            {
                ageConditions.Add("YEAR(CONVERT(DATE, Worker.NgaySinh)) > 1999");
            }

            if (ageConditions.Any())
            {
                query.Append(" AND ");
                query.Append(string.Join(" OR ", ageConditions));
            }

            List<string> salary = new List<string>();
            if (isbtn8Tr)
            {
                salary.Add("CONVERT(FLOAT, DangViec.GiaThue * 8 * 30) < 8000");
            }
            if (isbtn810Tr)
            {
                salary.Add("CONVERT(FLOAT, DangViec.GiaThue) *8*30 between 8000 and 10000");
            }
            if (isbtn1020Tr)
            {
                salary.Add("CONVERT(FLOAT, DangViec.GiaThue) *8*30 between 10000 and 20000");
            }
            if (isbtn20Tr)
            {
                salary.Add("CONVERT(FLOAT, DangViec.GiaThue) * 8 * 30 >20000");
            }

            if (salary.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", salary));
                query.Append(")");
            }
            List<string> Rate = new List<string>();
            if (isbtn1Sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 1");
            }
            if (isbtn2Sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 2");
            }
            if (isbtn3Sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 3");
            }
            if (isbtn4Sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) >= 4");
            }
            if (isbtn5Sao)
            {
                Rate.Add("CONVERT(FLOAT, Worker.DanhGiaTrungBinh) = 5");
            }
            if (Rate.Any())
            {
                query.Append(" AND ");
                query.Append(string.Join(" OR ", Rate));
            }
            List<string> WorkOfDay = new List<string>();
            if (isbtnMonday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%2%'");
            }
            if (isbtnTuesday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%3%'");
            }
            if (isbtnWednesday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%4%'");
            }
            if (isbtnThursday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%5%'");
            }
            if (isbtnFriday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%6%'");
            }
            if (isbtnSaturday)
            {
                WorkOfDay.Add("DangViec.NgayLamViec LIKE '%7%'");
            }
            if (WorkOfDay.Any())
            {
                query.Append(" AND ");
                query.Append(string.Join(" AND ", WorkOfDay));
            }
            
            List<string> WorkOfTime = new List<string>();

            if (isbtn7h10h30)
            {
                WorkOfTime.Add("CONVERT(FLOAT, DangViec.GioLam) <= 5");
            }
            if (isbtn12h305h)
            {
                WorkOfTime.Add("CONVERT(FLOAT, DangViec.Giolam) <= 8");
            }
            if (isbtnOvertime)
            {
                WorkOfTime.Add("CONVERT(FLOAT, DangViec.GioLam) > 8");
            }
            if (WorkOfTime.Any())
            {
                query.Append(" AND (");
                query.Append(string.Join(" OR ", WorkOfTime));
                query.Append(")");

            }

            return query.ToString();

        }
        private void btnHaNoi_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnHaNoi, btnHaNoi);

        }


        private void btnTpHCM_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnTpHCM, btnTpHCM);
        }

        private void btnHue_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnHue, btnHue);
        }

        private void btnNoiKhac_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnNoiKhac, btnNoiKhac);
        }

        private void btn1618_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn1618, btn1618);
        }

        private void btn1825_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn1825, btn1825);
        }

        private void btn25_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn25, btn25);
        }

        private void btn8Tr_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn8Tr, btn8Tr);
        }

        private void btn810Tr_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn810Tr, btn810Tr);
        }

        private void btn1020Tr_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn1020Tr, btn1020Tr);
        }

        private void btn20Tr_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn20Tr, btn20Tr);
        }

        private void btn1Sao_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn1Sao, btn1Sao);
        }

        private void btn2Sao_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn2Sao, btn2Sao);
        }

        private void btn3Sao_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn3Sao, btn3Sao);
        }

        private void btn4Sao_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn4Sao, btn4Sao);
        }

        private void btn5Sao_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn5Sao, btn5Sao);
        }
        bool isBtnHireCostExpand = false;
        private void RollBtnHireCost_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnHireCostExpand, PanelComboHireCost, btnHireCost, RollBtnHireCost);
        }

        private void btnHireCost_Click(object sender, EventArgs e)
        {
            RollBtnHireCost.Start();
        }
        bool isBtnWorkDayExpand = false;
        private void RollBtnWorkDay_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnWorkDayExpand, PanelComboWorkDay, btnWorkDay, RollBtnWorkDay);
        }

        private void btnWorkDay_Click(object sender, EventArgs e)
        {
            RollBtnWorkDay.Start();
        }
        bool isBtnWorkHourExpand = false;
        private void RollBtnWorkHour_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnWorkHourExpand, PanelComboWorkHour, btnWorkHour, RollBtnWorkHour);
        }

        private void btnWorkHour_Click(object sender, EventArgs e)
        {
            RollBtnWorkHour.Start();
        }

        private void btnMonday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnMonday, btnMonday);
        }

        private void btnTuesday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnTuesday, btnTuesday);
        }

        private void btnWednesday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnWednesday, btnWednesday);
        }

        private void btnThursday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnThursday, btnThursday);
        }

        private void btnFriday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnFriday, btnFriday);
        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnSaturday, btnSaturday);
        }

        private void btn7h10h30_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn7h10h30, btn7h10h30);
        }

        private void btn12h305h_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtn12h305h, btn12h305h);
        }

        private void btnOvertime_Click(object sender, EventArgs e)
        {
            CheckButtonActivate(ref isbtnOvertime, btnOvertime);
        }
        private void ExpandButton(ref bool isExpand, FlowLayoutPanel flowLayoutPanel, IconButton iconButton, Timer timer)
        {
            if (isExpand == false)
            {
                flowLayoutPanel.Height += 15;
                if (flowLayoutPanel.Height >= flowLayoutPanel.MaximumSize.Height)
                {
                    timer.Stop();
                    isExpand = true;
                }
                iconButton.IconChar = IconChar.ChevronDown;
            }
            else
            {
                flowLayoutPanel.Height -= 15;
                if (flowLayoutPanel.Height <= flowLayoutPanel.MinimumSize.Height)
                {
                    timer.Stop();
                    isExpand = false;
                }
                iconButton.IconChar = IconChar.ChevronRight;
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainDetail.Controls.Add(childForm);
            panelContainDetail.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnOpenDetail_Click(object sender, EventArgs e)
        {
            FWorkerDetail user = new FWorkerDetail();
            user.btnBack.Click += btnCloseDetail_Click;
            OpenChildForm(user, sender);
        }
        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            //FHire_Load(sender, e);
            
            flowLayoutPanel.Visible = true;
            panelContainDetail.Controls.Add(flowLayoutPanel);
            panelContainDetail.Tag = flowLayoutPanel;
            flowLayoutPanel.BringToFront();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Xóa hết các UCWorkerInfo cũ ra khỏi flowLayoutPanel
            flowLayoutPanel.Controls.Clear();
            string query = CreateQueryFilter();
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
                                UCWorkerInfo uc = new UCWorkerInfo();
                                uc.lblName.Text = reader["Ten"].ToString();
                                uc.lblPhone.Text = reader["SDT"].ToString();
                                uc.lblID.Text = reader["ID"].ToString();
                                uc.btnDetail.Click += btnOpenDetail_Click;
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
    }
}
