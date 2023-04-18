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

    public partial class Signup : Form
    {

        public Signup()
        {
            InitializeComponent();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\Task 2\\Prototype_2_Working\\Prototype2\\SignupDatabase.mdf;Integrated Security=True");
            cn.Open();
        }
        private void btnSignUp_Click(object sender, EventArgs e)

        {
            string constring = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=M:\\Task 2\\SignupAndLogin.accdb;Integrated Security=True";
            using (OleDbConnection con = new OleDbConnection(constring))
            {

                string email = txtEmail.Text;
                string pass = txtPassword.Text;

                con.Open();
                string query = @"INSERT INTO User (Email_registration,Password_registration) VALUES (@email,@pass)";
                using (OleDbCommand command = new OleDbCommand(query, con))
                {
                    command.Parameters.AddWithValue("@Email_registration", email);
                    command.Parameters.AddWithValue("@Password_registration", pass);
                }
                MessageBox.Show("Login Successful");
            }
        }
    }
}



