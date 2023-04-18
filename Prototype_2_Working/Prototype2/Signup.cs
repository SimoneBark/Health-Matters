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

namespace Prototype2
{

    public partial class Signup : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
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
            if (txtPassword.Text != string.Empty || txtEmail.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from LoginTable where username='" + txtEmail.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Username Already exist please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into LoginTable values(@username,@password)", cn);
                    cmd.Parameters.AddWithValue("username", txtEmail);
                    cmd.Parameters.AddWithValue("password", txtPassword.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Your Account is created . Please login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        

    }
}
