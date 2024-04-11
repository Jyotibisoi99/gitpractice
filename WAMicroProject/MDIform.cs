using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WAMicroProject
{
    public partial class MDIform : Form
    {
        Add_Item addI1;
        Edit_Item edit2;
        Delete_Item delete3;
        Create_User Nuser1;
        Delete_User Duser2;
        ChangePassword pass3;
        View_User Vuser4;

        public MDIform()
        {
            InitializeComponent();
        }

        private void smnuAddItem_Click_1(object sender, EventArgs e)
        {
            if (addI1 == null)
                addI1 = new Add_Item();
            addI1.MdiParent = this;
            addI1.Show();

        }

        private void smnuEditItem_Click_1(object sender, EventArgs e)
        {
            if (edit2 == null)
                edit2 = new Edit_Item();
            edit2.MdiParent = this;
            edit2.Show();

        }

        private void smnuDeleteItem_Click_1(object sender, EventArgs e)
        {
            if (delete3 == null)
                delete3 = new Delete_Item();
            delete3.MdiParent = this;
            delete3.Show();

        }

        private void smnuExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void smnuAddNewUser_Click(object sender, EventArgs e)
        {
            if (Nuser1 == null)
                Nuser1 = new Create_User();
            Nuser1.MdiParent = this;
            Nuser1.Show();

        }

        private void smnuDeleteUser_Click_1(object sender, EventArgs e)
        {
            if (Duser2 == null)
                Duser2 = new Delete_User();
            Duser2.MdiParent = this;
            Duser2.Show();

        }

        private void smnuChangePassword_Click_1(object sender, EventArgs e)
        {
            if (pass3 == null)
                pass3 = new ChangePassword();
            pass3.MdiParent = this;
            pass3.Show();


        }

        private void smnuViewUser_Click_1(object sender, EventArgs e)
        {
            if (Vuser4 == null)
                Vuser4 = new View_User();
            Vuser4.MdiParent = this;
            Vuser4.Show();

        }
    }
}
