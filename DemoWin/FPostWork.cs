using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DemoWin.Worker;

namespace DemoWin
{
    public partial class FPostWork : Form
    {

        public UCTxtWorker UctHireCost
        {
            get { return ucTxtWorker1; }
        }
        public UCTxtWorker UctTimeOfWork { get => ucTxtWorker2; set => ucTxtWorker2 = value; }
        public UCTxtWorker UctDayOfWork { get => ucTxtWorker3; set => ucTxtWorker3 = value; }
        public UCTxtWorker UctJob { get => ucTxtWorker4; set => ucTxtWorker4 = value; }
        public UCTxtWorker UctExperience { get => ucTxtWorker5; set => ucTxtWorker5 = value; }
        public Guna2TextBox TxtDataDescribe { get => txtDataDescribe; set => txtDataDescribe = value; }
        public DataGridView gridViewPostWork { get => dataGridView1; set => dataGridView1 = value; }

        private void load()
        {
            //comboBox1.Text = "Mặc định";
            WokerDAO hsd = new WokerDAO();
            dataGridView1.DataSource = hsd.load();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string[] listTitle = { "Năm kinh nghiêm", "Nhóm công việc", "Ngày làm", "Giờ làm", "Mức lương" };
        public FPostWork()
        {
            InitializeComponent();
        }
        // Khai báo một biến instance để lưu trữ incomeID
        private string _incomeID;

        // Constructor nhận tham số là incomeID và lưu trữ nó vào biến instance _incomeID
        public FPostWork(string incomeID)
        {
            InitializeComponent();
            _incomeID = incomeID;
        }
        private void FPostWork_Load(object sender, EventArgs e)
        {
            int i = 0;
            txtDataDescribe.BorderColor = ThemeColors.PrimaryColor;
            panelBottom.BackColor = ThemeColors.PrimaryColor;
            panelTop.BackColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(UCTxtWorker))
                {
                    UCTxtWorker uc = (UCTxtWorker)previousBtn;
                    uc.lblTitle.Text = listTitle[i];
                    uc.txtData.BorderColor = ThemeColors.PrimaryColor;
                    uc.txtData.ForeColor = ThemeColors.SecondaryColor;
                    uc.lblTitle.ForeColor = ThemeColors.PrimaryColor;
                    i++;
                }
                else if (previousBtn.GetType() == typeof(Label))
                {
                    previousBtn.ForeColor = ThemeColors.PrimaryColor;
                }
            }
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ucTxtWorker1_Load(object sender, EventArgs e)
        {

        }

        private void ucTxtWorker2_Load(object sender, EventArgs e)
        {

        }

        private void ucTxtWorker3_Load(object sender, EventArgs e)
        {

        }

        private void ucTxtWorker4_Load(object sender, EventArgs e)
        {

        }

        private void txtDataDescribe_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Worker wk = new Worker(ThemeColors.IncomeID, ucTxtWorker4.txtData.Text, ucTxtWorker3.txtData.Text, ucTxtWorker2.txtData.Text,
                             ucTxtWorker1.txtData.Text, ucTxtWorker5.txtData.Text, txtDataDescribe.Text);
            WokerDAO HSD = new WokerDAO();
            HSD.PostWork(wk);
            load();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Worker wk = new Worker(ThemeColors.IncomeID, ucTxtWorker4.txtData.Text, ucTxtWorker3.txtData.Text, ucTxtWorker2.txtData.Text,
                             ucTxtWorker1.txtData.Text, ucTxtWorker5.txtData.Text, txtDataDescribe.Text);
            WokerDAO HSD = new WokerDAO();
            HSD.DeleteWork(wk);
            load();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Worker wk = new Worker(ThemeColors.IncomeID, ucTxtWorker4.txtData.Text, ucTxtWorker3.txtData.Text, ucTxtWorker2.txtData.Text,
                             ucTxtWorker1.txtData.Text, ucTxtWorker5.txtData.Text, txtDataDescribe.Text);
            WokerDAO HSD = new WokerDAO();
            //HSD.RepairWork(wk);
            load();
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
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool isBtnWorkOfDay = false;

        private void RollBtnDayOfWork_Tick(object sender, EventArgs e)
        {
            ExpandButton(ref isBtnWorkOfDay, PanelComboWorkOfDay, btnWorkOfDay, RollBtnDayOfWork);
        }

        private void btnWorkOfDay_Click(object sender, EventArgs e)
        {
            RollBtnDayOfWork.Start();
        }
    }
}
