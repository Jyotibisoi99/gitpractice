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
    public partial class View_User : Form
    {
        SqlConnection Con; SqlDataAdapter Da;
        DataSet Ds; SqlCommandBuilder Bldr;

        public View_User()
        {
            InitializeComponent();
        }

        private void View_User_Load(object sender, EventArgs e)
        {
            string Sqlcon = "server=ASUS;user id=sa;password=jyoti99;database=MicroProject";
            Con = new SqlConnection(Sqlcon);
            Da = new SqlDataAdapter("select * from Users", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Item");
            Da.FillSchema(Ds, SchemaType.Source, "Item");
            Bldr = new SqlCommandBuilder(Da);
            DGVUsers.DataSource = Ds.Tables[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
