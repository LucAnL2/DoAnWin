using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class FConfirm : Form
    {
       // string hiredID = 
        public FConfirm()
        {
            InitializeComponent();
        }

        private void FConfirm_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            FLogin fLogin = Application.OpenForms.OfType<FLogin>().FirstOrDefault();
            if (fLogin != null)
            {
                txtHireID.Text = fLogin.HireID;
                txtHireName.Text = fLogin.HireName;
                txtAddress.Text = fLogin.Address;
                txtPhone.Text = fLogin.Phone;
                txtHiredID.Text = FWorkerDetail.hiredID;
                txtHiredName.Text = FWorkerDetail.hiredName;
            }
            txtDay.Text  = FCalender.selectedDay.ToString();
            txtMonth.Text =(FCalender.selectedMonth).ToString();
            txtYear.Text =(FCalender.selectedYear).ToString();

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConFirm_Click(object sender, EventArgs e)
        {
            string statusHire = "Chờ xác nhận";
            User user = new User(txtHireID.Text, txtHireName.Text, txtHiredID.Text, txtHiredName.Text,
                txtDay.Text, txtMonth.Text, txtYear.Text, statusHire,txtAddress.Text,txtPhone.Text,txtJob.Text);
            UserDAO userDAO = new UserDAO();
            userDAO.Booking(user);
            this.Close();
        }
       
    }
}
