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
    public partial class FConfirmHire : Form
    {
        public Color IconPicColor { get; set; }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        PaintColor paintColor = new PaintColor();
        public FConfirmHire()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FConfirmHire_Load(object sender, EventArgs e)
        {
            //Color color = paintColor.SelectThemeColors();
            panelBottom.BackColor = ThemeColors.PrimaryColor;
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
            iconPictureBox1.IconColor = ThemeColors.PrimaryColor;
            iconPictureBox2.IconColor = ThemeColors.PrimaryColor;
            lblMonthHire.ForeColor = ThemeColors.PrimaryColor;
            lblYearHire.ForeColor = ThemeColors.PrimaryColor;
            lblSelectHire.ForeColor = ThemeColors.PrimaryColor;
            dateHire.ForeColor = ThemeColors.PrimaryColor;
            txtMonthHire.ForeColor = ThemeColors.PrimaryColor;
            txtYearHire.ForeColor = ThemeColors.PrimaryColor;
            btnCancel.ForeColor = ThemeColors.PrimaryColor;
            btnHire.ForeColor = ThemeColors.PrimaryColor;
            dateHire.BorderColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor,-0.3);
            txtMonthHire.BorderColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, -0.3);
            txtYearHire.BorderColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, -0.3);
            btnCancel.BorderColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, -0.3);
            btnHire.BorderColor = ThemeColors.ChangeColorBrightness(ThemeColors.PrimaryColor, -0.3);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnHire_Click(object sender, EventArgs e)
        {

        }

        private void btnWorkMonth_Click(object sender, EventArgs e)
        {
            panelMonthHire.Show();
        }

        private void btnWorkDay_Click(object sender, EventArgs e)
        {
            panelMonthHire.Hide();
        }

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
