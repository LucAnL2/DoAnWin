using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Forms
{
    public partial class FHome : Form
    {
        public static Form activeForm;
        public FHome()
        {
            InitializeComponent();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColors.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColors.SecondaryColor;
                }
            }
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelCotain.Controls.Add(childForm);
            panelCotain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void FHome_Load(object sender, EventArgs e)
        {
            LoadTheme();
            panelCotain.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMechanic_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnMechanic.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();
        }

        private void btnPainter_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnPainter.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();
        }

        private void btnElectrician_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnElectrician.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();
        }
        
        private void btnCarvers_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnCarvers.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();

        }

        private void btnCarWashman_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnCarWashman.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            FHire user = new FHire(btnOther.Text);
            OpenChildForm(user, sender);
            panelCotain.Show();
        }
    }
}
