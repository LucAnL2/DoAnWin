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
using System.Windows.Forms;

namespace DemoWin.Booking
{
    public partial class FCalender : Form
    {
        #region Peoperties
        private List<List<Guna2Button>> matrix;

        public List<List<Guna2Button>> Matrix { get => matrix; set => matrix = value; }

        private List<string> dateOfWeek = new List<string> { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion
        public static string selectedDay ="";
        public static int selectedMonth;
        public static int selectedYear;
        private UCReceiveJob ucReceiveJob;
        public FCalender()
        {
            InitializeComponent();
            LoadMatrix();
            ucReceiveJob = new UCReceiveJob();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FLPmatrix_Paint(object sender, PaintEventArgs e)
        {
        }
        void UCDayButton_Click(object sender, EventArgs e)
        {
            UCDay ucd = new UCDay();
            ucd.btnDay_Click(sender, e);
        }
        void LoadMatrix()
        {
            Matrix = new List<List<Guna2Button>>();
            Guna2Button oldBtn = new Guna2Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.DayOfColumn; i++)
            {
                Matrix.Add(new List<Guna2Button>());
                for (int j = 0; j < Cons.DayOfWeek; j++)
                {

                    Guna2Button btn = new Guna2Button() { Width = Cons.dateButtonWidth, Height = Cons.dateButtonHeight };
                    btn.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    btn.Click += UCDayButton_Click; // Gán sự kiện click cho nút
                    FLPmatrix.Controls.Add(btn);
                    Matrix[i].Add(btn);
                    oldBtn = btn;

                }

                oldBtn = new Guna2Button()
                {
                    Width = 0,
                    Height = 0,
                    Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.dateButtonHeight)
                };
            }
            SetDefaulDate();
        }
        int DayOfMonth(DateTime date)
        {
            switch(date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                        return 29;
                    else
                        return 28;
                default:
                    return 30; ;
            }
           
        }
        void AddNumIntoMatrixByDate(DateTime date)
        {
            ClearMatrix();
            DateTime usedate = new DateTime(date.Year, date.Month, 1);
            int line = 0;
            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = (int)usedate.DayOfWeek; // Sử dụng phương thức DayOfWeek
                Guna2Button btn = Matrix[line][column];
                btn.Text = i.ToString();
                // ngày hôm nay cho hiện màu khác
                if (usedate == DateTime.Today)
                {
                    btn.FillColor = Color.Aquamarine; // Đổi màu thành màu vàng
                    btn.ForeColor = Color.Black; // Có thể đổi màu chữ để nổi bật hơn
                }
                if (usedate.Date == date.Date) 
                {
                    btn.FillColor= Color.YellowGreen;
                }
                List<string> ngayThueList = TakeListHire();
                //foreach (var ngayThue in ngayThueList)
                //{
                //    // Phân tách chuỗi thành các giá trị riêng biệt bằng dấu phẩy
                //    string[] values = ngayThue.Split(',');

                //    // So sánh giá trị Text của button với từng giá trị trong mảng values
                //    foreach (var value in values)
                //    {
                //        if (btn.Text == value.Trim())
                //        {
                //            // Nếu Text của button trùng với một giá trị trong values, 
                //            // thì đổi FillColor của button thành màu đỏ
                //            btn.FillColor = Color.Red;
                //        }
                //    }
                //}
                foreach (var ngayThue in ngayThueList)
                {
                    // Phân tách chuỗi thành các giá trị riêng biệt bằng dấu phẩy
                    string[] values = ngayThue.Split(',');

                    // Kiểm tra nếu ngày, tháng và năm của ngày đã thuê trùng với ngày đang xét
                    foreach (var value in values)
                    {
                        string[] parts = value.Split('-');
                        int day = int.Parse(parts[0]);
                        int month = int.Parse(parts[1]);
                        int year = int.Parse(parts[2]);

                        if (btn.Text == day.ToString() && date.Month == month && date.Year == year)
                        {
                            // Nếu ngày đã thuê trùng với ngày đang xét, đổi FillColor của button thành màu đỏ
                            btn.FillColor = Color.Red;
                        }
                    }
                }
                // màu cho các ngày còn lại
                //else
                //{
                //    btn.FillColor = Color.Thistle;
                //}
                if (column >= 6)
                {
                    line++;
                }
                usedate = usedate.AddDays(1); // Tăng thêm 1 ngày
            }
        }

        //bool isEqualDate(DateTime dateA, DateTime dateB)
        //{
        //    return dateA.Year == dateB.Year && dateA.Month == dateB.Month && dateA.Day == dateB.Day;
        //}

