namespace DemoWin
{
    partial class UCMark
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
            this.panelContain = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.panelContain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContain
            // 
            this.panelContain.BorderColor = System.Drawing.Color.LightGray;
            this.panelContain.BorderRadius = 6;
            this.panelContain.BorderThickness = 2;
            this.panelContain.Controls.Add(this.lblID);
            this.panelContain.Controls.Add(this.lblEmail);
            this.panelContain.Controls.Add(this.lblName);
            this.panelContain.Location = new System.Drawing.Point(16, 14);
            this.panelContain.Name = "panelContain";
            this.panelContain.Size = new System.Drawing.Size(331, 122);
            this.panelContain.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(25, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(31, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Tên";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(25, 15);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "ID";
            this.lblID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 85);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // UCMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelContain);
            this.Name = "UCMark";
            this.Size = new System.Drawing.Size(364, 153);
            this.panelContain.ResumeLayout(false);
            this.panelContain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel panelContain;
        public System.Windows.Forms.Label lblID;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblEmail;
    }
}
