using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WAMicroProject
{
    public partial class Login_form : Form
    {
        SqlConnection Con;SqlCommand Cmd;SqlDataReader DR;

        public Login_form()
        {
            InitializeComponent();
        }
        private void Login_form_Load(object sender, EventArgs e)
        {
            string sqlconstring = "server=ASUS;user id=sa;Password=jyoti99;database=MicroProject";
            Con = new SqlConnection(sqlconstring);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Query = "select * from Users where Username=@P1 and Password=@P2";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", txtUsername.Text);
            Cmd.Parameters.AddWithValue("@P2", txtPassword.Text);
            Con.Open();
            DR = Cmd.ExecuteReader();
            if (DR.Read())
            // MessageBox.Show("Login successful");
            {
                this.Hide();
                MDIform mdi = new MDIform();
                mdi.Show();
            }



            else
                MessageBox.Show("Invalid credential");
            Con.Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                txtPassword.UseSystemPasswordChar = false;
            else
                txtPassword.UseSystemPasswordChar = true;
        }
    }
}
