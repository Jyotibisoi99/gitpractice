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
    public partial class Delete_Item : Form
    {
        SqlConnection Con; SqlDataAdapter Da;DataRow Rec;
        DataSet Ds; SqlCommandBuilder Bldr;
        
        public Delete_Item()
        {
            InitializeComponent();
        }

        private void Delete_Item_Load(object sender, EventArgs e)
        {
            string Sqlcon = "server=ASUS;user id=sa;password=jyoti99;database=MicroProject";
            Con = new SqlConnection(Sqlcon);
            Da = new SqlDataAdapter("select * from Items", Con);
            Ds = new DataSet();
            Da.Fill(Ds, "Item");
            Da.FillSchema(Ds, SchemaType.Source, "Item");
            Bldr = new SqlCommandBuilder(Da);
            DGVItem.DataSource = Ds.Tables[0];
            txtItem.Enabled = false;

        }
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Enter Digits Only");
            }

        }
        private void DGVItem_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string valueintext1 = DGVItem.SelectedRows[0].Cells[0].Value.ToString();
            string valueintext2 = DGVItem.SelectedRows[0].Cells[1].Value.ToString();
            txtItem.Text = valueintext1;
            txtPrice.Text = valueintext2;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            /* to know which row is selected in dataset*/
            Rec = Ds.Tables[0].Select("Items='" + txtItem.Text + "'")[0];
            Rec.Delete();
            MessageBox.Show("Record is deleted from Dataset table");

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
