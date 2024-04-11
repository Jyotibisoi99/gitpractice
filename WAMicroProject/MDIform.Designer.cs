
namespace WAMicroProject
{
    partial class MDIform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuEditItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuAddNewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuChangePassword = new System.Windows.Forms.ToolStripMenuItem();
            this.smnuViewUser = new System.Windows.Forms.ToolStripMenuItem();
            this.newBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemToolStripMenuItem,
            this.userToolStripMenuItem,
            this.billToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1108, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuAddItem,
            this.smnuEditItem,
            this.smnuDeleteItem,
            this.smnuExit});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smnuAddNewUser,
            this.smnuDeleteUser,
            this.smnuChangePassword,
            this.smnuViewUser});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.userToolStripMenuItem.Text = "User";
            // 
            // billToolStripMenuItem
            // 
            this.billToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newBillToolStripMenuItem,
            this.viewBillToolStripMenuItem});
            this.billToolStripMenuItem.Name = "billToolStripMenuItem";
            this.billToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.billToolStripMenuItem.Text = "Bill";
            // 
            // smnuAddItem
            // 
            this.smnuAddItem.Name = "smnuAddItem";
            this.smnuAddItem.Size = new System.Drawing.Size(224, 26);
            this.smnuAddItem.Text = "Add Item";
            this.smnuAddItem.Click += new System.EventHandler(this.smnuAddItem_Click_1);
            // 
            // smnuEditItem
            // 
            this.smnuEditItem.Name = "smnuEditItem";
            this.smnuEditItem.Size = new System.Drawing.Size(224, 26);
            this.smnuEditItem.Text = "Edit Item";
            this.smnuEditItem.Click += new System.EventHandler(this.smnuEditItem_Click_1);
            // 
            // smnuDeleteItem
            // 
            this.smnuDeleteItem.Name = "smnuDeleteItem";
            this.smnuDeleteItem.Size = new System.Drawing.Size(224, 26);
            this.smnuDeleteItem.Text = "Delete Item";
            this.smnuDeleteItem.Click += new System.EventHandler(this.smnuDeleteItem_Click_1);
            // 
            // smnuExit
            // 
            this.smnuExit.Name = "smnuExit";
            this.smnuExit.Size = new System.Drawing.Size(224, 26);
            this.smnuExit.Text = "E&xit";
            this.smnuExit.Click += new System.EventHandler(this.smnuExit_Click_1);
            // 
            // smnuAddNewUser
            // 
            this.smnuAddNewUser.Name = "smnuAddNewUser";
            this.smnuAddNewUser.Size = new System.Drawing.Size(224, 26);
            this.smnuAddNewUser.Text = "Add New User";
            this.smnuAddNewUser.Click += new System.EventHandler(this.smnuAddNewUser_Click);
            // 
            // smnuDeleteUser
            // 
            this.smnuDeleteUser.Name = "smnuDeleteUser";
            this.smnuDeleteUser.Size = new System.Drawing.Size(224, 26);
            this.smnuDeleteUser.Text = "Delete User";
            this.smnuDeleteUser.Click += new System.EventHandler(this.smnuDeleteUser_Click_1);
            // 
            // smnuChangePassword
            // 
            this.smnuChangePassword.Name = "smnuChangePassword";
            this.smnuChangePassword.Size = new System.Drawing.Size(224, 26);
            this.smnuChangePassword.Text = "Change Password";
            this.smnuChangePassword.Click += new System.EventHandler(this.smnuChangePassword_Click_1);
            // 
            // smnuViewUser
            // 
            this.smnuViewUser.Name = "smnuViewUser";
            this.smnuViewUser.Size = new System.Drawing.Size(224, 26);
            this.smnuViewUser.Text = "View User";
            this.smnuViewUser.Click += new System.EventHandler(this.smnuViewUser_Click_1);
            // 
            // newBillToolStripMenuItem
            // 
            this.newBillToolStripMenuItem.Name = "newBillToolStripMenuItem";
            this.newBillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newBillToolStripMenuItem.Text = "New Bill";
            // 
            // viewBillToolStripMenuItem
            // 
            this.viewBillToolStripMenuItem.Name = "viewBillToolStripMenuItem";
            this.viewBillToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewBillToolStripMenuItem.Text = "View Bill";
            // 
            // MDIform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WAMicroProject.Properties.Resources.micro1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1108, 842);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Impact", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MDIform";
            this.Text = "MDIform";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnuAddItem;
        private System.Windows.Forms.ToolStripMenuItem smnuEditItem;
        private System.Windows.Forms.ToolStripMenuItem smnuDeleteItem;
        private System.Windows.Forms.ToolStripMenuItem smnuExit;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smnuAddNewUser;
        private System.Windows.Forms.ToolStripMenuItem smnuDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem smnuChangePassword;
        private System.Windows.Forms.ToolStripMenuItem smnuViewUser;
        private System.Windows.Forms.ToolStripMenuItem billToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBillToolStripMenuItem;
    }
}



