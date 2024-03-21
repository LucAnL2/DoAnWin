namespace DemoWin
{
    partial class FPostWork
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.txtDataDescribe = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.ucTxtWorker4 = new DemoWin.UCTxtWorker();
            this.ucTxtWorker3 = new DemoWin.UCTxtWorker();
            this.ucTxtWorker2 = new DemoWin.UCTxtWorker();
            this.ucTxtWorker1 = new DemoWin.UCTxtWorker();
            this.ucTxtWorker5 = new DemoWin.UCTxtWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelComboWorkOfDay = new System.Windows.Forms.FlowLayoutPanel();
            this.btnWorkOfDay = new FontAwesome.Sharp.IconButton();
            this.btn246 = new FontAwesome.Sharp.IconButton();
            this.btn357 = new FontAwesome.Sharp.IconButton();
            this.btnAll = new FontAwesome.Sharp.IconButton();
            this.RollBtnDayOfWork = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelComboWorkOfDay.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTop.Controls.Add(this.iconPictureBox1);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1167, 37);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(25, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox1.TabIndex = 8;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Đăng việc";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::DemoWin.Properties.Resources.minus_small;
            this.btnMinimize.Location = new System.Drawing.Point(1080, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 6;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DemoWin.Properties.Resources.cross_small;
            this.btnClose.Location = new System.Drawing.Point(1129, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelBottom
            // 
            this.panelBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelBottom.Controls.Add(this.guna2Button1);
            this.panelBottom.Controls.Add(this.guna2Button2);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 441);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1167, 67);
            this.panelBottom.TabIndex = 3;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 8;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(67, 13);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(104, 43);
            this.guna2Button1.TabIndex = 85;
            this.guna2Button1.Text = "Đăng";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.guna2Button2.BorderColor = System.Drawing.Color.White;
            this.guna2Button2.BorderRadius = 8;
            this.guna2Button2.BorderThickness = 2;
            this.guna2Button2.CheckedState.Parent = this.guna2Button2;
            this.guna2Button2.CustomImages.Parent = this.guna2Button2;
            this.guna2Button2.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.HoverState.Parent = this.guna2Button2;
            this.guna2Button2.Location = new System.Drawing.Point(1011, 13);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.ShadowDecoration.Parent = this.guna2Button2;
            this.guna2Button2.Size = new System.Drawing.Size(104, 43);
            this.guna2Button2.TabIndex = 85;
            this.guna2Button2.Text = "Đóng";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(222, 55);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(331, 36);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "Nhập mô tả công việc:";
            // 
            // txtDataDescribe
            // 
            this.txtDataDescribe.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.txtDataDescribe.BorderRadius = 8;
            this.txtDataDescribe.BorderThickness = 2;
            this.txtDataDescribe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataDescribe.DefaultText = "";
            this.txtDataDescribe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDataDescribe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDataDescribe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataDescribe.DisabledState.Parent = this.txtDataDescribe;
            this.txtDataDescribe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDataDescribe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataDescribe.FocusedState.Parent = this.txtDataDescribe;
            this.txtDataDescribe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDataDescribe.HoverState.Parent = this.txtDataDescribe;
            this.txtDataDescribe.Location = new System.Drawing.Point(68, 306);
            this.txtDataDescribe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataDescribe.Name = "txtDataDescribe";
            this.txtDataDescribe.PasswordChar = '\0';
            this.txtDataDescribe.PlaceholderText = "Nhập mô tả công việc";
            this.txtDataDescribe.SelectedText = "";
            this.txtDataDescribe.ShadowDecoration.Parent = this.txtDataDescribe;
            this.txtDataDescribe.Size = new System.Drawing.Size(625, 117);
            this.txtDataDescribe.TabIndex = 5;
            this.txtDataDescribe.TextChanged += new System.EventHandler(this.txtDataDescribe_TextChanged);
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(99, 299);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(38, 15);
            this.lblDescribe.TabIndex = 6;
            this.lblDescribe.Text = "Mô tả";
            // 
            // ucTxtWorker4
            // 
            this.ucTxtWorker4.BackColor = System.Drawing.Color.White;
            this.ucTxtWorker4.Location = new System.Drawing.Point(407, 212);
            this.ucTxtWorker4.Name = "ucTxtWorker4";
            this.ucTxtWorker4.Size = new System.Drawing.Size(286, 71);
            this.ucTxtWorker4.TabIndex = 2;
            this.ucTxtWorker4.Load += new System.EventHandler(this.ucTxtWorker4_Load);
            // 
            // ucTxtWorker3
            // 
            this.ucTxtWorker3.BackColor = System.Drawing.Color.White;
            this.ucTxtWorker3.Location = new System.Drawing.Point(68, 212);
            this.ucTxtWorker3.Name = "ucTxtWorker3";
            this.ucTxtWorker3.Size = new System.Drawing.Size(286, 71);
            this.ucTxtWorker3.TabIndex = 2;
            this.ucTxtWorker3.Load += new System.EventHandler(this.ucTxtWorker3_Load);
            // 
            // ucTxtWorker2
            // 
            this.ucTxtWorker2.BackColor = System.Drawing.Color.White;
            this.ucTxtWorker2.Location = new System.Drawing.Point(407, 120);
            this.ucTxtWorker2.Name = "ucTxtWorker2";
            this.ucTxtWorker2.Size = new System.Drawing.Size(286, 223);
            this.ucTxtWorker2.TabIndex = 2;
            this.ucTxtWorker2.Load += new System.EventHandler(this.ucTxtWorker2_Load);
            // 
            // ucTxtWorker1
            // 
            this.ucTxtWorker1.BackColor = System.Drawing.Color.White;
            this.ucTxtWorker1.Location = new System.Drawing.Point(68, 120);
            this.ucTxtWorker1.Name = "ucTxtWorker1";
            this.ucTxtWorker1.Size = new System.Drawing.Size(286, 223);
            this.ucTxtWorker1.TabIndex = 1;
            this.ucTxtWorker1.Load += new System.EventHandler(this.ucTxtWorker1_Load);
            // 
            // ucTxtWorker5
            // 
            this.ucTxtWorker5.BackColor = System.Drawing.Color.White;
            this.ucTxtWorker5.Location = new System.Drawing.Point(744, 360);
            this.ucTxtWorker5.Name = "ucTxtWorker5";
            this.ucTxtWorker5.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorker5.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(744, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(420, 269);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PanelComboWorkOfDay
            // 
            this.PanelComboWorkOfDay.BackColor = System.Drawing.Color.White;
            this.PanelComboWorkOfDay.Controls.Add(this.btnWorkOfDay);
            this.PanelComboWorkOfDay.Controls.Add(this.btn246);
            this.PanelComboWorkOfDay.Controls.Add(this.btn357);
            this.PanelComboWorkOfDay.Controls.Add(this.btnAll);
            this.PanelComboWorkOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboWorkOfDay.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboWorkOfDay.Location = new System.Drawing.Point(12, 56);
            this.PanelComboWorkOfDay.MaximumSize = new System.Drawing.Size(214, 226);
            this.PanelComboWorkOfDay.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboWorkOfDay.Name = "PanelComboWorkOfDay";
            this.PanelComboWorkOfDay.Size = new System.Drawing.Size(214, 58);
            this.PanelComboWorkOfDay.TabIndex = 9;
            // 
            // btnWorkOfDay
            // 
            this.btnWorkOfDay.FlatAppearance.BorderSize = 0;
            this.btnWorkOfDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkOfDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWorkOfDay.IconChar = FontAwesome.Sharp.IconChar.ChevronRight;
            this.btnWorkOfDay.IconColor = System.Drawing.Color.Navy;
            this.btnWorkOfDay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnWorkOfDay.IconSize = 25;
            this.btnWorkOfDay.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWorkOfDay.Location = new System.Drawing.Point(3, 3);
            this.btnWorkOfDay.Name = "btnWorkOfDay";
            this.btnWorkOfDay.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnWorkOfDay.Size = new System.Drawing.Size(211, 52);
            this.btnWorkOfDay.TabIndex = 0;
            this.btnWorkOfDay.Text = "Ngày làm việc";
            this.btnWorkOfDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkOfDay.UseVisualStyleBackColor = true;
            this.btnWorkOfDay.Click += new System.EventHandler(this.btnWorkOfDay_Click);
            // 
            // btn246
            // 
            this.btn246.FlatAppearance.BorderSize = 0;
            this.btn246.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn246.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn246.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn246.IconColor = System.Drawing.Color.Navy;
            this.btn246.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn246.IconSize = 25;
            this.btn246.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn246.Location = new System.Drawing.Point(3, 61);
            this.btn246.Name = "btn246";
            this.btn246.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn246.Size = new System.Drawing.Size(211, 52);
            this.btn246.TabIndex = 1;
            this.btn246.Text = "Thứ 2, 4, 6";
            this.btn246.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn246.UseVisualStyleBackColor = true;
            // 
            // btn357
            // 
            this.btn357.FlatAppearance.BorderSize = 0;
            this.btn357.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn357.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn357.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btn357.IconColor = System.Drawing.Color.Navy;
            this.btn357.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn357.IconSize = 25;
            this.btn357.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn357.Location = new System.Drawing.Point(3, 119);
            this.btn357.Name = "btn357";
            this.btn357.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btn357.Size = new System.Drawing.Size(211, 52);
            this.btn357.TabIndex = 2;
            this.btn357.Text = "Thứ 3,5,7";
            this.btn357.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn357.UseVisualStyleBackColor = true;
            // 
            // btnAll
            // 
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAll.IconChar = FontAwesome.Sharp.IconChar.Square;
            this.btnAll.IconColor = System.Drawing.Color.Navy;
            this.btnAll.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAll.IconSize = 25;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(3, 177);
            this.btnAll.Name = "btnAll";
            this.btnAll.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.btnAll.Size = new System.Drawing.Size(211, 52);
            this.btnAll.TabIndex = 2;
            this.btnAll.Text = "ALL";
            this.btnAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAll.UseVisualStyleBackColor = true;
            // 
            // RollBtnDayOfWork
            // 
            this.RollBtnDayOfWork.Interval = 1;
            this.RollBtnDayOfWork.Tick += new System.EventHandler(this.RollBtnDayOfWork_Tick);
            // 
            // FPostWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 508);
            this.Controls.Add(this.PanelComboWorkOfDay);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ucTxtWorker5);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.txtDataDescribe);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.ucTxtWorker4);
            this.Controls.Add(this.ucTxtWorker3);
            this.Controls.Add(this.ucTxtWorker2);
            this.Controls.Add(this.ucTxtWorker1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPostWork";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FPostWork";
            this.Load += new System.EventHandler(this.FPostWork_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.PanelComboWorkOfDay.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private UCTxtWorker ucTxtWorker1;
        private UCTxtWorker ucTxtWorker2;
        private UCTxtWorker ucTxtWorker3;
        private UCTxtWorker ucTxtWorker4;
        private System.Windows.Forms.Panel panelBottom;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblDescribe;
        private UCTxtWorker ucTxtWorker5;
        public Guna.UI2.WinForms.Guna2TextBox txtDataDescribe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.FlowLayoutPanel PanelComboWorkOfDay;
        private FontAwesome.Sharp.IconButton btnWorkOfDay;
        private FontAwesome.Sharp.IconButton btn246;
        private FontAwesome.Sharp.IconButton btn357;
        private FontAwesome.Sharp.IconButton btnAll;
        private System.Windows.Forms.Timer RollBtnDayOfWork;
    }
}