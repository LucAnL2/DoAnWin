using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Media;
using static DemoWin.Worker;
using System.Xml.Linq;
using System.IO;

namespace DemoWin
{
    public partial class FRegister : Form
    {
        Random random = new Random();
        Modify modify = new Modify();
        PaintColor makeColor = new PaintColor();
        private string[] dataRole = { "Người dùng", "Thợ" };

        public FRegister()
        {
            this.WindowState = FormWindowState.Normal;
            InitializeComponent();
        }
        public bool CheckAccount( string ac)
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{5,24}$");
        }
        public bool CheckEmail( string em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }
        private void load()
        {
            //comboBox1.Text = "Mặc định";
            PerSonDAO psd = new PerSonDAO();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string id = Person.CreateID(cbbVaiTro);
            //while (modify.Accounts("Select * from NguoiDung2 where ID = '" + id + "'").Count != 0 || modify.Accounts("Select * from Worker where ID = '" + id + "'").Count != 0)
            //{
            //    long temp = Int32.Parse(id) + 100;
            //    id = temp.ToString();
            //}
            string name  = txtLastName.Text + " " + txtFirstName.Text;
            Person person = new Person(id, name, txtEmail.Text, txtAccount.Text, txtPassword.Text,txtConfirmPassword.Text, cbbVaiTro.Text);
            PerSonDAO PSD = new PerSonDAO();
            PSD.DangKi(person);
            load();
        }
        private void clock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void FRegister_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            clock.Start();
            cbbVaiTro.DataSource = dataRole;

            load();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
