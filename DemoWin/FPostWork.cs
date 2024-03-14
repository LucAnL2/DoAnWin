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
    public partial class FPostWork : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        string[] listTitle = { "Nhóm công việc", "Ngày làm", "Giờ làm", "Mức lương" };
        public FPostWork()
        {
            InitializeComponent();
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
                else if(previousBtn.GetType() == typeof(Label))
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
    }
}