        void ClearMatrix()
        {
            for (int i = 0;i <Matrix.Count;i++)
            {
                for(int j = 0;j < Matrix[i].Count;j++)
                {
                    // thay ma trận màu xanh cũ bằng màu mới và chữ mới
                    Guna2Button btn = Matrix[i][j];
                    btn.Text = "";
                    btn.FillColor = Color.Thistle;
                    btn.ForeColor = Color.White;
                }    
            }    
        }

      
        void SetDefaulDate()
        {
            guna2DateTimePicker1.Value = DateTime.Now;
        }
        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AddNumIntoMatrixByDate((sender as Guna2DateTimePicker).Value);   
        }

        private void btnPreMonth_Click(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = guna2DateTimePicker1.Value.AddMonths(-1);
        }
       

        private void btnToday_Click(object sender, EventArgs e)
        {
            SetDefaulDate();
        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Value = guna2DateTimePicker1.Value.AddMonths(1);

        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            string hireDate = dateHire();
            if ((hireDate == ""))
            {
                MessageBox.Show("Bạn chưa chọn ngày để thuê !!!");
                return;
            }
            else
            {
                FConfirm fConfirm = new FConfirm();
                fConfirm.ShowDialog();
            }
            
        }

        // chọn ngày để thuê
        private List<Guna2Button> selectedButtons = new List<Guna2Button>();

        string dateHire ()
        {
             string hireDays = "";
             selectedMonth = guna2DateTimePicker1.Value.Month;
             selectedYear = guna2DateTimePicker1.Value.Year;

            foreach (var row in Matrix)
            {
                foreach (var button in row)
                {
                    if (button.FillColor == Color.YellowGreen)
                    {
                        // Kiểm tra xem ngày này có hợp lệ không
                        DateTime buttonDate;
                        if (!DateTime.TryParse($"{selectedMonth}/{button.Text}/{selectedYear}", out buttonDate))
                        {
                            MessageBox.Show("Ngày không hợp lệ: " + button.Text);
                            return ""; // Bỏ qua ngày không hợp lệ
                        }

                        // Kiểm tra xem ngày này đã qua hay chưa
                        if (buttonDate.Date < DateTime.Today)
                        {
                            MessageBox.Show("Ngày đã qua không thể chọn: " + button.Text);
                            return ""; // Bỏ qua ngày đã qua
                        }

                        hireDays += button.Text + ",";
                        selectedButtons.Add(button); // Thêm nút được chọn vào danh sách
                    }
                }
            }
            if (!string.IsNullOrEmpty(hireDays))
            {
                hireDays = hireDays.TrimEnd(',');
            }
            selectedDay = hireDays;
            // In ra thông tin về các ngày được chọn có màu YellowGreen
            MessageBox.Show(hireDays);
            return selectedDay;
        }
        private void FCalender_Load(object sender, EventArgs e)
        {

        }

        public List<string> TakeListHire()
        {
            string queryHiredate = string.Format("SELECT NgayThue,ThangThue,NamThue FROM ThueViec WHERE (IDNguoiDuocThue = N'{0}' or IDNguoiDuocThue = N'{1}') AND TrangThaiThue = N'Đã xác nhận'", FWorkerDetail.hiredID,FWokerInfo.hiredID);
            //essageBox.Show(queryHiredate);
            List<string> ngayThueList = GetDataFromDatabase(queryHiredate);
            List<string> formattedList = FormatDateString(ngayThueList); // Chuyển đổi định dạng ngày thue
            return formattedList;
        }
        //đọc ngày đã thuê
        private List<string> GetDataFromDatabase(string query)
        {
            List<string> resultList = new List<string>();

            // Thực hiện truy vấn đến cơ sở dữ liệu và lấy dữ liệu về
            // Trong trường hợp này, tôi giả sử bạn sử dụng ADO.NET để thực hiện truy vấn
            using (SqlConnection connection = Connection.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    // Lấy giá trị từ cột NgayThue trong kết quả truy vấn và thêm vào danh sách
                    //resultList.Add(reader["NgayThue"].ToString());
                    string ngayThue = $"{reader["NgayThue"]}-{reader["ThangThue"]}-{reader["NamThue"]}";
                    resultList.Add(ngayThue);
                }
                reader.Close();
            }

            return resultList;
        }
        public List<string> FormatDateString(List<string> inputList)
        {
            List<string> resultList = new List<string>();

            foreach (string dateString in inputList)
            {
                string[] dateParts = dateString.Split('-');

                if (dateParts.Length == 3)
                {
                    string[] subParts = dateParts[0].Split(',');

                    foreach (string date in subParts)
                    {
                        string formattedDate = date + "-" + dateParts[1] + "-" + dateParts[2];
                        resultList.Add(formattedDate);
                    }
                }
            }

            return resultList;
        }
        //kiểm tra xem có ô nào mau đỏ không để thực hiện thuê theo tháng
        private bool AllButtonsAreRed()
        {
            foreach (var row in Matrix)
            {
                foreach (var button in row)
                {
                    if (button.FillColor == Color.Red)
                    {
                        return false; // Trả về false ngay khi gặp một nút không phải màu đỏ
                    }
                }
            }
            return true; // Trả về true nếu tất cả các nút đều là màu đỏ
        }

        private void btnHireAllMonth_Click(object sender, EventArgs e)
        {
            string hireDays = "";
            selectedMonth = guna2DateTimePicker1.Value.Month;
            selectedYear = guna2DateTimePicker1.Value.Year;
            if (AllButtonsAreRed() == false)
            {
                MessageBox.Show("Không thể thuê theo tháng do người làm đã bận ngày nào đó");
            }
            else 
            {
                if (selectedYear < DateTime.Now.Year)
                {
                    MessageBox.Show("Không thể chọn thời gian trong quá khứ !!!");
                    return;
                }
                else
                {
                    if(selectedMonth < DateTime.Now.Month)
                    {
                        MessageBox.Show("Không thể chọn thời gian trong quá khứ !!!");
                        return;
                    }
                    else
                    {
                        foreach (var row in Matrix)
                        {
                            foreach (var button in row)
                            {
                                if (button.Text != "")
                                {
                                    button.FillColor = Color.YellowGreen;
                                    hireDays += button.Text + ",";
                                }
                            }
                        }
                        if (!string.IsNullOrEmpty(hireDays))
                        {
                            hireDays = hireDays.TrimEnd(',');
                        }
                        selectedDay = hireDays;
                        // In ra thông tin về các ngày được chọn có màu YellowGreen
                        MessageBox.Show(hireDays);
                        FConfirm fConfirm = new FConfirm();
                        fConfirm.ShowDialog();
                    }

                }
            }
        }
    }
}
