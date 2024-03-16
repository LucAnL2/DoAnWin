using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class UCWorkerInfo : UserControl
    {
        public static Form activeForm;
        private Random random = new Random();
        private string[] imagePaths;
        public UCWorkerInfo()
        {
            InitializeComponent();
            imagePaths = Directory.GetFiles("D:\\DataD\\c#\\DemoWin\\BackGroundImage"); // Thay đường dẫn với thư mục chứa hình ảnh
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
            //panelCotain.Controls.Add(childForm);
            //panelCotain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void USWorkerInfo_Load(object sender, EventArgs e)
        {
            string randomImagePath = imagePaths[random.Next(imagePaths.Length)];
            Image randomImage = Image.FromFile(randomImagePath);
            picBackGround.Image = randomImage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            //FWorkerDetail fWorkerDetail = new FWorkerDetail();
            //fWorkerDetail.ShowDialog();
        }
    }
}
