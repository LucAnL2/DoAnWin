namespace DemoWin
{
    partial class FManager
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnLogout = new FontAwesome.Sharp.IconButton();
            this.btnFeedBack = new FontAwesome.Sharp.IconButton();
            this.btnRevenue = new FontAwesome.Sharp.IconButton();
            this.btnPending = new FontAwesome.Sharp.IconButton();
            this.btnAllUsers = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnLogout);
            this.panelMenu.Controls.Add(this.btnFeedBack);
            this.panelMenu.Controls.Add(this.btnRevenue);
            this.panelMenu.Controls.Add(this.btnPending);
            this.panelMenu.Controls.Add(this.btnAllUsers);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 700);
            this.panelMenu.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.btnLogout.IconColor = System.Drawing.Color.White;
            this.btnLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLogout.IconSize = 32;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 314);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLogout.Size = new System.Drawing.Size(220, 60);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnFeedBack
            // 
            this.btnFeedBack.FlatAppearance.BorderSize = 0;
            this.btnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFeedBack.ForeColor = System.Drawing.Color.White;
            this.btnFeedBack.IconChar = FontAwesome.Sharp.IconChar.CommentDots;
            this.btnFeedBack.IconColor = System.Drawing.Color.White;
            this.btnFeedBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFeedBack.IconSize = 32;
            this.btnFeedBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedBack.Location = new System.Drawing.Point(0, 254);
            this.btnFeedBack.Name = "btnFeedBack";
            this.btnFeedBack.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFeedBack.Size = new System.Drawing.Size(220, 60);
            this.btnFeedBack.TabIndex = 4;
            this.btnFeedBack.Text = "Phản hồi";
            this.btnFeedBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFeedBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFeedBack.UseVisualStyleBackColor = true;
            this.btnFeedBack.Click += new System.EventHandler(this.btnFeedBack_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.btnRevenue.IconColor = System.Drawing.Color.White;
            this.btnRevenue.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRevenue.IconSize = 32;
            this.btnRevenue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.Location = new System.Drawing.Point(0, 194);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRevenue.Size = new System.Drawing.Size(220, 60);
            this.btnRevenue.TabIndex = 3;
            this.btnRevenue.Text = "Thống kê doanh thu";
            this.btnRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRevenue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRevenue.UseVisualStyleBackColor = true;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnPending
            // 
            this.btnPending.FlatAppearance.BorderSize = 0;
            this.btnPending.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPending.ForeColor = System.Drawing.Color.White;
            this.btnPending.IconChar = FontAwesome.Sharp.IconChar.HourglassHalf;
            this.btnPending.IconColor = System.Drawing.Color.White;
            this.btnPending.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPending.IconSize = 32;
            this.btnPending.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPending.Location = new System.Drawing.Point(0, 134);
            this.btnPending.Name = "btnPending";
            this.btnPending.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPending.Size = new System.Drawing.Size(220, 60);
            this.btnPending.TabIndex = 2;
            this.btnPending.Text = "Chờ phê duyệt";
            this.btnPending.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPending.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPending.UseVisualStyleBackColor = true;
            this.btnPending.Click += new System.EventHandler(this.btnPending_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.FlatAppearance.BorderSize = 0;
            this.btnAllUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAllUsers.ForeColor = System.Drawing.Color.White;
            this.btnAllUsers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnAllUsers.IconColor = System.Drawing.Color.White;
            this.btnAllUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAllUsers.IconSize = 32;
            this.btnAllUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllUsers.Location = new System.Drawing.Point(0, 74);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAllUsers.Size = new System.Drawing.Size(220, 60);
            this.btnAllUsers.TabIndex = 1;
            this.btnAllUsers.Text = "Tất cả người dùng";
            this.btnAllUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllUsers.UseVisualStyleBackColor = true;
            this.btnAllUsers.Click += new System.EventHandler(this.btnAllUsers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.iconButton1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 69);
            this.panelLogo.TabIndex = 1;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnClose);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1180, 60);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Image = global::DemoWin.Properties.Resources.minus_small;
            this.btnMinimize.Location = new System.Drawing.Point(1051, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 35);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Image = global::DemoWin.Properties.Resources.square_small;
            this.btnMaximize.Location = new System.Drawing.Point(1092, 12);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 35);
            this.btnMaximize.TabIndex = 6;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = global::DemoWin.Properties.Resources.cross_small;
            this.btnClose.Location = new System.Drawing.Point(1133, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(78, 20);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(0, 16);
            this.lblTitleChildForm.TabIndex = 1;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconCurrentChildForm.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(40, 14);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 60);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1180, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 69);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1180, 631);
            this.panelDesktop.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Navicon;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 8);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(40, 40);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // FManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FManager";
            this.Load += new System.EventHandler(this.FManager_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnAllUsers;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnPending;
        private FontAwesome.Sharp.IconButton btnLogout;
        private FontAwesome.Sharp.IconButton btnFeedBack;
        private FontAwesome.Sharp.IconButton btnRevenue;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnClose;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}