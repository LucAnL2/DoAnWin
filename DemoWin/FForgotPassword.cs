using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FForgotPassword : Form
    {
        PaintColor makeColor = new PaintColor();
        public FForgotPassword()
        {
            InitializeComponent();
            lblResult.Text = "Mật khẩu: ";
        }
        Modify modify = new Modify();
        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void FForgotPassword_Load(object sender, EventArgs e)
        {
            Clock.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnGetPassword_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            makeColor.ActivateButton(sender);
            if (email.Trim() == "") { MessageBox.Show("Vui lòng nhập Email!"); }
            else
            {
                string query = "Select * from Account where Email = '" + email + "'";
                if (modify.Accounts(query).Count != 0)
                {
                    lblResult.ForeColor = Color.Gainsboro;
                    lblResult.Text = "Mật khẩu: " + modify.Accounts(query)[0].UserName;
                }
                else
                {
                    lblResult.ForeColor = Color.Gainsboro;
                    lblResult.BackColor = Color.FromArgb(51, 51, 76);
                    lblResult.Text = "Email này chưa được đăng ký! ";
                }
            }
        }
    }
}
