namespace DemoWin
{
    partial class FHire
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
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContain = new System.Windows.Forms.Panel();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.PanelComboWorkHour = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWorkHour = new FontAwesome.Sharp.IconButton();
            this.btn7h10h30 = new FontAwesome.Sharp.IconButton();
            this.btn12h305h = new FontAwesome.Sharp.IconButton();
            this.btnOvertime = new FontAwesome.Sharp.IconButton();
            this.PanelComboWorkDay = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWorkDay = new FontAwesome.Sharp.IconButton();
            this.btnMonday = new FontAwesome.Sharp.IconButton();
            this.btnTuesday = new FontAwesome.Sharp.IconButton();
            this.btnWednesday = new FontAwesome.Sharp.IconButton();
            this.btnThursday = new FontAwesome.Sharp.IconButton();
            this.btnFriday = new FontAwesome.Sharp.IconButton();
            this.btnSaturday = new FontAwesome.Sharp.IconButton();
            this.PanelComboRate = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRate = new FontAwesome.Sharp.IconButton();
            this.btn1Sao = new FontAwesome.Sharp.IconButton();
            this.btn2Sao = new FontAwesome.Sharp.IconButton();
            this.btn3Sao = new FontAwesome.Sharp.IconButton();
            this.btn4Sao = new FontAwesome.Sharp.IconButton();
            this.btn5Sao = new FontAwesome.Sharp.IconButton();
            this.PanelComboHireCost = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHireCost = new FontAwesome.Sharp.IconButton();
            this.btn8Tr = new FontAwesome.Sharp.IconButton();
            this.btn810Tr = new FontAwesome.Sharp.IconButton();
            this.btn1020Tr = new FontAwesome.Sharp.IconButton();
            this.btn20Tr = new FontAwesome.Sharp.IconButton();
            this.PanelComboAge = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAge = new FontAwesome.Sharp.IconButton();
            this.btn1618 = new FontAwesome.Sharp.IconButton();
            this.btn1825 = new FontAwesome.Sharp.IconButton();
            this.btn25 = new FontAwesome.Sharp.IconButton();
            this.PanelComboAddress = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddress = new FontAwesome.Sharp.IconButton();
            this.btnHaNoi = new FontAwesome.Sharp.IconButton();
            this.btnTpHCM = new FontAwesome.Sharp.IconButton();
            this.btnHue = new FontAwesome.Sharp.IconButton();
            this.btnNoiKhac = new FontAwesome.Sharp.IconButton();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panelButtom = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.RollBtnAge = new System.Windows.Forms.Timer(this.components);
            this.RollBtnAddress = new System.Windows.Forms.Timer(this.components);
            this.RollBtnRate = new System.Windows.Forms.Timer(this.components);
            this.RollBtnHireCost = new System.Windows.Forms.Timer(this.components);
            this.RollBtnWorkDay = new System.Windows.Forms.Timer(this.components);
            this.RollBtnWorkHour = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panelContain.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.PanelComboWorkHour.SuspendLayout();
            this.PanelComboWorkDay.SuspendLayout();
            this.PanelComboRate.SuspendLayout();
            this.PanelComboHireCost.SuspendLayout();
            this.PanelComboAge.SuspendLayout();
            this.PanelComboAddress.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.lblTitle);
            this.panelMenu.Controls.Add(this.panelContain);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(262, 622);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenu_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(76, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(54, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // panelContain
            // 
            this.panelContain.AutoScroll = true;
            this.panelContain.BackColor = System.Drawing.Color.White;
            this.panelContain.Controls.Add(this.panelSearch);
            this.panelContain.Controls.Add(this.PanelComboWorkHour);
            this.panelContain.Controls.Add(this.PanelComboWorkDay);
            this.panelContain.Controls.Add(this.PanelComboRate);
            this.panelContain.Controls.Add(this.PanelComboHireCost);
            this.panelContain.Controls.Add(this.PanelComboAge);
            this.panelContain.Controls.Add(this.PanelComboAddress);
            this.panelContain.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContain.Location = new System.Drawing.Point(15, 47);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(230, 550);
            this.panelContain.TabIndex = 1;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.White;
            this.panelSearch.Controls.Add(this.btnSearch);
            this.panelSearch.Controls.Add(this.txtSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 348);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(230, 134);
            this.panelSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.Image = global::DemoWin.Properties.Resources.search__3_;
            this.btnSearch.Location = new System.Drawing.Point(6, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(196, 45);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "Tìm kiếm";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.Parent = this.txtSearch;
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedState.Parent = this.txtSearch;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.HoverState.Parent = this.txtSearch;
            this.txtSearch.Location = new System.Drawing.Point(6, 23);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(8);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionStart = 8;
            this.txtSearch.ShadowDecoration.Parent = this.txtSearch;
            this.txtSearch.Size = new System.Drawing.Size(196, 46);
            this.txtSearch.TabIndex = 10;
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // PanelComboWorkHour
            // 
            this.PanelComboWorkHour.BackColor = System.Drawing.Color.White;
            this.PanelComboWorkHour.Controls.Add(this.btnWorkHour);
            this.PanelComboWorkHour.Controls.Add(this.btn7h10h30);
            this.PanelComboWorkHour.Controls.Add(this.btn12h305h);
            this.PanelComboWorkHour.Controls.Add(this.btnOvertime);
            this.PanelComboWorkHour.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboWorkHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboWorkHour.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboWorkHour.Location = new System.Drawing.Point(0, 290);
            this.PanelComboWorkHour.MaximumSize = new System.Drawing.Size(214, 229);
            this.PanelComboWorkHour.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboWorkHour.Name = "PanelComboWorkHour";
            this.PanelComboWorkHour.Size = new System.Drawing.Size(214, 58);
            this.PanelComboWorkHour.TabIndex = 4;
            // 
            // btnWorkHour
            // 
            this.btnWorkHour.FlatAppearance.BorderSize = 0;
            this.btnWorkHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkHour.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnWorkHour.IconColor = System.Drawing.Color.Navy;
            this.btnWorkHour.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWorkHour.IconSize = 25;
            this.btnWorkHour.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkHour.Location = new System.Drawing.Point(3, 3);
            this.btnWorkHour.Name = "btnWorkHour";
            this.btnWorkHour.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWorkHour.Size = new System.Drawing.Size(211, 52);
            this.btnWorkHour.TabIndex = 0;
            this.btnWorkHour.Text = "Giờ làm";
            this.btnWorkHour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkHour.UseVisualStyleBackColor = true;
            this.btnWorkHour.Click += new System.EventHandler(this.btnWorkHour_Click);
            // 
            // btn7h10h30
            // 
            this.btn7h10h30.FlatAppearance.BorderSize = 0;
            this.btn7h10h30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7h10h30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7h10h30.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn7h10h30.IconColor = System.Drawing.Color.Navy;
            this.btn7h10h30.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn7h10h30.IconSize = 25;
            this.btn7h10h30.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn7h10h30.Location = new System.Drawing.Point(3, 61);
            this.btn7h10h30.Name = "btn7h10h30";
            this.btn7h10h30.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn7h10h30.Size = new System.Drawing.Size(211, 52);
            this.btn7h10h30.TabIndex = 1;
            this.btn7h10h30.Text = "7h  - 10h30";
            this.btn7h10h30.UseVisualStyleBackColor = true;
            this.btn7h10h30.Click += new System.EventHandler(this.btn7h10h30_Click);
            // 
            // btn12h305h
            // 
            this.btn12h305h.FlatAppearance.BorderSize = 0;
            this.btn12h305h.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12h305h.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12h305h.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn12h305h.IconColor = System.Drawing.Color.Navy;
            this.btn12h305h.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn12h305h.IconSize = 25;
            this.btn12h305h.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn12h305h.Location = new System.Drawing.Point(3, 119);
            this.btn12h305h.Name = "btn12h305h";
            this.btn12h305h.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn12h305h.Size = new System.Drawing.Size(211, 52);
            this.btn12h305h.TabIndex = 2;
            this.btn12h305h.Text = "12h30 - 17h";
            this.btn12h305h.UseVisualStyleBackColor = true;
            this.btn12h305h.Click += new System.EventHandler(this.btn12h305h_Click);
            // 
            // btnOvertime
            // 
            this.btnOvertime.FlatAppearance.BorderSize = 0;
            this.btnOvertime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOvertime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOvertime.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnOvertime.IconColor = System.Drawing.Color.Navy;
            this.btnOvertime.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOvertime.IconSize = 25;
            this.btnOvertime.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOvertime.Location = new System.Drawing.Point(3, 177);
            this.btnOvertime.Name = "btnOvertime";
            this.btnOvertime.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnOvertime.Size = new System.Drawing.Size(211, 52);
            this.btnOvertime.TabIndex = 2;
            this.btnOvertime.Text = "Ngoài giờ";
            this.btnOvertime.UseVisualStyleBackColor = true;
            this.btnOvertime.Click += new System.EventHandler(this.btnOvertime_Click);
            // 
            // PanelComboWorkDay
            // 
            this.PanelComboWorkDay.BackColor = System.Drawing.Color.White;
            this.PanelComboWorkDay.Controls.Add(this.btnWorkDay);
            this.PanelComboWorkDay.Controls.Add(this.btnMonday);
            this.PanelComboWorkDay.Controls.Add(this.btnTuesday);
            this.PanelComboWorkDay.Controls.Add(this.btnWednesday);
            this.PanelComboWorkDay.Controls.Add(this.btnThursday);
            this.PanelComboWorkDay.Controls.Add(this.btnFriday);
            this.PanelComboWorkDay.Controls.Add(this.btnSaturday);
            this.PanelComboWorkDay.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboWorkDay.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboWorkDay.Location = new System.Drawing.Point(0, 232);
            this.PanelComboWorkDay.MaximumSize = new System.Drawing.Size(214, 403);
            this.PanelComboWorkDay.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboWorkDay.Name = "PanelComboWorkDay";
            this.PanelComboWorkDay.Size = new System.Drawing.Size(214, 58);
            this.PanelComboWorkDay.TabIndex = 3;
            // 
            // btnWorkDay
            // 
            this.btnWorkDay.FlatAppearance.BorderSize = 0;
            this.btnWorkDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkDay.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnWorkDay.IconColor = System.Drawing.Color.Navy;
            this.btnWorkDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWorkDay.IconSize = 25;
            this.btnWorkDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkDay.Location = new System.Drawing.Point(3, 3);
            this.btnWorkDay.Name = "btnWorkDay";
            this.btnWorkDay.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWorkDay.Size = new System.Drawing.Size(211, 52);
            this.btnWorkDay.TabIndex = 0;
            this.btnWorkDay.Text = "Ngày làm/Tuần";
            this.btnWorkDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkDay.UseVisualStyleBackColor = true;
            this.btnWorkDay.Click += new System.EventHandler(this.btnWorkDay_Click);
            // 
            // btnMonday
            // 
            this.btnMonday.FlatAppearance.BorderSize = 0;
            this.btnMonday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnMonday.IconColor = System.Drawing.Color.Navy;
            this.btnMonday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonday.IconSize = 25;
            this.btnMonday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonday.Location = new System.Drawing.Point(3, 61);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnMonday.Size = new System.Drawing.Size(211, 52);
            this.btnMonday.TabIndex = 3;
            this.btnMonday.Text = "Thứ hai";
            this.btnMonday.UseVisualStyleBackColor = true;
            this.btnMonday.Click += new System.EventHandler(this.btnMonday_Click);
            // 
            // btnTuesday
            // 
            this.btnTuesday.FlatAppearance.BorderSize = 0;
            this.btnTuesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTuesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuesday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnTuesday.IconColor = System.Drawing.Color.Navy;
            this.btnTuesday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTuesday.IconSize = 25;
            this.btnTuesday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTuesday.Location = new System.Drawing.Point(3, 119);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnTuesday.Size = new System.Drawing.Size(211, 52);
            this.btnTuesday.TabIndex = 4;
            this.btnTuesday.Text = "Thứ ba";
            this.btnTuesday.UseVisualStyleBackColor = true;
            this.btnTuesday.Click += new System.EventHandler(this.btnTuesday_Click);
            // 
            // btnWednesday
            // 
            this.btnWednesday.FlatAppearance.BorderSize = 0;
            this.btnWednesday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWednesday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWednesday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnWednesday.IconColor = System.Drawing.Color.Navy;
            this.btnWednesday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWednesday.IconSize = 25;
            this.btnWednesday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWednesday.Location = new System.Drawing.Point(3, 177);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWednesday.Size = new System.Drawing.Size(211, 52);
            this.btnWednesday.TabIndex = 4;
            this.btnWednesday.Text = "Thứ tư";
            this.btnWednesday.UseVisualStyleBackColor = true;
            this.btnWednesday.Click += new System.EventHandler(this.btnWednesday_Click);
            // 
            // btnThursday
            // 
            this.btnThursday.FlatAppearance.BorderSize = 0;
            this.btnThursday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThursday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThursday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnThursday.IconColor = System.Drawing.Color.Navy;
            this.btnThursday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThursday.IconSize = 25;
            this.btnThursday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThursday.Location = new System.Drawing.Point(3, 235);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnThursday.Size = new System.Drawing.Size(211, 52);
            this.btnThursday.TabIndex = 4;
            this.btnThursday.Text = "Thứ năm";
            this.btnThursday.UseVisualStyleBackColor = true;
            this.btnThursday.Click += new System.EventHandler(this.btnThursday_Click);
            // 
            // btnFriday
            // 
            this.btnFriday.FlatAppearance.BorderSize = 0;
            this.btnFriday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFriday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFriday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnFriday.IconColor = System.Drawing.Color.Navy;
            this.btnFriday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFriday.IconSize = 25;
            this.btnFriday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFriday.Location = new System.Drawing.Point(3, 293);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnFriday.Size = new System.Drawing.Size(211, 52);
            this.btnFriday.TabIndex = 4;
            this.btnFriday.Text = "Thứ sáu";
            this.btnFriday.UseVisualStyleBackColor = true;
            this.btnFriday.Click += new System.EventHandler(this.btnFriday_Click);
            // 
            // btnSaturday
            // 
            this.btnSaturday.FlatAppearance.BorderSize = 0;
            this.btnSaturday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaturday.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaturday.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnSaturday.IconColor = System.Drawing.Color.Navy;
            this.btnSaturday.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSaturday.IconSize = 25;
            this.btnSaturday.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaturday.Location = new System.Drawing.Point(3, 351);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnSaturday.Size = new System.Drawing.Size(211, 52);
            this.btnSaturday.TabIndex = 5;
            this.btnSaturday.Text = "Thứ bảy";
            this.btnSaturday.UseVisualStyleBackColor = true;
            this.btnSaturday.Click += new System.EventHandler(this.btnSaturday_Click);
            // 
            // PanelComboRate
            // 
            this.PanelComboRate.BackColor = System.Drawing.Color.White;
            this.PanelComboRate.Controls.Add(this.btnRate);
            this.PanelComboRate.Controls.Add(this.btn1Sao);
            this.PanelComboRate.Controls.Add(this.btn2Sao);
            this.PanelComboRate.Controls.Add(this.btn3Sao);
            this.PanelComboRate.Controls.Add(this.btn4Sao);
            this.PanelComboRate.Controls.Add(this.btn5Sao);
            this.PanelComboRate.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboRate.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboRate.Location = new System.Drawing.Point(0, 174);
            this.PanelComboRate.MaximumSize = new System.Drawing.Size(214, 343);
            this.PanelComboRate.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboRate.Name = "PanelComboRate";
            this.PanelComboRate.Size = new System.Drawing.Size(214, 58);
            this.PanelComboRate.TabIndex = 2;
            // 
            // btnRate
            // 
            this.btnRate.FlatAppearance.BorderSize = 0;
            this.btnRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRate.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnRate.IconColor = System.Drawing.Color.Navy;
            this.btnRate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRate.IconSize = 25;
            this.btnRate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRate.Location = new System.Drawing.Point(3, 3);
            this.btnRate.Name = "btnRate";
            this.btnRate.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnRate.Size = new System.Drawing.Size(211, 52);
            this.btnRate.TabIndex = 0;
            this.btnRate.Text = "Số sao";
            this.btnRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRate.UseVisualStyleBackColor = true;
            this.btnRate.Click += new System.EventHandler(this.btnRate_Click);
            // 
            // btn1Sao
            // 
            this.btn1Sao.FlatAppearance.BorderSize = 0;
            this.btn1Sao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1Sao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1Sao.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn1Sao.IconColor = System.Drawing.Color.Navy;
            this.btn1Sao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1Sao.IconSize = 25;
            this.btn1Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1Sao.Location = new System.Drawing.Point(3, 61);
            this.btn1Sao.Name = "btn1Sao";
            this.btn1Sao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn1Sao.Size = new System.Drawing.Size(211, 52);
            this.btn1Sao.TabIndex = 3;
            this.btn1Sao.Text = "1 Sao";
            this.btn1Sao.UseVisualStyleBackColor = true;
            this.btn1Sao.Click += new System.EventHandler(this.btn1Sao_Click);
            // 
            // btn2Sao
            // 
            this.btn2Sao.FlatAppearance.BorderSize = 0;
            this.btn2Sao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2Sao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2Sao.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn2Sao.IconColor = System.Drawing.Color.Navy;
            this.btn2Sao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn2Sao.IconSize = 25;
            this.btn2Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn2Sao.Location = new System.Drawing.Point(3, 119);
            this.btn2Sao.Name = "btn2Sao";
            this.btn2Sao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn2Sao.Size = new System.Drawing.Size(211, 52);
            this.btn2Sao.TabIndex = 4;
            this.btn2Sao.Text = "2 Sao";
            this.btn2Sao.UseVisualStyleBackColor = true;
            this.btn2Sao.Click += new System.EventHandler(this.btn2Sao_Click);
            // 
            // btn3Sao
            // 
            this.btn3Sao.FlatAppearance.BorderSize = 0;
            this.btn3Sao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3Sao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3Sao.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn3Sao.IconColor = System.Drawing.Color.Navy;
            this.btn3Sao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn3Sao.IconSize = 25;
            this.btn3Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn3Sao.Location = new System.Drawing.Point(3, 177);
            this.btn3Sao.Name = "btn3Sao";
            this.btn3Sao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn3Sao.Size = new System.Drawing.Size(211, 52);
            this.btn3Sao.TabIndex = 4;
            this.btn3Sao.Text = "3 Sao";
            this.btn3Sao.UseVisualStyleBackColor = true;
            this.btn3Sao.Click += new System.EventHandler(this.btn3Sao_Click);
            // 
            // btn4Sao
            // 
            this.btn4Sao.FlatAppearance.BorderSize = 0;
            this.btn4Sao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4Sao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4Sao.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn4Sao.IconColor = System.Drawing.Color.Navy;
            this.btn4Sao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn4Sao.IconSize = 25;
            this.btn4Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn4Sao.Location = new System.Drawing.Point(3, 235);
            this.btn4Sao.Name = "btn4Sao";
            this.btn4Sao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn4Sao.Size = new System.Drawing.Size(211, 52);
            this.btn4Sao.TabIndex = 4;
            this.btn4Sao.Text = "4 Sao";
            this.btn4Sao.UseVisualStyleBackColor = true;
            this.btn4Sao.Click += new System.EventHandler(this.btn4Sao_Click);
            // 
            // btn5Sao
            // 
            this.btn5Sao.FlatAppearance.BorderSize = 0;
            this.btn5Sao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5Sao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5Sao.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn5Sao.IconColor = System.Drawing.Color.Navy;
            this.btn5Sao.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn5Sao.IconSize = 25;
            this.btn5Sao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn5Sao.Location = new System.Drawing.Point(3, 293);
            this.btn5Sao.Name = "btn5Sao";
            this.btn5Sao.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn5Sao.Size = new System.Drawing.Size(211, 52);
            this.btn5Sao.TabIndex = 4;
            this.btn5Sao.Text = "5 Sao";
            this.btn5Sao.UseVisualStyleBackColor = true;
            this.btn5Sao.Click += new System.EventHandler(this.btn5Sao_Click);
            // 
            // PanelComboHireCost
            // 
            this.PanelComboHireCost.BackColor = System.Drawing.Color.White;
            this.PanelComboHireCost.Controls.Add(this.btnHireCost);
            this.PanelComboHireCost.Controls.Add(this.btn8Tr);
            this.PanelComboHireCost.Controls.Add(this.btn810Tr);
            this.PanelComboHireCost.Controls.Add(this.btn1020Tr);
            this.PanelComboHireCost.Controls.Add(this.btn20Tr);
            this.PanelComboHireCost.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboHireCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboHireCost.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboHireCost.Location = new System.Drawing.Point(0, 116);
            this.PanelComboHireCost.MaximumSize = new System.Drawing.Size(214, 285);
            this.PanelComboHireCost.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboHireCost.Name = "PanelComboHireCost";
            this.PanelComboHireCost.Size = new System.Drawing.Size(214, 58);
            this.PanelComboHireCost.TabIndex = 1;
            // 
            // btnHireCost
            // 
            this.btnHireCost.FlatAppearance.BorderSize = 0;
            this.btnHireCost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHireCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHireCost.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnHireCost.IconColor = System.Drawing.Color.Navy;
            this.btnHireCost.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHireCost.IconSize = 25;
            this.btnHireCost.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHireCost.Location = new System.Drawing.Point(3, 3);
            this.btnHireCost.Name = "btnHireCost";
            this.btnHireCost.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnHireCost.Size = new System.Drawing.Size(211, 52);
            this.btnHireCost.TabIndex = 0;
            this.btnHireCost.Text = "Chi phí thuê";
            this.btnHireCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHireCost.UseVisualStyleBackColor = true;
            this.btnHireCost.Click += new System.EventHandler(this.btnHireCost_Click);
            // 
            // btn8Tr
            // 
            this.btn8Tr.FlatAppearance.BorderSize = 0;
            this.btn8Tr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8Tr.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn8Tr.IconColor = System.Drawing.Color.Navy;
            this.btn8Tr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn8Tr.IconSize = 25;
            this.btn8Tr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn8Tr.Location = new System.Drawing.Point(3, 61);
            this.btn8Tr.Name = "btn8Tr";
            this.btn8Tr.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn8Tr.Size = new System.Drawing.Size(211, 52);
            this.btn8Tr.TabIndex = 1;
            this.btn8Tr.Text = "Dưới 8 Tr/Tháng";
            this.btn8Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn8Tr.UseVisualStyleBackColor = true;
            this.btn8Tr.Click += new System.EventHandler(this.btn8Tr_Click);
            // 
            // btn810Tr
            // 
            this.btn810Tr.FlatAppearance.BorderSize = 0;
            this.btn810Tr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn810Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn810Tr.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn810Tr.IconColor = System.Drawing.Color.Navy;
            this.btn810Tr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn810Tr.IconSize = 25;
            this.btn810Tr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn810Tr.Location = new System.Drawing.Point(3, 119);
            this.btn810Tr.Name = "btn810Tr";
            this.btn810Tr.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn810Tr.Size = new System.Drawing.Size(211, 52);
            this.btn810Tr.TabIndex = 2;
            this.btn810Tr.Text = "8 - 10 Tr/Tháng";
            this.btn810Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn810Tr.UseVisualStyleBackColor = true;
            this.btn810Tr.Click += new System.EventHandler(this.btn810Tr_Click);
            // 
            // btn1020Tr
            // 
            this.btn1020Tr.FlatAppearance.BorderSize = 0;
            this.btn1020Tr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1020Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1020Tr.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn1020Tr.IconColor = System.Drawing.Color.Navy;
            this.btn1020Tr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1020Tr.IconSize = 25;
            this.btn1020Tr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1020Tr.Location = new System.Drawing.Point(3, 177);
            this.btn1020Tr.Name = "btn1020Tr";
            this.btn1020Tr.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn1020Tr.Size = new System.Drawing.Size(211, 52);
            this.btn1020Tr.TabIndex = 2;
            this.btn1020Tr.Text = "10 - 20 Tr/Tháng";
            this.btn1020Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1020Tr.UseVisualStyleBackColor = true;
            this.btn1020Tr.Click += new System.EventHandler(this.btn1020Tr_Click);
            // 
            // btn20Tr
            // 
            this.btn20Tr.FlatAppearance.BorderSize = 0;
            this.btn20Tr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20Tr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20Tr.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn20Tr.IconColor = System.Drawing.Color.Navy;
            this.btn20Tr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn20Tr.IconSize = 25;
            this.btn20Tr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn20Tr.Location = new System.Drawing.Point(3, 235);
            this.btn20Tr.Name = "btn20Tr";
            this.btn20Tr.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn20Tr.Size = new System.Drawing.Size(211, 52);
            this.btn20Tr.TabIndex = 2;
            this.btn20Tr.Text = "Trên 20    Tr/Tháng";
            this.btn20Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn20Tr.UseVisualStyleBackColor = true;
            this.btn20Tr.Click += new System.EventHandler(this.btn20Tr_Click);
            // 
            // PanelComboAge
            // 
            this.PanelComboAge.BackColor = System.Drawing.Color.White;
            this.PanelComboAge.Controls.Add(this.btnAge);
            this.PanelComboAge.Controls.Add(this.btn1618);
            this.PanelComboAge.Controls.Add(this.btn1825);
            this.PanelComboAge.Controls.Add(this.btn25);
            this.PanelComboAge.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboAge.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboAge.Location = new System.Drawing.Point(0, 58);
            this.PanelComboAge.MaximumSize = new System.Drawing.Size(214, 229);
            this.PanelComboAge.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboAge.Name = "PanelComboAge";
            this.PanelComboAge.Size = new System.Drawing.Size(214, 58);
            this.PanelComboAge.TabIndex = 0;
            // 
            // btnAge
            // 
            this.btnAge.FlatAppearance.BorderSize = 0;
            this.btnAge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAge.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnAge.IconColor = System.Drawing.Color.Navy;
            this.btnAge.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAge.IconSize = 25;
            this.btnAge.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAge.Location = new System.Drawing.Point(3, 3);
            this.btnAge.Name = "btnAge";
            this.btnAge.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAge.Size = new System.Drawing.Size(211, 52);
            this.btnAge.TabIndex = 0;
            this.btnAge.Text = "Tuổi";
            this.btnAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAge.UseVisualStyleBackColor = true;
            this.btnAge.Click += new System.EventHandler(this.btnAge_Click);
            // 
            // btn1618
            // 
            this.btn1618.FlatAppearance.BorderSize = 0;
            this.btn1618.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1618.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1618.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn1618.IconColor = System.Drawing.Color.Navy;
            this.btn1618.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1618.IconSize = 25;
            this.btn1618.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1618.Location = new System.Drawing.Point(3, 61);
            this.btn1618.Name = "btn1618";
            this.btn1618.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn1618.Size = new System.Drawing.Size(211, 52);
            this.btn1618.TabIndex = 1;
            this.btn1618.Text = "16 - 18 tuổi";
            this.btn1618.UseVisualStyleBackColor = true;
            this.btn1618.Click += new System.EventHandler(this.btn1618_Click);
            // 
            // btn1825
            // 
            this.btn1825.FlatAppearance.BorderSize = 0;
            this.btn1825.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1825.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1825.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn1825.IconColor = System.Drawing.Color.Navy;
            this.btn1825.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn1825.IconSize = 25;
            this.btn1825.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn1825.Location = new System.Drawing.Point(3, 119);
            this.btn1825.Name = "btn1825";
            this.btn1825.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn1825.Size = new System.Drawing.Size(211, 52);
            this.btn1825.TabIndex = 2;
            this.btn1825.Text = "18 - 25 tuổi";
            this.btn1825.UseVisualStyleBackColor = true;
            this.btn1825.Click += new System.EventHandler(this.btn1825_Click);
            // 
            // btn25
            // 
            this.btn25.FlatAppearance.BorderSize = 0;
            this.btn25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn25.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn25.IconColor = System.Drawing.Color.Navy;
            this.btn25.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn25.IconSize = 25;
            this.btn25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn25.Location = new System.Drawing.Point(3, 177);
            this.btn25.Name = "btn25";
            this.btn25.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn25.Size = new System.Drawing.Size(211, 52);
            this.btn25.TabIndex = 2;
            this.btn25.Text = "Trên 25 tuổi";
            this.btn25.UseVisualStyleBackColor = true;
            this.btn25.Click += new System.EventHandler(this.btn25_Click);
            // 
            // PanelComboAddress
            // 
            this.PanelComboAddress.BackColor = System.Drawing.Color.White;
            this.PanelComboAddress.Controls.Add(this.btnAddress);
            this.PanelComboAddress.Controls.Add(this.btnHaNoi);
            this.PanelComboAddress.Controls.Add(this.btnTpHCM);
            this.PanelComboAddress.Controls.Add(this.btnHue);
            this.PanelComboAddress.Controls.Add(this.btnNoiKhac);
            this.PanelComboAddress.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelComboAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboAddress.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboAddress.Location = new System.Drawing.Point(0, 0);
            this.PanelComboAddress.MaximumSize = new System.Drawing.Size(214, 287);
            this.PanelComboAddress.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboAddress.Name = "PanelComboAddress";
            this.PanelComboAddress.Size = new System.Drawing.Size(214, 58);
            this.PanelComboAddress.TabIndex = 1;
            // 
            // btnAddress
            // 
            this.btnAddress.FlatAppearance.BorderSize = 0;
            this.btnAddress.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddress.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnAddress.IconColor = System.Drawing.Color.Navy;
            this.btnAddress.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddress.IconSize = 25;
            this.btnAddress.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddress.Location = new System.Drawing.Point(3, 3);
            this.btnAddress.Name = "btnAddress";
            this.btnAddress.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAddress.Size = new System.Drawing.Size(211, 52);
            this.btnAddress.TabIndex = 0;
            this.btnAddress.Text = "Địa chỉ";
            this.btnAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddress.UseVisualStyleBackColor = true;
            this.btnAddress.Click += new System.EventHandler(this.btnAddress_Click);
            // 
            // btnHaNoi
            // 
            this.btnHaNoi.FlatAppearance.BorderSize = 0;
            this.btnHaNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHaNoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHaNoi.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnHaNoi.IconColor = System.Drawing.Color.Navy;
            this.btnHaNoi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHaNoi.IconSize = 25;
            this.btnHaNoi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHaNoi.Location = new System.Drawing.Point(3, 61);
            this.btnHaNoi.Name = "btnHaNoi";
            this.btnHaNoi.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnHaNoi.Size = new System.Drawing.Size(211, 52);
            this.btnHaNoi.TabIndex = 2;
            this.btnHaNoi.Text = "Hà Nội";
            this.btnHaNoi.UseVisualStyleBackColor = true;
            this.btnHaNoi.Click += new System.EventHandler(this.btnHaNoi_Click);
            // 
            // btnTpHCM
            // 
            this.btnTpHCM.FlatAppearance.BorderSize = 0;
            this.btnTpHCM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTpHCM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTpHCM.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnTpHCM.IconColor = System.Drawing.Color.Navy;
            this.btnTpHCM.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTpHCM.IconSize = 25;
            this.btnTpHCM.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTpHCM.Location = new System.Drawing.Point(3, 119);
            this.btnTpHCM.Name = "btnTpHCM";
            this.btnTpHCM.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnTpHCM.Size = new System.Drawing.Size(211, 52);
            this.btnTpHCM.TabIndex = 3;
            this.btnTpHCM.Text = "Tp Hồ Chí Minh";
            this.btnTpHCM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTpHCM.UseVisualStyleBackColor = true;
            this.btnTpHCM.Click += new System.EventHandler(this.btnTpHCM_Click);
            // 
            // btnHue
            // 
            this.btnHue.FlatAppearance.BorderSize = 0;
            this.btnHue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHue.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnHue.IconColor = System.Drawing.Color.Navy;
            this.btnHue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHue.IconSize = 25;
            this.btnHue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHue.Location = new System.Drawing.Point(3, 177);
            this.btnHue.Name = "btnHue";
            this.btnHue.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnHue.Size = new System.Drawing.Size(211, 52);
            this.btnHue.TabIndex = 3;
            this.btnHue.Text = "Huế";
            this.btnHue.UseVisualStyleBackColor = true;
            this.btnHue.Click += new System.EventHandler(this.btnHue_Click);
            // 
            // btnNoiKhac
            // 
            this.btnNoiKhac.FlatAppearance.BorderSize = 0;
            this.btnNoiKhac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNoiKhac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoiKhac.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnNoiKhac.IconColor = System.Drawing.Color.Navy;
            this.btnNoiKhac.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNoiKhac.IconSize = 25;
            this.btnNoiKhac.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNoiKhac.Location = new System.Drawing.Point(3, 235);
            this.btnNoiKhac.Name = "btnNoiKhac";
            this.btnNoiKhac.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnNoiKhac.Size = new System.Drawing.Size(211, 52);
            this.btnNoiKhac.TabIndex = 4;
            this.btnNoiKhac.Text = "Nơi khác";
            this.btnNoiKhac.UseVisualStyleBackColor = true;
            this.btnNoiKhac.Click += new System.EventHandler(this.btnNoiKhac_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnHelp);
            this.panelTop.Controls.Add(this.btnChangeColor);
            this.panelTop.Controls.Add(this.btnBack);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(262, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(925, 47);
            this.panelTop.TabIndex = 25;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DemoWin.Properties.Resources.cross_small;
            this.btnClose.Location = new System.Drawing.Point(878, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 14;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::DemoWin.Properties.Resources.minus_small;
            this.btnMinimize.Location = new System.Drawing.Point(810, 6);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 13;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = global::DemoWin.Properties.Resources.interrogation1;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(282, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(125, 47);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.Text = "    Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.FlatAppearance.BorderSize = 0;
            this.btnChangeColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeColor.ForeColor = System.Drawing.Color.White;
            this.btnChangeColor.Image = global::DemoWin.Properties.Resources.fill;
            this.btnChangeColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeColor.Location = new System.Drawing.Point(131, 0);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnChangeColor.Size = new System.Drawing.Size(155, 47);
            this.btnChangeColor.TabIndex = 10;
            this.btnChangeColor.Text = "    Change";
            this.btnChangeColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeColor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = global::DemoWin.Properties.Resources.undo;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBack.Size = new System.Drawing.Size(136, 47);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "    Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panelButtom
            // 
            this.panelButtom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelButtom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtom.Location = new System.Drawing.Point(262, 597);
            this.panelButtom.Name = "panelButtom";
            this.panelButtom.Size = new System.Drawing.Size(925, 25);
            this.panelButtom.TabIndex = 27;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel.Location = new System.Drawing.Point(262, 47);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(925, 550);
            this.flowLayoutPanel.TabIndex = 28;
            this.flowLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // RollBtnAge
            // 
            this.RollBtnAge.Interval = 1;
            this.RollBtnAge.Tick += new System.EventHandler(this.RollBtnAge_Tick);
            // 
            // RollBtnAddress
            // 
            this.RollBtnAddress.Interval = 1;
            this.RollBtnAddress.Tick += new System.EventHandler(this.RollBtnAddress_Tick);
            // 
            // RollBtnRate
            // 
            this.RollBtnRate.Interval = 1;
            this.RollBtnRate.Tick += new System.EventHandler(this.RollBtnRate_Tick);
            // 
            // RollBtnHireCost
            // 
            this.RollBtnHireCost.Interval = 1;
            this.RollBtnHireCost.Tick += new System.EventHandler(this.RollBtnHireCost_Tick);
            // 
            // RollBtnWorkDay
            // 
            this.RollBtnWorkDay.Interval = 1;
            this.RollBtnWorkDay.Tick += new System.EventHandler(this.RollBtnWorkDay_Tick);
            // 
            // RollBtnWorkHour
            // 
            this.RollBtnWorkHour.Interval = 1;
            this.RollBtnWorkHour.Tick += new System.EventHandler(this.RollBtnWorkHour_Tick);
            // 
            // FHire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1187, 622);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panelButtom);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FHire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FHire";
            this.Load += new System.EventHandler(this.FHire_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelContain.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.PanelComboWorkHour.ResumeLayout(false);
            this.PanelComboWorkDay.ResumeLayout(false);
            this.PanelComboRate.ResumeLayout(false);
            this.PanelComboHireCost.ResumeLayout(false);
            this.PanelComboAge.ResumeLayout(false);
            this.PanelComboAddress.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelButtom;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel PanelComboAge;
        private FontAwesome.Sharp.IconButton btnAge;
        private System.Windows.Forms.Timer RollBtnAge;
        private System.Windows.Forms.Panel panelContain;
        private System.Windows.Forms.FlowLayoutPanel PanelComboAddress;
        private FontAwesome.Sharp.IconButton btnAddress;
        private System.Windows.Forms.Timer RollBtnAddress;
        private System.Windows.Forms.FlowLayoutPanel PanelComboRate;
        private FontAwesome.Sharp.IconButton btnRate;
        private System.Windows.Forms.Timer RollBtnRate;
        private System.Windows.Forms.Panel panelSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private FontAwesome.Sharp.IconButton btn1618;
        private FontAwesome.Sharp.IconButton btn1825;
        private FontAwesome.Sharp.IconButton btn25;
        private System.Windows.Forms.FlowLayoutPanel PanelComboHireCost;
        private FontAwesome.Sharp.IconButton btnHireCost;
        private FontAwesome.Sharp.IconButton btn8Tr;
        private FontAwesome.Sharp.IconButton btn810Tr;
        private FontAwesome.Sharp.IconButton btn1020Tr;
        private FontAwesome.Sharp.IconButton btn20Tr;
        private FontAwesome.Sharp.IconButton btnHaNoi;
        private FontAwesome.Sharp.IconButton btnTpHCM;
        private FontAwesome.Sharp.IconButton btn1Sao;
        private FontAwesome.Sharp.IconButton btn2Sao;
        private FontAwesome.Sharp.IconButton btn3Sao;
        private FontAwesome.Sharp.IconButton btn4Sao;
        private FontAwesome.Sharp.IconButton btn5Sao;
        private FontAwesome.Sharp.IconButton btnHue;
        private FontAwesome.Sharp.IconButton btnNoiKhac;
        private System.Windows.Forms.Timer RollBtnHireCost;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.FlowLayoutPanel PanelComboWorkDay;
        private FontAwesome.Sharp.IconButton btnWorkDay;
        private FontAwesome.Sharp.IconButton btnMonday;
        private FontAwesome.Sharp.IconButton btnTuesday;
        private FontAwesome.Sharp.IconButton btnWednesday;
        private FontAwesome.Sharp.IconButton btnThursday;
        private FontAwesome.Sharp.IconButton btnFriday;
        private FontAwesome.Sharp.IconButton btnSaturday;
        private System.Windows.Forms.FlowLayoutPanel PanelComboWorkHour;
        private FontAwesome.Sharp.IconButton btnWorkHour;
        private FontAwesome.Sharp.IconButton btn7h10h30;
        private FontAwesome.Sharp.IconButton btn12h305h;
        private FontAwesome.Sharp.IconButton btnOvertime;
        private System.Windows.Forms.Timer RollBtnWorkDay;
        private System.Windows.Forms.Timer RollBtnWorkHour;
    }
}