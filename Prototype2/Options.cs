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
    public partial class Options : Form
    {
        public Options()
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
            this.Close();
            Support frm2 = new Support();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
