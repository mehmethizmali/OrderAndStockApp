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
    public partial class FormCustNewOrder : Form
    {
        int _userId;
        public FormCustNewOrder(int userId)
        {
            InitializeComponent();
            Load += UrunStokListele;
            _userId = userId;
        }

        public void UrunStokListele()
        {
            lsvNewOrder.Items.Clear();

            int productQue = 1;

            var stock = Singleton.Context.Stocks.ToList();

            foreach (var item in stock)
            {
                string[] degerler = new string[5]
                {
                    productQue.ToString(),
                    item.Products.ProductName,
                    item.Users.UserName,
                    item.RemainingStock.ToString(),
                    item.Products.UnitPrice+" ₺",
                  


                };

               productQue++;

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvNewOrder.Items.Add(viewItem);

            }
        }


        public void UrunStokListele(Object sender,EventArgs e)
        {
            UrunStokListele();
        }

   

      
        private void BtnNewOrders_Click(object sender, EventArgs e)
        {
            if (lsvNewOrder.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Ürün Seçiminizi Yapınız");
                return;
            }
            var item = lsvNewOrder.SelectedItems[0];
            Stocks stock = (Stocks)item.Tag;  

            FormCustCompleteOrder frm = new FormCustCompleteOrder(stock, _userId);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += UrunStokListele;
            frm.Show();
        }
    }
}
