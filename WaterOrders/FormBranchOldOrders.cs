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
    public partial class FormBranchOldOrders : Form
    {
        int _userId;

        public FormBranchOldOrders(int userId)
        {
            InitializeComponent();
            _userId = userId;
            Load += GecmişSiparisListeGuncelle;
        }

        public void GecmişSiparisListeGuncelle()
        {
            lsvBranchOldOrders.Items.Clear();

            var orders = Singleton.Context.Orders.Where(o => o.BranchId == _userId && o.OrderStatu != "Sipariş Alındı").ToList();

            foreach (var item in orders)
            {
                string[] degerler = new string[5]
                {
                  item.OrderId.ToString(),
                  item.Users.FullName,
                  item.Stocks.Products.ProductName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvBranchOldOrders.Items.Add(viewItem);

            }
        }

        public void GecmişSiparisListeGuncelle(object sender,EventArgs e)
        {
            GecmişSiparisListeGuncelle();
        }

        private void PctOrdersCargo_Click(object sender, EventArgs e)
        {
            if (lsvBranchOldOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz.!");
                return;
            }

            var item = lsvBranchOldOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;

            order.OrderStatu = "Sipariş Kargoya Verildi";
            WinformHelpers.KontrolluKaydet();
            GecmişSiparisListeGuncelle();
        }

        private void PctOrdersCancel_Click(object sender, EventArgs e)
        {
            if (lsvBranchOldOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz.!");
                return;
            }

            var item = lsvBranchOldOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;

            order.OrderStatu = "Sipariş İptal Edildi";
            WinformHelpers.KontrolluKaydet();
            GecmişSiparisListeGuncelle();
        }
    }
}
