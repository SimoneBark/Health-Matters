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
    public partial class HealthTracking : Form
    {
        public HealthTracking()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Close();
            Homepage frm1 = new Homepage();
            frm1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            
            Support frm1 = new Support();
            frm1.Show();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var xText = txtCalculator.Text;
            var x = 0;
            if (!int.TryParse(xText, out x))
            {
                MessageBox.Show("Error, invlaid input");
                return;
            }
            
            var y = 0.04;
            var answer = x * y;
            txtCalculator.Text = answer.ToString();
            
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            var xText = txtLitres.Text;
            var x = 0;
            if (!int.TryParse(xText, out x))
            {
                MessageBox.Show("Error, invlaid input");
                return;
            }
            if (x < 3)
                txtLitres.Text = "Low";
            if (x == 3)
                txtLitres.Text = "Perfect";
            if (x > 3)
                txtLitres.Text = "High";
            else
                return;


        }
    }
}
