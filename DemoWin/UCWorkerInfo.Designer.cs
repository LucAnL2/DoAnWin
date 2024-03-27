namespace DemoWin
{
    partial class UCWorkerInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDetail = new Guna.UI2.WinForms.Guna2Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picBackGround = new System.Windows.Forms.PictureBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.Transparent;
            this.btnDetail.BorderColor = System.Drawing.Color.White;
            this.btnDetail.BorderRadius = 4;
            this.btnDetail.BorderThickness = 2;
            this.btnDetail.CheckedState.Parent = this.btnDetail;
            this.btnDetail.CustomImages.Parent = this.btnDetail;
            this.btnDetail.FillColor = System.Drawing.Color.Transparent;
            this.btnDetail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.White;
            this.btnDetail.HoverState.Parent = this.btnDetail;
            this.btnDetail.Image = global::DemoWin.Properties.Resources.file_circle_info;
            this.btnDetail.Location = new System.Drawing.Point(262, 381);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.ShadowDecoration.Parent = this.btnDetail;
            this.btnDetail.Size = new System.Drawing.Size(115, 39);
            this.btnDetail.TabIndex = 1;
            this.btnDetail.Text = "Chi tiết";
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(30, 312);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(103, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "09xxxxxx06";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRate.ForeColor = System.Drawing.Color.White;
            this.lblRate.Location = new System.Drawing.Point(30, 340);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(57, 20);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "5 Sao";
            this.lblRate.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(30, 284);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(119, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Huỳnh Văn C";
            // 
            // picBackGround
            // 
            this.picBackGround.Location = new System.Drawing.Point(9, 6);
            this.picBackGround.Name = "picBackGround";
            this.picBackGround.Size = new System.Drawing.Size(385, 250);
            this.picBackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBackGround.TabIndex = 2;
            this.picBackGround.TabStop = false;
            this.picBackGround.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(258, 284);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(119, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Huỳnh Văn C";
            // 
            // UCWorkerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.picBackGround);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblName);
            this.Name = "UCWorkerInfo";
            this.Size = new System.Drawing.Size(402, 439);
            this.Load += new System.EventHandler(this.USWorkerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnDetail;
        public System.Windows.Forms.Label lblPhone;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblRate;
        public System.Windows.Forms.PictureBox picBackGround;
    }
}
