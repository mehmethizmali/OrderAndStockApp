using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterOrders
{
    public partial class FormLogin : Form
    {

        public FormLogin() 
        {
            InitializeComponent();
           
        }

        private void LblNewUser_Click(object sender, EventArgs e)
        {
            
            FormUsersAdd frm = new FormUsersAdd(3);
            this.Hide();
            frm.Show();

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = WinformHelpers.CreateMD5(txtPassword.Text);

            //User Login Linq
            var user = Singleton.Context.Users.Where(u => u.UserName == userName && u.Password == password && u.Status==true ).FirstOrDefault();
            if (user == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış.!");
                txtUserName.Text = "";
                txtPassword.Text = "";
                return;
            }

            int authority = user.AuthorityId;
            int userId = user.UserId;

            if (authority == 1)
            {
                FormAdminMenu frmAdmin = new FormAdminMenu(userId);
                frmAdmin.Show();
                this.Hide();
            }

            if (authority == 2)
            {
                FormBranchMenu frmBranch = new FormBranchMenu(userId);
                frmBranch.Show();
                this.Hide();
            }

            if (authority == 3)
            {
                FormCustomerMenu frmCust = new FormCustomerMenu(userId);
                frmCust.Show();
                this.Hide();
            }
        }

   
    }
}
