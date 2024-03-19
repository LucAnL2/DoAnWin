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

namespace DemoWin.ChildFormsWorker
{
    public partial class FWork : Form
    {
        public FWork()
        {
            InitializeComponent();
        }
       
        private void FWork_Load(object sender, EventArgs e)
        {
            panelRight.BackColor = ThemeColors.PrimaryColor;
            panelBoundary.BackColor = ThemeColors.PrimaryColor;
            for (int i = 0; i < 2; i++)
            {
                UCPostJob uc = new UCPostJob();
                uc.Margin = new Padding(20);
                uc.BackColor = ThemeColors.PrimaryColor;
                flowPanelContain.Controls.Add(uc);
            }
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            FPostWork postWork = new FPostWork();
            postWork.ShowDialog();
 
        }
    }
}
