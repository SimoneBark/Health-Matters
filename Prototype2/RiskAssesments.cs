using System;
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
    public partial class RiskAssesments : Form
    {
        public RiskAssesments()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage frm2 = new Homepage();
            frm2.Show();
        }

        private void btnHealthTracking_Click(object sender, EventArgs e)
        {
            this.Close();
            HealthTracking frm2 = new HealthTracking();
            frm2.Show();
        }

        private void btnSupport_Click(object sender, EventArgs e)
        {
            this.Close();
            Support frm2 = new Support();
            frm2.Show();
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            this.Close();
            Options frm2 = new Options();
            frm2.Show();
        }
    }
}
