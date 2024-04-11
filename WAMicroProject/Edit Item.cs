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
    public partial class Edit_Item : Form
    {
        SqlConnection Con; SqlDataAdapter Da;
        DataSet Ds; SqlCommandBuilder Bldr;DataRow Rec;
       

        public Edit_Item()
        {
            InitializeComponent();
        }

        private void Edit_Item_Load(object sender, EventArgs e)
        {
            string sqlconstring = "server=ASUS;user Id=sa ;Password=jyoti99;database=MicroProject";
            Con = new SqlConnection(sqlconstring);
            Da = new SqlDataAdapter("select * from Items", Con);
            Ds = new DataSet();
            Da.Fill(Ds,"Item");
            Da.FillSchema(Ds, SchemaType.Source, "Item");
            Bldr = new SqlCommandBuilder(Da);
            DGVItems.DataSource = Ds.Tables[0];
            txtItem.Enabled = false;

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
                MessageBox.Show("Enter Digits Only");
            }
            
        }

       
        private void DGVItems_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*Edit_Item Item1 = (Edit_Item)Application.OpenForms[0];
            int row = e.RowIndex;
            Item1.txtItem.Text = Convert.ToString(DGVItems[0, row].Value);
            Item1.txtPrice.Text=Convert.ToString(DGVItems[1,row].Value);*/


            string valueintext1 = DGVItems.SelectedRows[0].Cells[0].Value.ToString();
            string valueintext2 = DGVItems.SelectedRows[0].Cells[1].Value.ToString();
            txtItem.Text = valueintext1;
            txtPrice.Text = valueintext2;
            
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            Rec = Ds.Tables[0].Select("Items='" + txtItem.Text + "'")[0];
            Rec[1] = txtPrice.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            this.Close();

        }
    }
}
