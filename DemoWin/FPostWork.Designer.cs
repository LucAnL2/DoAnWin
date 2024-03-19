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
            this.PanelComboHireCost = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHireCost = new FontAwesome.Sharp.IconButton();
            this.btn8Tr = new FontAwesome.Sharp.IconButton();
            this.btn810Tr = new FontAwesome.Sharp.IconButton();
            this.btn1020Tr = new FontAwesome.Sharp.IconButton();
            this.btn20Tr = new FontAwesome.Sharp.IconButton();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.PanelComboHireCost.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(92, 20);
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
            this.guna2Button1.Location = new System.Drawing.Point(319, 13);
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
            // PanelComboHireCost
            // 
            this.PanelComboHireCost.BackColor = System.Drawing.Color.White;
            this.PanelComboHireCost.Controls.Add(this.btnHireCost);
            this.PanelComboHireCost.Controls.Add(this.btn8Tr);
            this.PanelComboHireCost.Controls.Add(this.btn810Tr);
            this.PanelComboHireCost.Controls.Add(this.btn1020Tr);
            this.PanelComboHireCost.Controls.Add(this.btn20Tr);
            this.PanelComboHireCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelComboHireCost.ForeColor = System.Drawing.Color.Navy;
            this.PanelComboHireCost.Location = new System.Drawing.Point(68, 197);
            this.PanelComboHireCost.MaximumSize = new System.Drawing.Size(214, 285);
            this.PanelComboHireCost.MinimumSize = new System.Drawing.Size(214, 58);
            this.PanelComboHireCost.Name = "PanelComboHireCost";
            this.PanelComboHireCost.Size = new System.Drawing.Size(214, 285);
            this.PanelComboHireCost.TabIndex = 9;
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
            this.btnHireCost.Text = "Ngày làm việc";
            this.btnHireCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHireCost.UseVisualStyleBackColor = true;
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
            this.btn8Tr.Text = "Thứ 2, 4, 6";
            this.btn8Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn8Tr.UseVisualStyleBackColor = true;
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
            this.btn810Tr.Text = "Thứ 3,5,7";
            this.btn810Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn810Tr.UseVisualStyleBackColor = true;
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
            this.btn1020Tr.Text = "ALL";
            this.btn1020Tr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn1020Tr.UseVisualStyleBackColor = true;
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
            // 
            // FPostWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1167, 508);
            this.Controls.Add(this.PanelComboHireCost);
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
            this.PanelComboHireCost.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel PanelComboHireCost;
        private FontAwesome.Sharp.IconButton btnHireCost;
        private FontAwesome.Sharp.IconButton btn8Tr;
        private FontAwesome.Sharp.IconButton btn810Tr;
        private FontAwesome.Sharp.IconButton btn1020Tr;
        private FontAwesome.Sharp.IconButton btn20Tr;
    }
}