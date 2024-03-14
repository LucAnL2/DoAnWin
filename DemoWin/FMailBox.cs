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
    public partial class FMailBox : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        PaintColor paintColor = new PaintColor();
        public FMailBox()
        {
            InitializeComponent();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FMailBox_Load(object sender, EventArgs e)
        {
            panelMenu.BackColor = ThemeColors.SecondaryColor;
            panelTaskBar.BackColor = ThemeColors.SecondaryColor;
            for (int i = 0; i < 2; i++)
            {
                UCMail uc = new UCMail();
                uc.Margin = new Padding(10);
                uc.BackColor = ThemeColors.PrimaryColor;
                flowPanelContain.Controls.Add(uc);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FMail fMail = new FMail();
            fMail.ShowDialog();
        }
    }
}
