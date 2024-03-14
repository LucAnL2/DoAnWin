using FontAwesome.Sharp;
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
    }
}
