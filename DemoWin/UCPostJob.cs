using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DemoWin.Worker;

namespace DemoWin
{
    public partial class UCPostJob : UserControl
    {
        public UCPostJob()
        {
            InitializeComponent();
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
            FPostWork newPostWork = new FPostWork();
            Worker wk = new Worker(GlobalVariables.Id.ToString(), newPostWork.UctJob.txtData.Text, newPostWork.UctDayOfWork.txtData.Text, newPostWork.UctTimeOfWork.txtData.Text,
                             newPostWork.UctHireCost.txtData.Text, newPostWork.UctExperience.txtData.Text, newPostWork.TxtDataDescribe.Text);
            WokerDAO HSD = new WokerDAO();
            HSD.DeleteWork(wk);
            load();
        }
    }
}
