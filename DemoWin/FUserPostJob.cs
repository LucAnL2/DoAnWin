using DemoWin.ChildFormsUser;
using DemoWin.ChildFormsWorker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FUserPostJob : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string[] listTitle = { "Lương", "Địa chỉ", "Yêu cầu", "Ngày làm", "Giờ làm", "Công việc" };
        public FUserPostJob()
        {
            InitializeComponent();
        }

        private void FUserPostJob_Load(object sender, EventArgs e)
        {
            int i = 5;
            txtDataDescribe.BorderColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(UCTxtWorker))
                {
                    UCTxtWorker uc = (UCTxtWorker)previousBtn;
                    uc.lblTitle.Text = listTitle[i];
                    uc.txtData.BorderColor = ThemeColors.PrimaryColor;
                    uc.txtData.ForeColor = ThemeColors.SecondaryColor;
                    uc.lblTitle.ForeColor = ThemeColors.PrimaryColor;
                    i--;
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

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            User user = new User(ThemeColors.IncomeID, ucTxtPosition.txtData.Text, ucTxtSalary.txtData.Text, ucTxtAddress.txtData.Text,
                 ucTxtRequire.txtData.Text, ucTxtWorkDay.txtData.Text, ucTxtWorkHour.txtData.Text,txtDataDescribe.Text, "Đang chờ");
            UserDAO usd = new UserDAO();
            usd.PostWork(user);
            FUserJob fupj = new FUserJob();
            fupj.LoadDataIntoTextBoxes();
        }
    }
}
