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
using static DemoWin.Worker;

namespace DemoWin
{
    public partial class UCPostJob : UserControl
    {
        private Random random = new Random();
        private string[] imagePaths;
        string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
        public UCPostJob()
        {
            InitializeComponent();
            string defaultFolderPath = Path.Combine(root, "BackGroundImage"); // Tạo đường dẫn đầy đủ của thư mục hình ảnh
            imagePaths = Directory.GetFiles(defaultFolderPath);
        }

        private void load()
        {
            //comboBox1.Text = "Mặc định";
            WokerDAO hsd = new WokerDAO();
            FPostWork newPostWork = new FPostWork();

            newPostWork.gridViewPostWork.DataSource = hsd.load();
        }
        private void btnDeleteJob_Click(object sender, EventArgs e)
        {
            Worker worker = new Worker(ThemeColors.IncomeID, lblGroupWorkData.Text);
            WokerDAO workerDAO = new WokerDAO();
            workerDAO.DeleteWork(worker);
        }

        private void UCPostJob_Load(object sender, EventArgs e)
        {
            string randomImagePath = imagePaths[random.Next(imagePaths.Length)];
            Image randomImage = Image.FromFile(randomImagePath);
            picBackGround.Image = randomImage;
        }
    }
}
