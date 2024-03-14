using FontAwesome.Sharp;
using Guna.UI2.WinForms;
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
    public partial class FWorkerDetail : Form
    {
        PaintColor paintColor = new PaintColor();
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public FWorkerDetail()
        {
            InitializeComponent();
        }

        private void FWorkerDetail_Load(object sender, EventArgs e)
        {
            ChangeColor();
        }
        private void ChangeColor()
        {
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
            iconWorkDay.IconColor = ThemeColors.PrimaryColor;
            iconWorkHour.IconColor = ThemeColors.PrimaryColor;
            iconPhone.IconColor = ThemeColors.PrimaryColor;
            iconHireCost.IconColor = ThemeColors.PrimaryColor;
            iconAddress.IconColor = ThemeColors.PrimaryColor;
            iconMedal.IconColor = ThemeColors.PrimaryColor;
            iconStar.IconColor = ThemeColors.PrimaryColor;
            iconHireTime.IconColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(Label))
                {
                    if (previousBtn.Text == "")
                        previousBtn.BackColor = ThemeColors.PrimaryColor;
                    else
                        previousBtn.ForeColor = ThemeColors.PrimaryColor;
                }
                else if (previousBtn.GetType() == typeof(Guna2Button))
                {
                    previousBtn.ForeColor = ThemeColors.PrimaryColor;
                    Guna2Button Button = (Guna2Button)previousBtn; // Ép kiểu về IconButton
                    Button.BorderColor = ThemeColors.PrimaryColor; // Gán giá trị cho thuộc tính IconColor
                }
                else if (previousBtn.GetType() == typeof(Guna2Panel))
                {
                    previousBtn.ForeColor = ThemeColors.PrimaryColor;
                    Guna2Panel Button = (Guna2Panel)previousBtn; // Ép kiểu về IconButton
                    Button.BorderColor = ThemeColors.PrimaryColor; // Gán giá trị cho thuộc tính IconColor
                    foreach (Control item in previousBtn.Controls)
                    {
                        if (item.GetType() == typeof(Label))
                        { 
                            item.ForeColor = ThemeColors.PrimaryColor;
                        }
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            FMail mail = new FMail();
            mail.ShowDialog();
        }

        private void FWorkerDetail_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void btnClose1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelTaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            FConfirmHire fConfirmHire = new FConfirmHire();
            fConfirmHire.ShowDialog();
        }
    }
}
