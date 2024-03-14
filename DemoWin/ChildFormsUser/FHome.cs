using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Forms
{
    public partial class FHome : Form
    {
        public FHome()
        {
            InitializeComponent();
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
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
        }

        private void FHome_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnMechanic.Text);
            user.ShowDialog();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnPainter.Text);
            user.ShowDialog();
        }

        private void btnElectrician_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnElectrician.Text);
            user.ShowDialog();
        }
        
        private void btnCarvers_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnCarvers.Text);
            user.ShowDialog();
            
        }

        private void btnCarWashman_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnCarWashman.Text);
            user.ShowDialog();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnOther.Text);
            user.ShowDialog();
        }
    }
}
