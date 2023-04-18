using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;

namespace Prototype2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Signup frm1 = new Signup();
            frm1.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {         
            
            string constring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\Task 2\\SignupAndLogin1.accdb;Integrated Security=True";
            using (OleDbConnection connection = new OleDbConnection(constring))
            {
                connection.Open();
                string email = txtEmail.Text;
                string pass = txtPassword.Text;
            
          
                string query = @"SELECT COUNT(*) FROM User WHERE (Email_reg, Password_reg) VALUES (@email, @pass)";
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email_reg", email);
                    command.Parameters.AddWithValue("@Password_reg", pass);

                    MessageBox.Show("Login Successful");

                    Homepage frm2 = new Homepage();
                    frm2.Show();
                    this.Hide();
                }

                
            }

        }
   

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            PassReset frm1 = new PassReset();
            frm1.Show();
        }
    }
}
