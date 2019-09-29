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
    public partial class FormAllOrders : Form
    {
        public FormAllOrders()
        {
            InitializeComponent();
            Load += TumSiparisListeGuncelle;
        }

        public void TumSiparisListeGuncelle()
        {
            lsvAllOrders.Items.Clear();

            var orders = Singleton.Context.Orders.ToList();

            foreach (var item in orders)
            {
                string[] degerler = new string[6]
                {
                  item.OrderId.ToString(),
                  item.ToOrder,
                  item.Users.FullName,
                  item.Stocks.Products.ProductName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvAllOrders.Items.Add(viewItem);

            }
        }

        public void TumSiparisListeFiltrele()
        {
            lsvAllOrders.Items.Clear();
          
            List<Orders> orders;
            if (string.IsNullOrWhiteSpace(txtPOrdersSearch.Text))
            {
               orders = Singleton.Context.Orders.ToList();
            }
            else
            {
                string[] kelimeler = txtPOrdersSearch.Text.Trim().Split();
                orders = Singleton.Context.Orders.Where(p => p.Stocks.Products.ProductName.Contains(txtPOrdersSearch.Text)).ToList(); //Link sorgusudur


            }

           

            foreach (var item in orders)
            {
                string[] degerler = new string[6]
                {
                  item.OrderId.ToString(),
                  item.ToOrder,
                  item.Users.FullName,
                  item.Stocks.Products.ProductName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvAllOrders.Items.Add(viewItem);

            }
        }

        private void TxtPOrdersSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPOrdersSearch.Text.Length < 3)
            {
                return;
            }

            TumSiparisListeFiltrele();

        }

        public void TumSiparisListeGuncelle(object sebder,EventArgs e)
        {
            TumSiparisListeGuncelle();
        }

       
    }
}
