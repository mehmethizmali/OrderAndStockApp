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
    public partial class FormCustNewOrders2 : Form
    {
        int _userId;
        
        public FormCustNewOrders2(int userId)
        {
            InitializeComponent();
            _userId = userId;
          
        }

        private void CmbCustProductName_TextUpdate(object sender, EventArgs e)
        {
            cmbCustProductName.DroppedDown = false;
            cmbCustProductName.DataSource = null;




            string girilenDegeriSaklayan = cmbCustProductName.Text;

            if (cmbCustProductName.Text.Length < 2)
            {
                cmbCustProductName.Select(cmbCustProductName.Text.Length, 0);
                return;
            }


            //Singleton yaklaşımı ile bir class yardımı ile context oluştrup Northwind Entitity Kullanıyoruz
            List<Products> products = Singleton.Context.Products.Where(c => c.ProductName.Contains(cmbCustProductName.Text)).ToList(); //Lamda Operatoru kullanımı NOT :Müşteri Şirket...
            cmbCustProductName.DisplayMember = "ProductName";
            cmbCustProductName.ValueMember = "ProductId";
            cmbCustProductName.DataSource = products;

            cmbCustProductName.SelectedIndex = -1;
            cmbCustProductName.Text = girilenDegeriSaklayan;
            cmbCustProductName.Select(cmbCustProductName.Text.Length, 0); //Karakterin sonununa git belirtilen kadar elaman seç.Substring gibi

            cmbCustProductName.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void CmbCustBranchName_TextUpdate(object sender, EventArgs e)
        {
            cmbCustBranchName.DroppedDown = false;
            cmbCustBranchName.DataSource = null;

            string girilenDegeriSaklayan = cmbCustBranchName.Text;

            if (cmbCustBranchName.Text.Length < 2)
            {
                cmbCustBranchName.Select(cmbCustBranchName.Text.Length, 0);
                return;
            }


            //Singleton yaklaşımı ile bir class yardımı ile context oluştrup Northwind Entitity Kullanıyoruz
            List<Users> user = Singleton.Context.Users.Where(u => u.UserName.Contains(cmbCustBranchName.Text)).Where(u=>u.AuthorityId==2).ToList(); //Lamda Operatoru kullanımı NOT :Müşteri Şirket...
            cmbCustBranchName.DisplayMember = "UserName";
            cmbCustBranchName.ValueMember = "UserId";
            cmbCustBranchName.DataSource = user;

            cmbCustBranchName.SelectedIndex = -1;
            cmbCustBranchName.Text = girilenDegeriSaklayan;
            cmbCustBranchName.Select(cmbCustBranchName.Text.Length, 0); //Karakterin sonununa git belirtilen kadar elaman seç.Substring gibi

            cmbCustBranchName.DroppedDown = true;
            Cursor.Current = Cursors.Default;
        }

        private void CmbCustProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudCustProductCount.Value = 0;
            txtCustTotalPrice.Text = "0";
        }

        private void NudCustProductCount_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCustProductName.SelectedItem == null)
            {
                return;
            }

            var urun = (Products)cmbCustProductName.SelectedItem;
            decimal toplam = (urun.UnitPrice) * nudCustProductCount.Value;
            txtCustTotalPrice.Text = toplam+ " ₺";
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (cmbCustProductName.SelectedItem == null || cmbCustBranchName.SelectedItem==null)
            {
                return;
            }

            var product = (Products)cmbCustProductName.SelectedItem;

            //Listeye Ürün EKleme
            string[] satisKalemi = new string[5]
            {
                product.ProductId.ToString(),
                product.ProductName,
                product.UnitPrice.ToString(),
                nudCustProductCount.Value.ToString(),
                txtCustTotalPrice.Text

            };



            //Yeni Sipariş Detayları
            OrderDetail newOrder = new OrderDetail()
            {
               
                Quantity = (short)nudCustProductCount.Value,
                UnitPrice = product.UnitPrice,
                UserId = _userId
                
                
            };

            ListViewItem item = new ListViewItem(satisKalemi);
            item.Tag = newOrder; //Listview Tag'ına sipariş detaylarını atıyoruz
            lsvNewOrder.Items.Add(item);

            cmbCustProductName.SelectedIndex = -1;
            cmbCustBranchName.SelectedIndex = -1;
        }

        private void PctOrderAllDelete_Click(object sender, EventArgs e)
        {
            lsvNewOrder.Items.Clear();
        }

        private void PctpctOrderDelete_Click(object sender, EventArgs e)
        {
            if (lsvNewOrder.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütten Sepetten Çıkarmak İstediğiniz Ürünü Seçiniz.!");
                return;
            }
            lsvNewOrder.Items.Remove(lsvNewOrder.SelectedItems[0]);
        }

        private void BtnNewOrders_Click(object sender, EventArgs e)
        {
            Orders order = new Orders()
            {
                //Navigation Property Kullanıyoruz.Navigation Property'ler Entity ile beraber geldi. Navigation Property ilgli tablolara sırayla işlem yapmamızı sağlar
                UserId = _userId,
                OrderStatu = "test",
                OrderDate = DateTime.Now,
                ToOrder="test",
                UnitPrice=10



            };
            //Orders tablosuna insert işlemi 

            //Forach order details
            foreach (ListViewItem item in lsvNewOrder.Items)
            {
                order.OrderDetail.Add((OrderDetail)item.Tag);
            }

            //Veri Tabanına eklemeye başlıyoruz
            Singleton.Context.Orders.Add(order);
            WinformHelpers.KontrolluKaydet();
        }
    }
}
