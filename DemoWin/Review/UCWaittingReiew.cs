using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DemoWin.Review
{
    public partial class UCWaittingReiew : UserControl
    {
        public static string id;
        public static string name;
        public UCWaittingReiew()
        {
            InitializeComponent();
        }
        //public string getID()
        //{
        //    return lblID.Text;
        //}

        //public string getName()
        //{
        //    return lblName.Text;
        //}
        private void UCWaittingReiew_Load(object sender, EventArgs e)
        {
            
        }

        private void lblRate_Click(object sender, EventArgs e)
        {

        }

        private void lblID_Click(object sender, EventArgs e)
        {

        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
           id = lblID.Text;
           name = lblName.Text;
           FReview fReview = new FReview();
           fReview.Show();
        }
    }
}
