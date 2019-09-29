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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            Load += UrunListeGuncelle;
        }

        public void UrunListeGuncelle()
        {
            lsvOrders.Items.Clear();

            var products = Singleton.Context.Products.ToList();

            foreach (var item in products)
            {
                string[] degerler = new string[6]
                {
                    item.ProductId.ToString(),
                    item.ProductName,
                    item.UnitPrice+" ₺",
                    item.RemainingStock.ToString(),
                    item.TotalInStock.ToString(),
                    item.Categories.CategoryName,
                  
                  
                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvOrders.Items.Add(viewItem);

            }
        }

        public void UrunListeGuncelle(Object sender,EventArgs e)
        {
            UrunListeGuncelle();
        }

        private void PctProductRefresh_Click(object sender, EventArgs e)
        {
            UrunListeGuncelle();
            MessageBox.Show("Ürün Listesi Başarıyla Güncellendi..");
        }
    

        private void PctProductAdd_Click(object sender, EventArgs e)
        {
            FormProductAdd frm = new FormProductAdd();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += UrunListeGuncelle;
            frm.Show();
        }

        private void PctProductDelete_Click(object sender, EventArgs e)
        {
            if (lsvOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Ürünü Seçiniz.!");
                return;
            }

            var item = lsvOrders.SelectedItems[0];
            Products product = (Products)item.Tag;
            Singleton.Context.Products.Remove(product);
            WinformHelpers.KontrolluKaydet();
            UrunListeGuncelle();
        }

        private void PctProductEdit_Click(object sender, EventArgs e)
        {
            if (lsvOrders.SelectedIndices.Count==0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğniz Ürünü Seçiniz.!");
                return;
            }

            var item = lsvOrders.SelectedItems[0];
            Products product =(Products)item.Tag;
            FormProductUpdate frm = new FormProductUpdate(product);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += UrunListeGuncelle;
            frm.Show();

        }

       
    }
}
