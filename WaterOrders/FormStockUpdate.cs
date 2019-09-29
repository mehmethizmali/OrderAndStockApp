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
    public partial class FormStockUpdate : Form
    {
        Stocks _stock;
        public FormStockUpdate(Stocks stock)
        {
            InitializeComponent();
            _stock = stock;
        }

        private void FormStockUpdate_Load(object sender, EventArgs e)
        {
            //Combo box verilerinin getirilmesi
            var users = Singleton.Context.Users.Where(u => u.AuthorityId == 2 && u.Status == true).ToList();
            cmbStockBranchNameUpd.DisplayMember = "UserName";
            cmbStockBranchNameUpd.ValueMember = "UserId";
            cmbStockBranchNameUpd.DataSource = users;
            cmbStockBranchNameUpd.SelectedIndex = -1;


            if (_stock.UserId != null) //Combo box kotnrolü yapılarak değeri ataması yapıldı
            {
                cmbStockBranchNameUpd.SelectedValue = _stock.UserId;
            }

            var product = Singleton.Context.Products.Where(p => p.RemainingStock > 0).ToList();
            cmbStockProductNameUpd.DisplayMember = "ProductName";
            cmbStockProductNameUpd.ValueMember = "ProductId";
            cmbStockProductNameUpd.DataSource = product;
            cmbStockProductNameUpd.SelectedIndex = -1;

            if (_stock.ProductId != null) //Combo box kotnrolü yapılarak değeri ataması yapıldı
            {
                cmbStockProductNameUpd.SelectedValue = _stock.ProductId;
            }

            txtStockProductCountUpd.Text = _stock.UnitInStock.ToString();
            txtStockProRemanningUpd.Text = _stock.RemainingStock.ToString();
            chckStockOrderStart.Checked = _stock.Discontinued;

        }

        private void BtnStockProductUpd_Click(object sender, EventArgs e)
        {

            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(cmbStockBranchNameUpd.Text))
            {
                notification += "Bayi Seçimi Zorunludur.!\n";
            }
            if (string.IsNullOrWhiteSpace(cmbStockProductNameUpd.Text))
            {
                notification += "Ürün Seçimi Zorunludur...!\n";
            }
            if (string.IsNullOrWhiteSpace(txtStockProductCountUpd.Text))
            {
                notification += "Ürün Adeti Girilmesi Zorunludur..!\n";
            }


            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;
            }
            #endregion

            _stock.Users = (Users)cmbStockBranchNameUpd.SelectedItem;
            _stock.Products = (Products)cmbStockProductNameUpd.SelectedItem;   
            _stock.Discontinued = chckStockOrderStart.Checked;

            WinformHelpers.KontrolluKaydet(this);




        }
    }
}
