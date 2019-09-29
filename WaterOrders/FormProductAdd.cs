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
    public partial class FormProductAdd : Form
    {
        public FormProductAdd()
        {
            InitializeComponent();
        }

        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            var kategoriler = Singleton.Context.Categories.ToList();
            cmbProductCategory.DisplayMember = "CategoryName";
            cmbProductCategory.ValueMember = "CategoryId";
            cmbProductCategory.DataSource = kategoriler;
            cmbProductCategory.SelectedIndex = -1;
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
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
            if (string.IsNullOrWhiteSpace(txtUProductTotalStock.Text))
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

            Products product = new Products()
            {
                ProductName = txtProductName.Text,
                UnitPrice = int.Parse(txtProductPrice.Text),
                TotalInStock = short.Parse(txtUProductTotalStock.Text),
                RemainingStock= short.Parse(txtUProductTotalStock.Text),
                Categories = (Categories)cmbProductCategory.SelectedItem,
               
            };

           

            //Ürünü veri tabanına kayıt ediyoruz
            Singleton.Context.Products.Add(product);

            //Kotrollu ekleme yapıyoruz
            WinformHelpers.KontrolluKaydet(this);

            

        }
    }
}
