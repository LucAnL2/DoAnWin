using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace DemoWin.ChildFormsWorker
{
    public partial class FWokerInfo : Form
    {
        private string[] listTitle = { "ID", "Tên", "Ngày sinh", "Giới tính", "Địa chỉ", "CCCD", "Số ĐT", "Email", "Tài khoản", "Mật khẩu" };
        private string[] listData = { "2030442", "Phạm D", "12/12/2002", "Nam", "Hà Nội", "07220400", "03xxxxxx14", "D123@gmail.com", "Worker", "xxxxxx" };
        public FWokerInfo()
        {
            InitializeComponent();
        }
        private void FWokerInfo_Load(object sender, EventArgs e)
        {
            int i =9;
            picWorkerCard.IconColor = ThemeColors.PrimaryColor;
            panelRight.BackColor = ThemeColors.PrimaryColor;
            foreach (Control previousBtn in this.Controls)
            {
                if (previousBtn.GetType() == typeof(UCTxtWorker))
                {
                    UCTxtWorker uc = (UCTxtWorker)previousBtn;
                    uc.lblTitle.Text = listTitle[i];
                    uc.txtData.Text = listData[i];
                    uc.txtData.BorderColor = ThemeColors.PrimaryColor;
                    uc.txtData.ForeColor = ThemeColors.SecondaryColor;
                    uc.lblTitle.ForeColor = ThemeColors.PrimaryColor;
                    i--;
                }
            }
        }

        private void ucTxtWorker10_Load(object sender, EventArgs e)
        {

        }

        private void ucTxtWorker8_Load(object sender, EventArgs e)
        {

        }
    }
}
