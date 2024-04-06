using DemoWin.ChildFormsWorker;
using Guna.UI2.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace DemoWin.Booking
{
    public partial class UCReceiveJob : UserControl
    {
        //làm mới lai form FcalenderJob
        public event EventHandler ConfirmButtonClicked;

        public static string takeHireDay = "";
        public UCReceiveJob()
        {
            InitializeComponent();
        }

        private void UCReceiveJob_Load(object sender, EventArgs e)
        {

        }

        private void btnConFirm_Click(object sender, EventArgs e)
        {
            // cập nhật trang thái xác nhận cong việc
            string statusHire = "Đã xác nhận";
            User user = new User(txtHireID.Text, txtHireName.Text,FWokerInfo.hiredID, FWokerInfo.hiredName,
                txtDay.Text, txtMonth.Text, txtYear.Text, statusHire, txtAddress.Text, txtPhone.Text, txtJob.Text);
            UserDAO userDAO = new UserDAO();
            userDAO.updateBooking(user);

            // gọi hàm bên fcalender để có thể oad lại form
            FCalenderJob fCalenderJob = Application.OpenForms.OfType<FCalenderJob>().FirstOrDefault();
            // fCalenderJob.Refresh();
            if (fCalenderJob != null)
            {
                fCalenderJob.RefreshFlowLayoutPanel();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // cập nhật trang thái xác nhận cong việc
            string statusHire = "Chờ xác nhận";
            User user = new User(txtHireID.Text, txtHireName.Text, FWokerInfo.hiredID, FWokerInfo.hiredName,
                txtDay.Text, txtMonth.Text, txtYear.Text, statusHire, txtAddress.Text, txtPhone.Text, txtJob.Text);
            UserDAO userDAO = new UserDAO();
            userDAO.DeleteBooking(user);
            FCalenderJob fCalenderJob = Application.OpenForms.OfType<FCalenderJob>().FirstOrDefault();
            if (fCalenderJob != null)
            {
                fCalenderJob.RefreshFlowLayoutPanel();
            }
        }
    }
}
