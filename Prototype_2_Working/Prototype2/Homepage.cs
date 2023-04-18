﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prototype2
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            this.Close();
            Support frm1 = new Support();
            frm1.Show();
        }

        private void btnForecast_Click(object sender, EventArgs e)
        {
            this.Close();
            Forecast frm2 = new Forecast();
            frm2.Show();
        }

        private void btnHealthTracking_Click(object sender, EventArgs e)
        {
            this.Close();
            HealthTracking frm7 = new HealthTracking();
            frm7.Show();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            this.Close();
            btnLogout frm3 = new btnLogout();
            frm3.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Close();
            Options frm6 = new Options();
            frm6.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

        }
    }
}
