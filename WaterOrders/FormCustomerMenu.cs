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
    public partial class FormCustomerMenu : Form
    {
        int _userId;
        public FormCustomerMenu(int userId)
        {
            InitializeComponent();
            _userId = userId;
        }

        private void FormCustomerMenu_Load(object sender, EventArgs e)
        {
            pnlCustNewOrders.Visible = false;
            pnlCustUserSettings.Visible = false;

            lblCustWellcome.Text = "Hoşgeldiniz,\n" + Singleton.Context.Users.Where(u => u.UserId == _userId).First().FullName;

            


        }

        private void BtnCustomerOrders_Show(object sender, EventArgs e)
        {
            pnlCustNewOrders.Visible = true;
            pnlCustUserSettings.Visible = false;
        }

        private void BtnCustomer_Hide(object sender, EventArgs e)
        {
            pnlCustNewOrders.Visible = false;
            pnlCustUserSettings.Visible = false;
        }

        private void BtnCustomerSetting_Show(object sender, EventArgs e)
        {

            pnlCustUserSettings.Visible = true;
        }

       

        private void BtnNewCustOrder_Click(object sender, EventArgs e)
        {
           
            pnlCustNewOrders.Visible = false;
            pnlCustUserSettings.Visible = false;

            FormCustNewOrder frm = new FormCustNewOrder(_userId);
            frm.MdiParent = this;
            frm.Show();

        }

        private void BtnCustMyOrders_Click(object sender, EventArgs e)
        {
            pnlCustNewOrders.Visible = false;
            pnlCustUserSettings.Visible = false;

            FormCustMyOrdes frm = new FormCustMyOrdes(_userId);
            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnCustProducts_Click(object sender, EventArgs e)
        {
            pnlCustNewOrders.Visible = false;
            pnlCustUserSettings.Visible = false;

            FormCustNewOrder frm = new FormCustNewOrder(_userId);
            foreach (Control control in frm.Controls)
            {
                if (control is GroupBox)
                {
                    control.Text = "Ürünler";
                }

            }
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
