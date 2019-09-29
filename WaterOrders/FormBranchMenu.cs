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
    public partial class FormBranchMenu : Form
    {
        int _userId;
        public FormBranchMenu(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

      

      

        private void FormBranchMenu_Load(object sender, EventArgs e)
        {
            pnlBranchNewOrders.Visible = false;
            pnlBranchUserSettings.Visible = false;

            lblBranchWellcome.Text = "Hoşgeldiniz,\n"+ Singleton.Context.Users.Where(u => u.UserId == _userId).First().FullName;
        }

        private void BtnBranchOrders_Show(object sender, EventArgs e)
        {
            pnlBranchNewOrders.Visible = true;
            pnlBranchUserSettings.Visible = false;
        }

        private void BtnBranchProduct_Hide(object sender, EventArgs e)
        {
            pnlBranchNewOrders.Visible = false;
            pnlBranchUserSettings.Visible = false;
        }

        private void BtnBranchSetting_Show(object sender, EventArgs e)
        {

            pnlBranchUserSettings.Visible = true;
        }

        private void BtnBranchSettings_Click(object sender, EventArgs e)
        {
           
        }

        private void BtnBranchNewOrder_Click(object sender, EventArgs e)
        {
            pnlBranchNewOrders.Visible = false;
            pnlBranchUserSettings.Visible = false;


            FormBranchMyOrdes frm = new FormBranchMyOrdes(_userId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnBranchOldOrder_Click(object sender, EventArgs e)
        {
            pnlBranchNewOrders.Visible = false;
            pnlBranchUserSettings.Visible = false;


            FormBranchOldOrders frm = new FormBranchOldOrders(_userId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnBranhExit_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin frm = new FormLogin();
            frm.Show();

        }
    }
}
