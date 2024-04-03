namespace DemoWin.Booking
{
    partial class UCDay
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
            this.btnDay = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnDay
            // 
            this.btnDay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDay.ForeColor = System.Drawing.Color.White;
            this.btnDay.Location = new System.Drawing.Point(0, 0);
            this.btnDay.Name = "btnDay";
            this.btnDay.Size = new System.Drawing.Size(90, 45);
            this.btnDay.TabIndex = 0;
            this.btnDay.Text = "guna2Button1";
            this.btnDay.Click += new System.EventHandler(this.btnDay_Click);
            // 
            // UCDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDay);
            this.Name = "UCDay";
            this.Size = new System.Drawing.Size(90, 49);
            this.ResumeLayout(false);

        }

        #endregion

        public Guna.UI2.WinForms.Guna2Button btnDay;
    }
}
