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
    public partial class Create_User : Form
    {
        SqlConnection Con;SqlCommand Cmd;
      
        public Create_User()
        {
            InitializeComponent();
        }

        private void Create_User_Load(object sender, EventArgs e)
        {
            string sqlcon = "server=ASUS;User id=sa;password=jyoti99;database=MicroProject";
            Con = new SqlConnection(sqlcon);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string Query = "insert into Users values(@P1,@P2,@P3,@P4,@P5,@P6)";
            Cmd = new SqlCommand(Query, Con);
            Cmd.CommandType = CommandType.Text;
            Cmd.Parameters.AddWithValue("@P1", txtUserName.Text);
            Cmd.Parameters.AddWithValue("@P2", txtPassword.Text);
            Cmd.Parameters.AddWithValue("P3", txtFirstName.Text);
            Cmd.Parameters.AddWithValue("P4", txtLastName.Text);
            Cmd.Parameters.AddWithValue("P5", txtHintAnswer.Text);
            Cmd.Parameters.AddWithValue("P6", txtHintAnswer.Text);
            Con.Open();
            int Rows=Cmd.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show(Rows + "Row(s) Inserted");


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach(Control C in this.Controls)
            {
                if (C is TextBox)
                    C.Text = "";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
