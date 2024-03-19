using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public partial class Form1 : Form
    {
        PaintColor paintColor = new PaintColor();
        public Color IconColor { get; set; }
        public Form1()
        {
            InitializeComponent();
            IconColor = Color.Black;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Color color = paintColor.SelectThemeColors();
            ChangeColorComboButton(flowLayoutPanel1, color);
            Guna2TextBox gunaTextBoxName = new Guna2TextBox();
            gunaTextBoxName.Name = "gunaTextBoxName";
            gunaTextBoxName.PlaceholderText = "Họ và tên";
            gunaTextBoxName.BorderRadius = 10;
            //gunaTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.Dash;
            gunaTextBoxName.Size = new Size(200, 30);

            // Thêm GunaTextBox vào form
            this.Controls.Add(gunaTextBoxName);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Color color = paintColor.SelectThemeColors();
            ChangeColorComboButton(flowLayoutPanel1, color);
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        private void ChangeColorComboButton(FlowLayoutPanel panel, Color color)
        {
            foreach (Control previousBtn in panel.Controls)
            {
                if (previousBtn.GetType() == typeof(IconButton))
                {
                    previousBtn.ForeColor = color;
                    IconButton iconButton = (IconButton)previousBtn; // Ép kiểu về IconButton
                    iconButton.IconColor = color; // Gán giá trị cho thuộc tính IconColor
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            try
            {
                string defaultFolderPath = root +"\\DataUser\\";
                string defaultFilePath = Path.Combine(defaultFolderPath, "test2.txt");
                if (File.Exists(defaultFilePath))
                {
                    MessageBox.Show("Default file already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (StreamWriter writer = new StreamWriter(defaultFilePath))
                {
                    writer.WriteLine("Hello, world!");
                }

                MessageBox.Show("Default text file created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ExportDataToFile(string tableName, string filePath)
        {
            
            SqlConnection conn = Connection.GetSqlConnection();
            try
            {
                using (SqlConnection connection = conn)
                {
                    connection.Open();
                    string query = $"SELECT * FROM {tableName}";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                writer.Write(reader[i].ToString());
                                if (i < reader.FieldCount - 1)
                                    writer.Write("-");
                            }
                            writer.WriteLine();
                        }
                    }

                    MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string tableName = "Account";
            string defaultFolderPath = root + "\\DataUser\\";
            string filePath = Path.Combine(defaultFolderPath, "test.txt");
            ExportDataToFile(tableName, filePath);
        }
        public void RemoveLinesContaining(string filePath, string[] contentsToRemove)
        {
            try
            {
                // Đọc toàn bộ nội dung từ file vào một mảng dòng
                string[] lines = File.ReadAllLines(filePath);

                // Tạo một danh sách mới để lưu trữ nội dung đã được chỉnh sửa
                var updatedLines = new List<string>();

                // Duyệt qua từng dòng trong mảng
                foreach (string line in lines)
                {
                    bool shouldRemove = false;
                    // Kiểm tra xem dòng có chứa bất kỳ nội dung nào trong danh sách contentsToRemove không
                    foreach (string content in contentsToRemove)
                    {
                        if (line.Contains(content))
                        {
                            shouldRemove = true;
                            break;
                        }
                    }
                    // Nếu dòng không chứa bất kỳ nội dung nào trong danh sách contentsToRemove, thêm vào danh sách đã chỉnh sửa
                    if (!shouldRemove)
                    {
                        updatedLines.Add(line);
                    }
                }

                // Ghi lại nội dung đã chỉnh sửa vào file
                File.WriteAllLines(filePath, updatedLines);

                MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string defaultFolderPath = root + "\\DataUser\\";
            string filePath = Path.Combine(defaultFolderPath, "test.txt");
            string[] contentsToRemove = { "Admin" };
            RemoveLinesContaining(filePath, contentsToRemove);
        }
        public void ExportlineDataToFile(string tableName, string filePath)
        {
            SqlConnection conn = Connection.GetSqlConnection();
            try
            {
                // Đọc toàn bộ nội dung từ file vào một danh sách
                List<string> existingLines = new List<string>();
                if (File.Exists(filePath))
                {
                    existingLines.AddRange(File.ReadAllLines(filePath));
                }

                // Tạo và mở file để ghi dữ liệu
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    // Ghi lại dữ liệu từ file vào file mới
                    foreach (string line in existingLines)
                    {
                        writer.WriteLine(line);
                    }

                    // Tải dữ liệu từ cơ sở dữ liệu
                    using (SqlConnection connection = conn)
                    {
                        connection.Open();
                        string query = $"SELECT * FROM {tableName}";
                        SqlCommand command = new SqlCommand(query, connection);
                        SqlDataReader reader = command.ExecuteReader();

                        // Ghi dữ liệu từ cơ sở dữ liệu vào file mới (chỉ ghi những dòng chưa tồn tại trong file)
                        while (reader.Read())
                        {
                            string line = "";
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                line += reader[i].ToString();
                                if (i < reader.FieldCount - 1)
                                {
                                    line += "-";
                                }
                            }
                            if (!existingLines.Contains(line))
                            {
                                writer.WriteLine(line);
                            }
                        }
                    }
                }

                MessageBox.Show("Success", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string root = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string tableName = "Account";
            string defaultFolderPath = root + "\\DataUser\\";
            string filePath = Path.Combine(defaultFolderPath, "test.txt");
            ExportlineDataToFile(tableName, filePath);
        }
    }
}
