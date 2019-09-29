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
    public partial class FormBranchMyOrdes : Form
    {
        int _userId;
      
        public FormBranchMyOrdes(int userId)
        {
            InitializeComponent();
            _userId = userId;
           
            Load += SiparisListeGuncelle;
        }

        public void SiparisListeGuncelle()
        {
            lsvBranchOrders.Items.Clear();

            var orders = Singleton.Context.Orders.Where(o=>o.BranchId==_userId && o.OrderStatu=="Sipariş Alındı").ToList();

            foreach (var item in orders)
            {
                string[] degerler = new string[5]
                {
                  item.OrderId.ToString(),
                  item.Stocks.Products.ProductName,
                  item.Users.FullName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvBranchOrders.Items.Add(viewItem);

            }
        }

        public void SiparisListeGuncelle(object sender, EventArgs e)
        {
            SiparisListeGuncelle();
        }

        public void SiparisListeFiltrele()
        {
            lsvBranchOrders.Items.Clear();

            List<Orders> orders;
            if (string.IsNullOrWhiteSpace(txtPOrdersSearch.Text))
            {
                orders = Singleton.Context.Orders.Where(o => o.BranchId == _userId && o.OrderStatu == "Sipariş Alındı").ToList();
            }
            else
            {
                string[] kelimeler = lsvBranchOrders.Text.Trim().Split();
                orders = Singleton.Context.Orders.Where(o => o.BranchId == _userId && o.OrderStatu == "Sipariş Alındı")
                   .Where(u => u.Stocks.Products.ProductName.Contains(txtPOrdersSearch.Text)).ToList();
            }



         

            foreach (var item in orders)
            {
                string[] degerler = new string[5]
               {
                  item.OrderId.ToString(),
                  item.Stocks.Products.ProductName,
                  item.Users.FullName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

               };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvBranchOrders.Items.Add(viewItem);

            }
        }

        private void TxtPOrdersSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPOrdersSearch.Text.Length < 3)
            {
                return;
            }
            SiparisListeFiltrele();
        }

        private void PctOrdersReady_Click(object sender, EventArgs e)
        {
            if (lsvBranchOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz.!");
                return;
            }

            var item = lsvBranchOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;

            order.OrderStatu = "Sipariş Kargolanıyor";
            WinformHelpers.KontrolluKaydet();
            SiparisListeGuncelle();
        }

        private void PctOrdersCargo_Click(object sender, EventArgs e)
        {
            if (lsvBranchOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz.!");
                return;
            }

            var item = lsvBranchOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;

            order.OrderStatu = "Sipariş Kargoya Verildi";
            WinformHelpers.KontrolluKaydet();
            SiparisListeGuncelle();
        }

        private void PctOrdersCancel_Click(object sender, EventArgs e)
        {
            if (lsvBranchOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiniz.!");
                return;
            }

            var item = lsvBranchOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;

            order.OrderStatu = "Sipariş İptal Edildi";
            WinformHelpers.KontrolluKaydet();
            SiparisListeGuncelle();
        }
    }
}
