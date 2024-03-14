using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Forms
{
    public partial class FHired : Form
    {
        string[] dataAddress = { "Hà Nội", "Huế", "Tp Hồ Chí Minh", "Nơi khác" };
        string[] dataHireCost = { "Dưới 8tr", "8-10tr", "10-20tr", "Trên 20tr" };
        string[] dataRate = { "1 Sao", "2 Sao", "3 Sao", "4 Sao", "5 Sao" };
        public FHired()
        {
            InitializeComponent();
            cbbAddress.DataSource = dataAddress;
            cbbHirecost.DataSource = dataHireCost;
            cbbRate.DataSource = dataRate;
        }

        private void FHired_Load(object sender, EventArgs e)
        {
            LoadTheme();
            for (int i = 0; i < 3; i++)
            {
                UCWorkerInfo uc = new UCWorkerInfo();
                uc.Margin = new Padding(13);
                uc.BackColor = ThemeColors.PrimaryColor;
                flowPanelContain.Controls.Add(uc);
            }
        }
        private void LoadTheme()
        {
            panelTop.BackColor = ThemeColors.SecondaryColor;
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
            cbbAddress.FillColor = ThemeColors.SecondaryColor;
            cbbHirecost.FillColor = ThemeColors.SecondaryColor;
            cbbRate.FillColor = ThemeColors.SecondaryColor;
        }
    }
}
