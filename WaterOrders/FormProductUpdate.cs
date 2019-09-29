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
    public partial class FormProductUpdate : Form
    {
        Products _product;
        public FormProductUpdate(Products products)
        {
            InitializeComponent();
            _product = products;
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            //Combo box verilerinin getirilmesi
            var kategoriler = Singleton.Context.Categories.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = kategoriler;
            cmbProductCategory.SelectedIndex = -1;


            //Diğer değerleri getirme

            txtProductName.Text = _product.ProductName;
            txtProductPrice.Text = _product.UnitPrice.ToString();
            txtProductTotalStock.Text = _product.TotalInStock.ToString();
           

            if (_product.CategoryId != null) //Combo box kotnrolü yapılarak değeri ataması yapıldı
            {
                cmbProductCategory.SelectedValue = _product.CategoryId;
            }
        }

        private void BtnProductUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                notification += "Ürün Adı Girilmesi Zorunludur..!\n";
            }
            if (string.IsNullOrWhiteSpace(txtProductPrice.Text))
            {
                notification += "Ürün Fiyatı Girilmesi Zorunludur..!\n";
            }
            if (string.IsNullOrWhiteSpace(txtProductTotalStock.Text))
            {
                notification += "Ürün Stoğu Girilmesi Zorunludur..!\n";
            }
            if (cmbProductCategory.SelectedItem == null)
            {
                notification += "Ürün Kategorisi Seçilmesi Zorunludur..!\n";
            }

           

            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;
            }
            #endregion
            _product.ProductName = txtProductName.Text;
            _product.UnitPrice = int.Parse(txtProductPrice.Text);
            _product.TotalInStock =int.Parse(txtProductTotalStock.Text);
            _product.Categories = (Categories)cmbProductCategory.SelectedItem;
          
            WinformHelpers.KontrolluKaydet(this);

        }
    }
}
