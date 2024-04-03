namespace DemoWin.Booking
{
    partial class FCalender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHire = new Guna.UI2.WinForms.Guna2Button();
            this.FLPmatrix = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnNextMonth = new Guna.UI2.WinForms.Guna2Button();
            this.btnSunday = new Guna.UI2.WinForms.Guna2Button();
            this.btnSaturday = new Guna.UI2.WinForms.Guna2Button();
            this.btnFriday = new Guna.UI2.WinForms.Guna2Button();
            this.btnThursday = new Guna.UI2.WinForms.Guna2Button();
            this.btnWednesday = new Guna.UI2.WinForms.Guna2Button();
            this.btnTuesday = new Guna.UI2.WinForms.Guna2Button();
            this.btnMonday = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPreMonth = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnToday = new Guna.UI2.WinForms.Guna2Button();
            this.btnHireAllMonth = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnHireAllMonth);
            this.guna2Panel1.Controls.Add(this.btnHire);
            this.guna2Panel1.Controls.Add(this.FLPmatrix);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 79);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1159, 676);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnHire
            // 
            this.btnHire.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHire.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnHire.BorderRadius = 8;
            this.btnHire.BorderThickness = 2;
            this.btnHire.FillColor = System.Drawing.Color.Plum;
            this.btnHire.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHire.ForeColor = System.Drawing.Color.White;
            this.btnHire.Location = new System.Drawing.Point(955, 107);
            this.btnHire.Name = "btnHire";
            this.btnHire.Size = new System.Drawing.Size(144, 60);
            this.btnHire.TabIndex = 86;
            this.btnHire.Text = "Thuê theo ngày";
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // FLPmatrix
            // 
            this.FLPmatrix.Location = new System.Drawing.Point(153, 92);
            this.FLPmatrix.Name = "FLPmatrix";
            this.FLPmatrix.Size = new System.Drawing.Size(757, 457);
            this.FLPmatrix.TabIndex = 2;
            this.FLPmatrix.Paint += new System.Windows.Forms.PaintEventHandler(this.FLPmatrix_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.btnNextMonth);
            this.guna2Panel2.Controls.Add(this.btnSunday);
            this.guna2Panel2.Controls.Add(this.btnSaturday);
            this.guna2Panel2.Controls.Add(this.btnFriday);
            this.guna2Panel2.Controls.Add(this.btnThursday);
            this.guna2Panel2.Controls.Add(this.btnWednesday);
            this.guna2Panel2.Controls.Add(this.btnTuesday);
            this.guna2Panel2.Controls.Add(this.btnMonday);
            this.guna2Panel2.Controls.Add(this.guna2Button2);
            this.guna2Panel2.Controls.Add(this.btnPreMonth);
            this.guna2Panel2.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(1126, 78);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNextMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNextMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNextMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNextMonth.ForeColor = System.Drawing.Color.White;
            this.btnNextMonth.Location = new System.Drawing.Point(934, 3);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(99, 58);
            this.btnNextMonth.TabIndex = 8;
            this.btnNextMonth.Text = "Tháng sau";
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnSunday
            // 
            this.btnSunday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSunday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSunday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSunday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSunday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSunday.ForeColor = System.Drawing.Color.White;
            this.btnSunday.Location = new System.Drawing.Point(799, -5);
            this.btnSunday.Name = "btnSunday";
            this.btnSunday.Size = new System.Drawing.Size(103, 63);
            this.btnSunday.TabIndex = 7;
            this.btnSunday.Text = "Chủ nhật";
            // 
            // btnSaturday
            // 
            this.btnSaturday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaturday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaturday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaturday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaturday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaturday.ForeColor = System.Drawing.Color.White;
            this.btnSaturday.Location = new System.Drawing.Point(690, -5);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(103, 63);
            this.btnSaturday.TabIndex = 6;
            this.btnSaturday.Text = "Thứ 7";
            this.btnSaturday.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // btnFriday
            // 
            this.btnFriday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFriday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFriday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFriday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFriday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFriday.ForeColor = System.Drawing.Color.White;
            this.btnFriday.Location = new System.Drawing.Point(581, -5);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(103, 63);
            this.btnFriday.TabIndex = 5;
            this.btnFriday.Text = "Thú 6";
            // 
            // btnThursday
            // 
            this.btnThursday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThursday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThursday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThursday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThursday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnThursday.ForeColor = System.Drawing.Color.White;
            this.btnThursday.Location = new System.Drawing.Point(472, -5);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(103, 63);
            this.btnThursday.TabIndex = 4;
            this.btnThursday.Text = "Thứ 5";
            // 
            // btnWednesday
            // 
            this.btnWednesday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnWednesday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnWednesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnWednesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnWednesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnWednesday.ForeColor = System.Drawing.Color.White;
            this.btnWednesday.Location = new System.Drawing.Point(363, -5);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(103, 63);
            this.btnWednesday.TabIndex = 3;
            this.btnWednesday.Text = "Thứ 4";
            // 
            // btnTuesday
            // 
            this.btnTuesday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnTuesday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnTuesday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnTuesday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnTuesday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTuesday.ForeColor = System.Drawing.Color.White;
            this.btnTuesday.Location = new System.Drawing.Point(254, -5);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(103, 63);
            this.btnTuesday.TabIndex = 2;
            this.btnTuesday.Text = "Thứ 3";
            this.btnTuesday.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMonday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMonday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMonday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMonday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMonday.ForeColor = System.Drawing.Color.White;
            this.btnMonday.Location = new System.Drawing.Point(145, -5);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(103, 63);
            this.btnMonday.TabIndex = 1;
            this.btnMonday.Text = "Thứ 2";
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(109, 171);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(180, 45);
            this.guna2Button2.TabIndex = 0;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // btnPreMonth
            // 
            this.btnPreMonth.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPreMonth.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPreMonth.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPreMonth.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPreMonth.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPreMonth.ForeColor = System.Drawing.Color.White;
            this.btnPreMonth.Location = new System.Drawing.Point(3, 0);
            this.btnPreMonth.Name = "btnPreMonth";
            this.btnPreMonth.Size = new System.Drawing.Size(110, 58);
            this.btnPreMonth.TabIndex = 0;
            this.btnPreMonth.Text = "Tháng trước";
            this.btnPreMonth.Click += new System.EventHandler(this.btnPreMonth_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel3.Controls.Add(this.btnToday);
            this.guna2Panel3.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1114, 61);
            this.guna2Panel3.TabIndex = 1;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(213, 12);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(313, 36);
            this.guna2DateTimePicker1.TabIndex = 1;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 4, 1, 21, 57, 21, 143);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // btnToday
            // 
            this.btnToday.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToday.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToday.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToday.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnToday.ForeColor = System.Drawing.Color.White;
            this.btnToday.Location = new System.Drawing.Point(589, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(128, 45);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Hôm nay";
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // btnHireAllMonth
            // 
            this.btnHireAllMonth.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnHireAllMonth.BorderColor = System.Drawing.Color.MediumPurple;
            this.btnHireAllMonth.BorderRadius = 8;
            this.btnHireAllMonth.BorderThickness = 2;
            this.btnHireAllMonth.FillColor = System.Drawing.Color.Plum;
            this.btnHireAllMonth.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnHireAllMonth.ForeColor = System.Drawing.Color.White;
            this.btnHireAllMonth.Location = new System.Drawing.Point(955, 200);
            this.btnHireAllMonth.Name = "btnHireAllMonth";
            this.btnHireAllMonth.Size = new System.Drawing.Size(144, 60);
            this.btnHireAllMonth.TabIndex = 87;
            this.btnHireAllMonth.Text = "Thuê cả tháng";
            this.btnHireAllMonth.Click += new System.EventHandler(this.btnHireAllMonth_Click);
            // 
            // FCalender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 640);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FCalender";
            this.Text = "FCalender";
            this.Load += new System.EventHandler(this.FCalender_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnPreMonth;
        private Guna.UI2.WinForms.Guna2Button btnSunday;
        private Guna.UI2.WinForms.Guna2Button btnSaturday;
        private Guna.UI2.WinForms.Guna2Button btnFriday;
        private Guna.UI2.WinForms.Guna2Button btnThursday;
        private Guna.UI2.WinForms.Guna2Button btnWednesday;
        private Guna.UI2.WinForms.Guna2Button btnTuesday;
        private Guna.UI2.WinForms.Guna2Button btnMonday;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button btnToday;
        private System.Windows.Forms.FlowLayoutPanel FLPmatrix;
        private Guna.UI2.WinForms.Guna2Button btnNextMonth;
        private Guna.UI2.WinForms.Guna2Button btnHire;
        private Guna.UI2.WinForms.Guna2Button btnHireAllMonth;
    }
}