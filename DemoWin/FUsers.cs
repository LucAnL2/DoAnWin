using DemoWin.Forms;
using FontAwesome.Sharp;
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
    public partial class FUsers : Form
    {
        private IconButton currentButton;
        private Random random;
        private int tempIndex;
        public static Form activeForm;
        private Panel leftBorderBtn;
        public FUsers()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 49);
            panelMenu.Controls.Add(leftBorderBtn);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private Color SelectThemeColors()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (IconButton)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColors();
                    currentButton = (IconButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                    currentButton.TextAlign = ContentAlignment.MiddleCenter;
                    currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
                    currentButton.ImageAlign = ContentAlignment.MiddleRight;
                    leftBorderBtn.BackColor = ThemeColors.ChangeColorBrightness(color, +0.3); ;
                    leftBorderBtn.Location = new Point(0, currentButton.Location.Y);
                    leftBorderBtn.Visible = true;
                    leftBorderBtn.BringToFront();
                }
            }
        }
        private void DisableButton()
        {
            if (currentButton != null)
            {
                currentButton.BackColor = Color.FromArgb(51, 51, 76);
                currentButton.ForeColor = Color.White;
                currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                currentButton.TextAlign = ContentAlignment.MiddleLeft;
                currentButton.IconColor = Color.White;
                currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentButton.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        private void FUsers_Load(object sender, EventArgs e)
        {
            Clock.Start();
            MakeSpace();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FHome(), sender);
        }

        private void btnHired_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FHired(), sender);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FInfo(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DisableButton();
            Color color = SelectThemeColors();
            currentButton = (IconButton)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentButton.ImageAlign = ContentAlignment.MiddleRight;
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Hide();
                FLogin login = new FLogin();
                login.ShowDialog();
                this.Close();
            }
            DisableButton();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            leftBorderBtn.Visible = false ;
            Reset();
        }
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "WELCOME";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        bool menuExpand = false;
        private void MakeSpace()
        {
            btnHome.Text = "";
            btnHired.Text = "";
            btnUser.Text = "";
            btnLogout.Text = "";
        }
        private void panelMenuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand)
            {
                panelMenu.Width -= 10;
                if (panelMenu.Width <= panelMenu.MinimumSize.Width)
                {
                    menuExpand = false;
                    panelMenuTransition.Stop();

                }
                MakeSpace();
            }
            else
            {
                panelMenu.Width += 10;
                if (panelMenu.Width >= panelMenu.MaximumSize.Width)
                {
                    menuExpand = true;
                    panelMenuTransition.Stop();
                }
                btnHome.Text = "Trang chủ";
                btnHired.Text = "Lịch sử thuê";
                btnUser.Text = "Cá nhân";
                btnLogout.Text = "Đăng xuất";
            }
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            panelMenuTransition.Start();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
