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
    public partial class FormStocksAdd : Form
    {
        public FormStocksAdd()
        {
            InitializeComponent();
        }

      

        private void FormStocksAdd_Load(object sender, EventArgs e)
        {
            var users = Singleton.Context.Users.Where(u=>u.AuthorityId==2 && u.Status==true).ToList();
            cmbStockBranchName.DisplayMember = "UserName";
            cmbStockBranchName.ValueMember = "UserId";
            cmbStockBranchName.DataSource = users;
            cmbStockBranchName.SelectedIndex = -1;


            var product = Singleton.Context.Products.Where(p=>p.RemainingStock>0).ToList();
            cmbStockProductName.DisplayMember = "ProductName";
            cmbStockProductName.ValueMember = "ProductId";
            cmbStockProductName.DataSource = product;
            cmbStockProductName.SelectedIndex = -1;
        }

        private void BtnStockProductAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(cmbStockBranchName.Text))
            {
                notification += "Bayi Seçimi Zorunludur.!\n";
            }
            if (string.IsNullOrWhiteSpace(cmbStockProductName.Text))
            {
                notification += "Ürün Seçimi Zorunludur...!\n";
            }
            if (string.IsNullOrWhiteSpace(txtStockProductCount.Text))
            {
                notification += "Ürün Adeti Girilmesi Zorunludur..!\n";
            }
         

            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;
            }
            #endregion

            string count = txtStockProductCount.Text;

            Stocks stock = new Stocks()
            {
                Users = (Users)cmbStockBranchName.SelectedItem,
                Products = (Products)cmbStockProductName.SelectedItem,
                UnitInStock = short.Parse(count),
                RemainingStock= short.Parse(count),
                Discontinued =chckStockOrderStart.Checked

            };


            //Ürünü veri tabanına kayıt ediyoruz
            Singleton.Context.Stocks.Add(stock);

            //Kotrollu ekleme yapıyoruz
            WinformHelpers.KontrolluKaydet(this);


        }
    }
}
