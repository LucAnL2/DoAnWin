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
        string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public UCWorkerInfo()
        {
            InitializeComponent();
           // imagePaths = Directory.GetFiles("C:\\DoAnWin\\DoAnWin\\BackGroundImage"); // Thay đường dẫn với thư mục chứa hình ảnh
            //string defaultFolderPath = root + "\\BackGroundImage\\";
            //imagePaths = Path.Combine(defaultFolderPath);
            string defaultFolderPath = Path.Combine(root, "BackGroundImage"); // Tạo đường dẫn đầy đủ của thư mục hình ảnh
            imagePaths = Directory.GetFiles(defaultFolderPath);
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
        }
    }
}
