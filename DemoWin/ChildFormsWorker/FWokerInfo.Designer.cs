namespace DemoWin.ChildFormsWorker
{
    partial class FWokerInfo
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
            this.picWorkerCard = new FontAwesome.Sharp.IconPictureBox();
            this.panelRight = new System.Windows.Forms.Panel();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btnUpdateInfo = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucTxtWorkerPass = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerAccount = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerCCCD = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerAddress = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerSex = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerEmail = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerDate = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerPhone = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerName = new DemoWin.UCTxtWorker();
            this.ucTxtWorkerID = new DemoWin.UCTxtWorker();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerCard)).BeginInit();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // picWorkerCard
            // 
            this.picWorkerCard.BackColor = System.Drawing.Color.White;
            this.picWorkerCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.picWorkerCard.IconChar = FontAwesome.Sharp.IconChar.ClipboardUser;
            this.picWorkerCard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.picWorkerCard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.picWorkerCard.IconSize = 150;
            this.picWorkerCard.Location = new System.Drawing.Point(32, 129);
            this.picWorkerCard.Name = "picWorkerCard";
            this.picWorkerCard.Size = new System.Drawing.Size(150, 150);
            this.picWorkerCard.TabIndex = 0;
            this.picWorkerCard.TabStop = false;
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelRight.Controls.Add(this.iconButton4);
            this.panelRight.Controls.Add(this.btnUpdateInfo);
            this.panelRight.Controls.Add(this.iconButton2);
            this.panelRight.Controls.Add(this.iconButton1);
            this.panelRight.Controls.Add(this.btnHome);
            this.panelRight.Location = new System.Drawing.Point(958, 36);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(222, 575);
            this.panelRight.TabIndex = 2;
            // 
            // iconButton4
            // 
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 32;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(29, 262);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(190, 60);
            this.iconButton4.TabIndex = 17;
            this.iconButton4.Text = "Số dư";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInfo
            // 
            this.btnUpdateInfo.FlatAppearance.BorderSize = 0;
            this.btnUpdateInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateInfo.ForeColor = System.Drawing.Color.White;
            this.btnUpdateInfo.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.btnUpdateInfo.IconColor = System.Drawing.Color.White;
            this.btnUpdateInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpdateInfo.IconSize = 32;
            this.btnUpdateInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInfo.Location = new System.Drawing.Point(29, 196);
            this.btnUpdateInfo.Name = "btnUpdateInfo";
            this.btnUpdateInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnUpdateInfo.Size = new System.Drawing.Size(190, 60);
            this.btnUpdateInfo.TabIndex = 16;
            this.btnUpdateInfo.Text = "Cập nhật thông tin";
            this.btnUpdateInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateInfo.UseVisualStyleBackColor = true;
            this.btnUpdateInfo.Click += new System.EventHandler(this.btnUpdateInfo_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 32;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(29, 130);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton2.Size = new System.Drawing.Size(190, 60);
            this.iconButton2.TabIndex = 15;
            this.iconButton2.Text = "Đổi mật khẩu";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Comments;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(29, 66);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(190, 60);
            this.iconButton1.TabIndex = 14;
            this.iconButton1.Text = "Nhắn tin với Admin";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.EnvelopeCircleCheck;
            this.btnHome.IconColor = System.Drawing.Color.White;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 32;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(29, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(190, 60);
            this.btnHome.TabIndex = 13;
            this.btnHome.Text = "Hộp thư";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(976, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(8, 575);
            this.panel1.TabIndex = 0;
            // 
            // ucTxtWorkerPass
            // 
            this.ucTxtWorkerPass.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerPass.Location = new System.Drawing.Point(567, 71);
            this.ucTxtWorkerPass.Name = "ucTxtWorkerPass";
            this.ucTxtWorkerPass.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerPass.TabIndex = 3;
            // 
            // ucTxtWorkerAccount
            // 
            this.ucTxtWorkerAccount.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerAccount.Location = new System.Drawing.Point(567, 166);
            this.ucTxtWorkerAccount.Name = "ucTxtWorkerAccount";
            this.ucTxtWorkerAccount.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerAccount.TabIndex = 3;
            // 
            // ucTxtWorkerCCCD
            // 
            this.ucTxtWorkerCCCD.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerCCCD.Location = new System.Drawing.Point(567, 275);
            this.ucTxtWorkerCCCD.Name = "ucTxtWorkerCCCD";
            this.ucTxtWorkerCCCD.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerCCCD.TabIndex = 3;
            // 
            // ucTxtWorkerAddress
            // 
            this.ucTxtWorkerAddress.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerAddress.Location = new System.Drawing.Point(567, 387);
            this.ucTxtWorkerAddress.Name = "ucTxtWorkerAddress";
            this.ucTxtWorkerAddress.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerAddress.TabIndex = 3;
            // 
            // ucTxtWorkerSex
            // 
            this.ucTxtWorkerSex.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerSex.Location = new System.Drawing.Point(567, 508);
            this.ucTxtWorkerSex.Name = "ucTxtWorkerSex";
            this.ucTxtWorkerSex.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerSex.TabIndex = 3;
            // 
            // ucTxtWorkerEmail
            // 
            this.ucTxtWorkerEmail.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerEmail.Location = new System.Drawing.Point(238, 508);
            this.ucTxtWorkerEmail.Name = "ucTxtWorkerEmail";
            this.ucTxtWorkerEmail.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerEmail.TabIndex = 3;
            // 
            // ucTxtWorkerDate
            // 
            this.ucTxtWorkerDate.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerDate.Location = new System.Drawing.Point(238, 387);
            this.ucTxtWorkerDate.Name = "ucTxtWorkerDate";
            this.ucTxtWorkerDate.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerDate.TabIndex = 3;
            // 
            // ucTxtWorkerPhone
            // 
            this.ucTxtWorkerPhone.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerPhone.Location = new System.Drawing.Point(238, 275);
            this.ucTxtWorkerPhone.Name = "ucTxtWorkerPhone";
            this.ucTxtWorkerPhone.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerPhone.TabIndex = 3;
            // 
            // ucTxtWorkerName
            // 
            this.ucTxtWorkerName.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerName.Location = new System.Drawing.Point(238, 166);
            this.ucTxtWorkerName.Name = "ucTxtWorkerName";
            this.ucTxtWorkerName.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerName.TabIndex = 3;
            // 
            // ucTxtWorkerID
            // 
            this.ucTxtWorkerID.BackColor = System.Drawing.Color.White;
            this.ucTxtWorkerID.Location = new System.Drawing.Point(238, 71);
            this.ucTxtWorkerID.Name = "ucTxtWorkerID";
            this.ucTxtWorkerID.Size = new System.Drawing.Size(286, 63);
            this.ucTxtWorkerID.TabIndex = 3;
            // 
            // FWokerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1179, 670);
            this.Controls.Add(this.ucTxtWorkerPass);
            this.Controls.Add(this.ucTxtWorkerAccount);
            this.Controls.Add(this.ucTxtWorkerCCCD);
            this.Controls.Add(this.ucTxtWorkerAddress);
            this.Controls.Add(this.ucTxtWorkerSex);
            this.Controls.Add(this.ucTxtWorkerEmail);
            this.Controls.Add(this.ucTxtWorkerDate);
            this.Controls.Add(this.ucTxtWorkerPhone);
            this.Controls.Add(this.ucTxtWorkerName);
            this.Controls.Add(this.ucTxtWorkerID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.picWorkerCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FWokerInfo";
            this.Text = "FWokerInfo";
            this.Load += new System.EventHandler(this.FWokerInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerCard)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox picWorkerCard;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnHome;
        private FontAwesome.Sharp.IconButton btnUpdateInfo;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private UCTxtWorker ucTxtWorkerID;
        private UCTxtWorker ucTxtWorkerName;
        private UCTxtWorker ucTxtWorkerPhone;
        private UCTxtWorker ucTxtWorkerDate;
        private UCTxtWorker ucTxtWorkerEmail;
        private UCTxtWorker ucTxtWorkerSex;
        private UCTxtWorker ucTxtWorkerAddress;
        private UCTxtWorker ucTxtWorkerCCCD;
        private UCTxtWorker ucTxtWorkerAccount;
        private UCTxtWorker ucTxtWorkerPass;
    }
}