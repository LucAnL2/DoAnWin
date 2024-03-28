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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i=0; i<5; i++)
            {
                UCWorkerInfo workerInfo = new UCWorkerInfo();
                flowLayoutPanel1.Controls.Add(workerInfo);
            }
        }
    }
}
