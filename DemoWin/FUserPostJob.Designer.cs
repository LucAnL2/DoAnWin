namespace DemoWin
{
    partial class FUserPostJob
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
            this.panelTop = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ucTxtSalary = new DemoWin.UCTxtWorker();
            this.ucTxtAddress = new DemoWin.UCTxtWorker();
            this.ucTxtRequire = new DemoWin.UCTxtWorker();
            this.ucTxtWorkDay = new DemoWin.UCTxtWorker();
            this.ucTxtWorkHour = new DemoWin.UCTxtWorker();
            this.lblDescribe = new System.Windows.Forms.Label();
            this.txtDataDescribe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnPostJob = new Guna.UI2.WinForms.Guna2Button();
            this.ucTxtPosition = new DemoWin.UCTxtWorker();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
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
            this.panelTop.Size = new System.Drawing.Size(1240, 37);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.Location = new System.Drawing.Point(24, 4);
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
            this.label1.Location = new System.Drawing.Point(62, 6);
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
            this.btnMinimize.Location = new System.Drawing.Point(1153, 2);
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
            this.btnClose.Location = new System.Drawing.Point(1202, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ucTxtSalary
            // 
            this.ucTxtSalary.BackColor = System.Drawing.Color.White;
            this.ucTxtSalary.Location = new System.Drawing.Point(48, 89);
            this.ucTxtSalary.Name = "ucTxtSalary";
            this.ucTxtSalary.Size = new System.Drawing.Size(440, 63);
            this.ucTxtSalary.TabIndex = 2;
            // 
            // ucTxtAddress
            // 
            this.ucTxtAddress.BackColor = System.Drawing.Color.White;
            this.ucTxtAddress.Location = new System.Drawing.Point(48, 190);
            this.ucTxtAddress.Name = "ucTxtAddress";
            this.ucTxtAddress.Size = new System.Drawing.Size(440, 63);
            this.ucTxtAddress.TabIndex = 2;
            // 
            // ucTxtRequire
            // 
            this.ucTxtRequire.BackColor = System.Drawing.Color.White;
            this.ucTxtRequire.Location = new System.Drawing.Point(48, 292);
            this.ucTxtRequire.Name = "ucTxtRequire";
            this.ucTxtRequire.Size = new System.Drawing.Size(440, 63);
            this.ucTxtRequire.TabIndex = 2;
            // 
            // ucTxtWorkDay
            // 
            this.ucTxtWorkDay.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkDay.Location = new System.Drawing.Point(48, 401);
            this.ucTxtWorkDay.Name = "ucTxtWorkDay";
            this.ucTxtWorkDay.Size = new System.Drawing.Size(440, 63);
            this.ucTxtWorkDay.TabIndex = 2;
            // 
            // ucTxtWorkHour
            // 
            this.ucTxtWorkHour.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkHour.Location = new System.Drawing.Point(550, 89);
            this.ucTxtWorkHour.Name = "ucTxtWorkHour";
            this.ucTxtWorkHour.Size = new System.Drawing.Size(440, 63);
            this.ucTxtWorkHour.TabIndex = 2;
            // 
            // lblDescribe
            // 
            this.lblDescribe.AutoSize = true;
            this.lblDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescribe.Location = new System.Drawing.Point(581, 340);
            this.lblDescribe.Name = "lblDescribe";
            this.lblDescribe.Size = new System.Drawing.Size(38, 15);
            this.lblDescribe.TabIndex = 8;
            this.lblDescribe.Text = "Mô tả";
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
            this.txtDataDescribe.Location = new System.Drawing.Point(550, 347);
            this.txtDataDescribe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataDescribe.Name = "txtDataDescribe";
            this.txtDataDescribe.PasswordChar = '\0';
            this.txtDataDescribe.PlaceholderText = "Nhập mô tả công việc";
            this.txtDataDescribe.SelectedText = "";
            this.txtDataDescribe.ShadowDecoration.Parent = this.txtDataDescribe;
            this.txtDataDescribe.Size = new System.Drawing.Size(625, 117);
            this.txtDataDescribe.TabIndex = 7;
            // 
            // btnPostJob
            // 
            this.btnPostJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnPostJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnPostJob.BorderColor = System.Drawing.Color.White;
            this.btnPostJob.BorderRadius = 8;
            this.btnPostJob.BorderThickness = 2;
            this.btnPostJob.CheckedState.Parent = this.btnPostJob;
            this.btnPostJob.CustomImages.Parent = this.btnPostJob;
            this.btnPostJob.FillColor = System.Drawing.Color.Transparent;
            this.btnPostJob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPostJob.ForeColor = System.Drawing.Color.White;
            this.btnPostJob.HoverState.Parent = this.btnPostJob;
            this.btnPostJob.Location = new System.Drawing.Point(1082, 129);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.ShadowDecoration.Parent = this.btnPostJob;
            this.btnPostJob.Size = new System.Drawing.Size(104, 43);
            this.btnPostJob.TabIndex = 86;
            this.btnPostJob.Text = "Đăng";
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // ucTxtPosition
            // 
            this.ucTxtPosition.BackColor = System.Drawing.Color.White;
            this.ucTxtPosition.Location = new System.Drawing.Point(550, 190);
            this.ucTxtPosition.Name = "ucTxtPosition";
            this.ucTxtPosition.Size = new System.Drawing.Size(440, 63);
            this.ucTxtPosition.TabIndex = 2;
            // 
            // FUserPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1240, 517);
            this.Controls.Add(this.btnPostJob);
            this.Controls.Add(this.lblDescribe);
            this.Controls.Add(this.txtDataDescribe);
            this.Controls.Add(this.ucTxtPosition);
            this.Controls.Add(this.ucTxtWorkHour);
            this.Controls.Add(this.ucTxtWorkDay);
            this.Controls.Add(this.ucTxtRequire);
            this.Controls.Add(this.ucTxtAddress);
            this.Controls.Add(this.ucTxtSalary);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FUserPostJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FUserPostJob";
            this.Load += new System.EventHandler(this.FUserPostJob_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private UCTxtWorker ucTxtSalary;
        private UCTxtWorker ucTxtAddress;
        private UCTxtWorker ucTxtRequire;
        private UCTxtWorker ucTxtWorkDay;
        private UCTxtWorker ucTxtWorkHour;
        private System.Windows.Forms.Label lblDescribe;
        public Guna.UI2.WinForms.Guna2TextBox txtDataDescribe;
        private Guna.UI2.WinForms.Guna2Button btnPostJob;
        private UCTxtWorker ucTxtPosition;
    }
}