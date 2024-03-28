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
    public partial class FInfo : Form
    {
        public FInfo()
        {
            InitializeComponent();
        }

        private void FInfo_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
            panelBackInfo.BackColor = ThemeColors.PrimaryColor;
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
        }

        private void btnMailBox_Click(object sender, EventArgs e)
        {
            FMailBox mailBox = new FMailBox();
            mailBox.ShowDialog();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            FMark fMark = new FMark();
            fMark.ShowDialog();
        }
    }
}
