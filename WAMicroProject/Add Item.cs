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
    public partial class Add_Item : Form
    {
        SqlConnection Con;SqlDataAdapter Da;
        DataSet Ds;SqlCommandBuilder Bldr;
        DataRow Rec;
        public Add_Item()
        {
            InitializeComponent();
        }

        private void Add_Item_Load(object sender, EventArgs e)
        {
            string Sqlcon = "server=ASUS;user id=sa;password=jyoti99;database=MicroProject";
            Con = new SqlConnection(Sqlcon);
            Da = new SqlDataAdapter("select * from Items", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Item");
            Da.FillSchema(Ds, SchemaType.Source, "Item");
            Bldr = new SqlCommandBuilder(Da);
            DGVItem.DataSource = Ds.Tables[0];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Rec = Ds.Tables[0].NewRow();
            Rec[0] = txtItem.Text;
            Rec[1] = txtPrice.Text;
            Ds.Tables[0].Rows.Add(Rec);
            MessageBox.Show("Record added to Dataset table");

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
            // Application.Exit();
            this.Close();
        }

      //To enter digits only in txtprice textbox.
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter Digits Only");
            }
        }

        private void txtItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Enter Letters Only");
            }
        }
    }
}
