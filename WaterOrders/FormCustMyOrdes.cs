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
    public partial class FormCustMyOrdes : Form
    {
        int _userId;
        public FormCustMyOrdes(int userId)
        {
            InitializeComponent();
            _userId = userId;
            Load += SiparisListeGuncelle;
        }

        public void SiparisListeGuncelle()
        {
            lsvOrders.Items.Clear();

            var orders = Singleton.Context.Orders.Where(o=>o.UserId==_userId).ToList();

            foreach (var item in orders)
            {
                string[] degerler = new string[4]
                {
                  item.OrderId.ToString(),
                  item.Stocks.Products.ProductName,
                  item.OrderDate.ToString(),
                  item.OrderStatu.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvOrders.Items.Add(viewItem);

            }
        }

        public void SiparisListeGuncelle(object sender,EventArgs e)
        {
            SiparisListeGuncelle();
        }

        private void BtnOrderDetail_Click(object sender, EventArgs e)
        {
            if (lsvOrders.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Detayını Görmek İstediğiniz Siparişi Seçiniz.!");
                return;
            }

            var item = lsvOrders.SelectedItems[0];
            Orders order = (Orders)item.Tag;
            FormCustOrderDetail frm = new FormCustOrderDetail(order);


            foreach (Control control in frm.Controls)
            {
                if (control is TextBox)
                {
                    control.Enabled = false;
                }

                
            }

            frm.MdiParent = this.MdiParent;
            frm.FormClosed += SiparisListeGuncelle;
            frm.Show();
        }
    }
}
