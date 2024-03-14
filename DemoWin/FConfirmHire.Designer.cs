namespace DemoWin
{
    partial class FConfirmHire
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
            this.panelTaskBar = new System.Windows.Forms.Panel();
            this.btnWorkMonth = new System.Windows.Forms.Button();
            this.btnWorkDay = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnHire = new Guna.UI2.WinForms.Guna2Button();
            this.lblSelectHire = new System.Windows.Forms.Label();
            this.dateHire = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMonthHire = new System.Windows.Forms.Panel();
            this.lblYearHire = new System.Windows.Forms.Label();
            this.lblMonthHire = new System.Windows.Forms.Label();
            this.txtYearHire = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMonthHire = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.panelTaskBar.SuspendLayout();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelMonthHire.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTaskBar
            // 
            this.panelTaskBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTaskBar.Controls.Add(this.btnWorkMonth);
            this.panelTaskBar.Controls.Add(this.btnWorkDay);
            this.panelTaskBar.Controls.Add(this.btnMinimize);
            this.panelTaskBar.Controls.Add(this.btnClose);
            this.panelTaskBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskBar.Location = new System.Drawing.Point(0, 0);
            this.panelTaskBar.Name = "panelTaskBar";
            this.panelTaskBar.Size = new System.Drawing.Size(475, 45);
            this.panelTaskBar.TabIndex = 0;
            this.panelTaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTaskBar_MouseDown);
            // 
            // btnWorkMonth
            // 
            this.btnWorkMonth.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWorkMonth.FlatAppearance.BorderSize = 0;
            this.btnWorkMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkMonth.ForeColor = System.Drawing.Color.White;
            this.btnWorkMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkMonth.Location = new System.Drawing.Point(169, 0);
            this.btnWorkMonth.Name = "btnWorkMonth";
            this.btnWorkMonth.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWorkMonth.Size = new System.Drawing.Size(169, 45);
            this.btnWorkMonth.TabIndex = 84;
            this.btnWorkMonth.Text = "    Thuê theo tháng";
            this.btnWorkMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkMonth.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkMonth.UseVisualStyleBackColor = true;
            this.btnWorkMonth.Click += new System.EventHandler(this.btnWorkMonth_Click);
            // 
            // btnWorkDay
            // 
            this.btnWorkDay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnWorkDay.FlatAppearance.BorderSize = 0;
            this.btnWorkDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkDay.ForeColor = System.Drawing.Color.White;
            this.btnWorkDay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkDay.Location = new System.Drawing.Point(0, 0);
            this.btnWorkDay.Name = "btnWorkDay";
            this.btnWorkDay.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWorkDay.Size = new System.Drawing.Size(169, 45);
            this.btnWorkDay.TabIndex = 83;
            this.btnWorkDay.Text = "    Thuê theo ngày";
            this.btnWorkDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkDay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkDay.UseVisualStyleBackColor = true;
            this.btnWorkDay.Click += new System.EventHandler(this.btnWorkDay_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::DemoWin.Properties.Resources.minus_small;
            this.btnMinimize.Location = new System.Drawing.Point(396, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 82;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DemoWin.Properties.Resources.cross_small;
            this.btnClose.Location = new System.Drawing.Point(437, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 81;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBottom.Controls.Add(this.btnCancel);
            this.panelBottom.Controls.Add(this.btnHire);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 345);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(475, 75);
            this.panelBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.CheckedState.Parent = this.btnCancel;
            this.btnCancel.CustomImages.Parent = this.btnCancel;
            this.btnCancel.FillColor = System.Drawing.Color.White;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnCancel.HoverState.Parent = this.btnCancel;
            this.btnCancel.Location = new System.Drawing.Point(305, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShadowDecoration.Parent = this.btnCancel;
            this.btnCancel.Size = new System.Drawing.Size(104, 45);
            this.btnCancel.TabIndex = 77;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnHire
            // 
            this.btnHire.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHire.BorderRadius = 8;
            this.btnHire.BorderThickness = 2;
            this.btnHire.CheckedState.Parent = this.btnHire;
            this.btnHire.CustomImages.Parent = this.btnHire;
            this.btnHire.FillColor = System.Drawing.Color.White;
            this.btnHire.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnHire.HoverState.Parent = this.btnHire;
            this.btnHire.Location = new System.Drawing.Point(52, 18);
            this.btnHire.Name = "btnHire";
            this.btnHire.ShadowDecoration.Parent = this.btnHire;
            this.btnHire.Size = new System.Drawing.Size(104, 45);
            this.btnHire.TabIndex = 76;
            this.btnHire.Text = "Xác nhận";
            this.btnHire.Click += new System.EventHandler(this.btnHire_Click);
            // 
            // lblSelectHire
            // 
            this.lblSelectHire.AutoSize = true;
            this.lblSelectHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectHire.Location = new System.Drawing.Point(233, 132);
            this.lblSelectHire.Name = "lblSelectHire";
            this.lblSelectHire.Size = new System.Drawing.Size(143, 20);
            this.lblSelectHire.TabIndex = 3;
            this.lblSelectHire.Text = "Chọn ngày thuê:";
            this.lblSelectHire.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateHire
            // 
            this.dateHire.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.dateHire.BorderRadius = 5;
            this.dateHire.BorderThickness = 1;
            this.dateHire.CheckedState.Parent = this.dateHire;
            this.dateHire.FillColor = System.Drawing.Color.White;
            this.dateHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHire.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateHire.HoverState.Parent = this.dateHire;
            this.dateHire.Location = new System.Drawing.Point(237, 174);
            this.dateHire.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateHire.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateHire.Name = "dateHire";
            this.dateHire.ShadowDecoration.Parent = this.dateHire;
            this.dateHire.Size = new System.Drawing.Size(226, 34);
            this.dateHire.TabIndex = 4;
            this.dateHire.Value = new System.DateTime(2024, 3, 12, 21, 8, 7, 66);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.White;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 137;
            this.iconPictureBox1.Location = new System.Drawing.Point(32, 108);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(137, 137);
            this.iconPictureBox1.TabIndex = 5;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelMonthHire
            // 
            this.panelMonthHire.Controls.Add(this.lblYearHire);
            this.panelMonthHire.Controls.Add(this.lblMonthHire);
            this.panelMonthHire.Controls.Add(this.txtYearHire);
            this.panelMonthHire.Controls.Add(this.txtMonthHire);
            this.panelMonthHire.Controls.Add(this.iconPictureBox2);
            this.panelMonthHire.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMonthHire.Location = new System.Drawing.Point(0, 45);
            this.panelMonthHire.Name = "panelMonthHire";
            this.panelMonthHire.Size = new System.Drawing.Size(475, 300);
            this.panelMonthHire.TabIndex = 6;
            // 
            // lblYearHire
            // 
            this.lblYearHire.AutoSize = true;
            this.lblYearHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearHire.Location = new System.Drawing.Point(278, 182);
            this.lblYearHire.Name = "lblYearHire";
            this.lblYearHire.Size = new System.Drawing.Size(85, 18);
            this.lblYearHire.TabIndex = 9;
            this.lblYearHire.Text = "Năm thuê:";
            // 
            // lblMonthHire
            // 
            this.lblMonthHire.AutoSize = true;
            this.lblMonthHire.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthHire.Location = new System.Drawing.Point(278, 30);
            this.lblMonthHire.Name = "lblMonthHire";
            this.lblMonthHire.Size = new System.Drawing.Size(96, 18);
            this.lblMonthHire.TabIndex = 9;
            this.lblMonthHire.Text = "Tháng thuê:";
            // 
            // txtYearHire
            // 
            this.txtYearHire.BorderRadius = 8;
            this.txtYearHire.BorderThickness = 2;
            this.txtYearHire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYearHire.DefaultText = "";
            this.txtYearHire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYearHire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYearHire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYearHire.DisabledState.Parent = this.txtYearHire;
            this.txtYearHire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYearHire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYearHire.FocusedState.Parent = this.txtYearHire;
            this.txtYearHire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYearHire.HoverState.Parent = this.txtYearHire;
            this.txtYearHire.Location = new System.Drawing.Point(281, 205);
            this.txtYearHire.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYearHire.Name = "txtYearHire";
            this.txtYearHire.PasswordChar = '\0';
            this.txtYearHire.PlaceholderText = "";
            this.txtYearHire.SelectedText = "";
            this.txtYearHire.ShadowDecoration.Parent = this.txtYearHire;
            this.txtYearHire.Size = new System.Drawing.Size(150, 41);
            this.txtYearHire.TabIndex = 8;
            // 
            // txtMonthHire
            // 
            this.txtMonthHire.BackColor = System.Drawing.Color.Transparent;
            this.txtMonthHire.BorderRadius = 8;
            this.txtMonthHire.BorderThickness = 2;
            this.txtMonthHire.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtMonthHire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtMonthHire.FocusedColor = System.Drawing.Color.Empty;
            this.txtMonthHire.FocusedState.Parent = this.txtMonthHire;
            this.txtMonthHire.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMonthHire.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtMonthHire.FormattingEnabled = true;
            this.txtMonthHire.HoverState.Parent = this.txtMonthHire;
            this.txtMonthHire.ItemHeight = 30;
            this.txtMonthHire.ItemsAppearance.Parent = this.txtMonthHire;
            this.txtMonthHire.Location = new System.Drawing.Point(281, 63);
            this.txtMonthHire.Name = "txtMonthHire";
            this.txtMonthHire.ShadowDecoration.Parent = this.txtMonthHire;
            this.txtMonthHire.Size = new System.Drawing.Size(150, 36);
            this.txtMonthHire.TabIndex = 7;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.White;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 137;
            this.iconPictureBox2.Location = new System.Drawing.Point(32, 63);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(137, 137);
            this.iconPictureBox2.TabIndex = 6;
            this.iconPictureBox2.TabStop = false;
            // 
            // FConfirmHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 420);
            this.Controls.Add(this.panelMonthHire);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.dateHire);
            this.Controls.Add(this.lblSelectHire);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelTaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FConfirmHire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FConfirmHire";
            this.Load += new System.EventHandler(this.FConfirmHire_Load);
            this.panelTaskBar.ResumeLayout(false);
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelMonthHire.ResumeLayout(false);
            this.panelMonthHire.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTaskBar;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnWorkMonth;
        private System.Windows.Forms.Button btnWorkDay;
        private System.Windows.Forms.Label lblSelectHire;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Button btnHire;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateHire;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panelMonthHire;
        private Guna.UI2.WinForms.Guna2ComboBox txtMonthHire;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label lblYearHire;
        private System.Windows.Forms.Label lblMonthHire;
        private Guna.UI2.WinForms.Guna2TextBox txtYearHire;
    }
}