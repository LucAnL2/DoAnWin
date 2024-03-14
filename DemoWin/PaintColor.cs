using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin
{
    public class PaintColor
    {
        public Button currentButton;
        public Random random = new Random();
        public int tempIndex;
        public Form activeForm;
        public Color SelectThemeColors()
        {
            int index = random.Next(ThemeColors.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColors.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColors.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        public void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    Color color = SelectThemeColors();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void ActivateButtonMore(object btnSender, Panel panelMenu, Panel panelTitleBar, Panel panelLogo, Button btnCloseChildForm)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton(panelMenu);
                    Color color = SelectThemeColors();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    ThemeColors.PrimaryColor = color;
                    ThemeColors.SecondaryColor = ThemeColors.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        public void DisableButton(Panel panelMenu)
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        public void OpenChildForm(Form childForm, object btnSender, Panel panelDesktop, Label lblTitle, Panel panelMenu, Panel panelTitleBar, Panel panelLogo, Button btnCloseChildForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButtonMore(btnSender, panelMenu, panelTitleBar, panelLogo, btnCloseChildForm);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        public void CloseChildForm(object sender, EventArgs e, Panel panelMenu, Label lblTitle, Panel panelTitleBar, Panel panelLogo, Button btnCloseChildForm) 
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset(panelMenu, lblTitle, panelTitleBar, panelLogo, btnCloseChildForm);
        }
        private void Reset(Panel panelMenu, Label lblTitle, Panel panelTitleBar, Panel panelLogo, Button btnCloseChildForm)
        {
            DisableButton(panelMenu);
            lblTitle.Text = "WELCOME";
            panelTitleBar.BackColor = Color.FromArgb(51, 51, 76);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        public void BtnExit(object sender,Panel panelMenu)
        {
            DisableButton(panelMenu);
            Color color = SelectThemeColors();
            currentButton = (Button)sender;
            currentButton.BackColor = color;
            currentButton.ForeColor = Color.White;
            currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }
    }
}
