using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Booking
{
    public partial class UCDay : UserControl
    {
        public UCDay()
        {
            InitializeComponent();
        }

        public void btnDay_Click(object sender, EventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;
            if (btn.Text != null || btn.Text!= "")
            {
                if (btn.FillColor == Color.Thistle)
                {
                    btn.FillColor = Color.YellowGreen;
                }
                else if (btn.FillColor == Color.YellowGreen)
                {
                    btn.FillColor = Color.Thistle;
                }
            }
        }
    }
}
