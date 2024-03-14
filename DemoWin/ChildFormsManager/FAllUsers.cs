using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DemoWin.FManager;

namespace DemoWin.ChildFormsManager
{
    public partial class FAllUsers : Form
    {
        public FAllUsers()
        {
            InitializeComponent();
        }
        private void FAllUsers_Load(object sender, EventArgs e)
        {
            panelHide.Hide();
            btnNumeric.ForeColor = RGBColor.color1;
            btnNumeric.IconColor = RGBColor.color1;
        }

        private void btnTool_Click(object sender, EventArgs e)
        {
            //FManagerToolcs MT = new FManagerToolcs();
            //MT.ShowDialog();
            FHire fHire = new FHire();
            fHire.Show();
        }

        private void btnNumeric_Click(object sender, EventArgs e)
        {
            panelHide.Hide();
            btnNumeric.ForeColor = RGBColor.color1;
            btnNumeric.IconColor = RGBColor.color1;
            btnChart.ForeColor = Color.White;
            btnChart.IconColor = Color.White;
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            panelHide.Show();
            btnChart.ForeColor = RGBColor.color1;
            btnChart.IconColor = RGBColor.color1;
            btnNumeric.ForeColor = Color.White;
            btnNumeric.IconColor = Color.White;
        }
    }
}
