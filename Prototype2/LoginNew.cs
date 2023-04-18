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
    public partial class LoginNew : Form
    {
        public LoginNew()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            String username = "Admin";
            String password = "Admin";

            if ((txtEmail.Text == username) && (txtPassword.Text == password))
            {
                MessageBox.Show("Successful");
                this.Hide();
                Homepage frm2 = new Homepage();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Errro: Incorrect Credentials");
            }

        }
    }
}
