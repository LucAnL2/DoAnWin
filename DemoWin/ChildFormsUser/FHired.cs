﻿using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoWin.Forms
{
    public partial class FHired : Form
    {
        string[] dataAddress = { "Hà Nội", "Huế", "Tp Hồ Chí Minh", "Nơi khác" };
        string[] dataHireCost = { "Dưới 8tr", "8-10tr", "10-20tr", "Trên 20tr" };
        string[] dataRate = { "1 Sao", "2 Sao", "3 Sao", "4 Sao", "5 Sao" };
        public static Form activeForm;
        public FHired()
        {
            InitializeComponent();
            cbbAddress.DataSource = dataAddress;
            cbbHirecost.DataSource = dataHireCost;
            cbbRate.DataSource = dataRate;
        }

        private void FHired_Load(object sender, EventArgs e)
        {
            LoadTheme();
            for (int i = 0; i < 3; i++)
            {
                UCWorkerInfo uc = new UCWorkerInfo();
                uc.Margin = new Padding(25);
                uc.BackColor = ThemeColors.PrimaryColor;
                uc.btnDetail.Click += btnOpenDetail_Click;
                flowPanelContain.Controls.Add(uc);
            }
        }
        private void LoadTheme()
        {
            panelTop.BackColor = ThemeColors.SecondaryColor;
            panelTaskBar.BackColor = ThemeColors.PrimaryColor;
            cbbAddress.FillColor = ThemeColors.SecondaryColor;
            cbbHirecost.FillColor = ThemeColors.SecondaryColor;
            cbbRate.FillColor = ThemeColors.SecondaryColor;
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
            panelContain.Controls.Add(childForm);
            panelContain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnOpenDetail_Click(object sender, EventArgs e)
        {
            ////FWorkerDetail user = new FWorkerDetail();
            ////user.btnBack.Click += btnCloseDetail_Click;
            ////OpenChildForm(user, sender);
        }
        private void btnCloseDetail_Click(object sender, EventArgs e)
        {
            //FHired_Load(sender, e);

            flowPanelContain.Visible = true;
            panelContain.Controls.Add(flowPanelContain);
            panelContain.Tag = flowPanelContain;
            flowPanelContain.BringToFront();
        }
    }
}
