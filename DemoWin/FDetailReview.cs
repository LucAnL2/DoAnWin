using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class FDetailReview : Form
    {
        public FDetailReview()
        {
            InitializeComponent();
        }

        private void FDetailReview_Load(object sender, EventArgs e)
        {
            for (int i = 0;i<3;i++)
            {
               UCDetailReview uCDetailReview = new UCDetailReview();
               flowLayoutPanel1.Controls.Add(uCDetailReview);
            }    
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
