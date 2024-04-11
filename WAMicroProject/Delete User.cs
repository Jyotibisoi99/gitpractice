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
    public partial class Delete_User : Form
    {
        SqlConnection Con; SqlDataAdapter Da;
        DataSet Ds; SqlCommandBuilder Bldr;
        
        public Delete_User()
        {
            InitializeComponent();
        }

        private void Delete_User_Load(object sender, EventArgs e)
        {
            //To show the records on DataGridView
            string Sqlcon = "server=ASUS;user id=sa;password=jyoti99;database=MicroProject";
            Con = new SqlConnection(Sqlcon);
            Da = new SqlDataAdapter("select * from Users", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Item");
            Da.FillSchema(Ds, SchemaType.Source, "Item");
            Bldr = new SqlCommandBuilder(Da);
            DGVUser.DataSource = Ds.Tables[0];
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            if(this.DGVUser.SelectedRows.Count>0)
            {
                DGVUser.Rows.RemoveAt(this.DGVUser.SelectedRows[0].Index);
            }
            MessageBox.Show("Record is Deleted from Dataset");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Ds.HasChanges())
            {
                int Rows = Da.Update(Ds.Tables[0]);
                MessageBox.Show(Rows + "Record(s) updated to Database");
            }
            else
                MessageBox.Show("No modification in Dataset Table");
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();
        }
    }
   
}
