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
    public partial class FormAdminMenu : Form
    {
        int _userId;
        public FormAdminMenu(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

       
       

        private void BtnCustomer_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormCustomers>();
        }

    



        private void BtnOrder_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormAllOrders>();
        }
        private void BtnBranh_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormBranches>();
        }

        private void BtnStock_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormStocks>();
        }

        private void BtnProduct_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormProduct>();
        }

        private void BtnBranch_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormBranches>();
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            this.MdiChilAc<FormCategory>();
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            //FormBranchMenu frm = new FormBranchMenu();

            //frm.Show();

            this.MdiChilAc<FormLogin>();
        }

        private void BtnAdminExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.Show();
        }

        private void FormAdminMenu_Load(object sender, EventArgs e)
        {
            lblAdminWellcome.Text = "Hoşgeldiniz,\n" + Singleton.Context.Users.Where(u => u.UserId == _userId).First().FullName;
        }
    }
}
