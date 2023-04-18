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
    public partial class Login : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
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
            if (txtPassword.Text != string.Empty || txtEmail.Text != string.Empty)
            {
                ;
                cmd = new SqlCommand("select * from LoginTable where username='" + txtEmail.Text + "' and password='" + txtPassword.Text + "'", cn);
                cmd.Connection = cn;
                using (SqlDataReader dr = cmd.ExecuteReader())
                    if (dr.Read())
                    {

                        dr.Close();
                        this.Hide();
                        Homepage home = new Homepage();
                        home.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\exact203\Desktop\Prototype_2_Working\Prototype2\SignupDatabase.mdf;Integrated Security=True");
            cn.Open();
        }
    }
}
