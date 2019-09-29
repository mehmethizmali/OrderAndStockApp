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
    public partial class FormStocks : Form
    {
        public FormStocks()
        {
            InitializeComponent();
            Load += StokListeGuncelle;
        }

        public void StokListeGuncelle()
        {
            lsvStocks.Items.Clear();

            var stocks = Singleton.Context.Stocks.ToList();
                     

             foreach (var item in stocks)
             {
                 string[] degerler = new string[7]
                 {
                     item.StockId.ToString(),
                     item.Users.UserName,
                     item.Products.ProductName,
                     item.Products.UnitPrice+" ₺",
                     item.UnitInStock.ToString(),
                     item.RemainingStock.ToString(),
                     item.Discontinued.ToString(),


                 };

         

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvStocks.Items.Add(viewItem);

            }
        }

        public void StokListeGuncelle(Object sender,EventArgs e)
        {
            StokListeGuncelle();
        }

        private void PctStockAdd_Click(object sender, EventArgs e)
        {
            FormStocksAdd frm = new FormStocksAdd();
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += StokListeGuncelle;
            frm.Show();
        }

        private void PctStockEdit_Click(object sender, EventArgs e)
        {

            if (lsvStocks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğniz Stoğu Seçiniz.!");
                return;
            }

            var item = lsvStocks.SelectedItems[0];
            Stocks stock = (Stocks)item.Tag;
            FormStockUpdate frm = new FormStockUpdate(stock);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += StokListeGuncelle;
            frm.Show();
        }

        private void PctStockDelete_Click(object sender, EventArgs e)
        {
            if (lsvStocks.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğiniz Stoğu Seçiniz.!");
                return;
            }

            var item = lsvStocks.SelectedItems[0];
            Stocks stock = (Stocks)item.Tag;
            Singleton.Context.Stocks.Remove(stock);
            WinformHelpers.KontrolluKaydet();
            StokListeGuncelle();
        }

        private void PctStockRefresh_Click(object sender, EventArgs e)
        {
            StokListeGuncelle();
            MessageBox.Show("Bayi Stok Listesi Güncellendi..");
        }
    }
}
