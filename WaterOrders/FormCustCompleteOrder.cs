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
    public partial class FormCustCompleteOrder : Form
    {
        int _userId;
        Stocks _stock;
        public FormCustCompleteOrder(Stocks stock, int userId)
        {
            InitializeComponent();
            _userId = userId;
            _stock = stock;
        }

        private void FormCustCompleteOrder_Load(object sender, EventArgs e)
        {
            txtCustProductName.Text = _stock.Products.ProductName;
            
          


            
        }

        private void CmbCustBranchName_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudCustProductCount.Value = 0;
            lblTotalPrice.Text = "0 ₺";
            lblRemainingStock.Text = _stock.RemainingStock.ToString();
        }

        private void NudCustProductCount_ValueChanged(object sender, EventArgs e)
        {
            if (cmbCustBranchName.SelectedItem == null)
            {
                return;
            }

            
            decimal toplam = (_stock.Products.UnitPrice) * nudCustProductCount.Value;
            lblTotalPrice.Text = toplam + " ₺";
        }

       

        private void BtnNewOrders_Click(object sender, EventArgs e)
        {
              Orders order = new Orders()
              {
                  //Navigation Property Kullanıyoruz.Navigation Property'ler Entity ile beraber geldi. Navigation Property ilgli tablolara sırayla işlem yapmamızı sağlar
                  UserId = _userId,
                  StockId = _stock.StockId,
                  ToOrder= cmbCustBranchName.Text,
                  BranchId =int.Parse(cmbCustBranchName.SelectedValue.ToString()),
                  OrderDate = DateTime.Now,
                  OrderStatu ="Sipariş Alındı",
                  UnitPrice = _stock.Products.UnitPrice,
                  TotalUnitPrice = (_stock.Products.UnitPrice) * nudCustProductCount.Value,
                  Quantity=Convert.ToInt32(nudCustProductCount.Value)

              };

            int remaingStock = _stock.RemainingStock;

            _stock.RemainingStock = (short)(remaingStock- order.Quantity);

            //Veri Tabanına eklemeye başlıyoruz
            Singleton.Context.Orders.Add(order);
            WinformHelpers.KontrolluKaydet(this);
        }

        private void CmbCustBranchName_TextUpdate(object sender, EventArgs e)
        {
            //Bayi Seçme
            cmbCustBranchName.DroppedDown = false;
            cmbCustBranchName.DataSource = null;

            string girilenDegeriSaklayan = cmbCustBranchName.Text;

            if (cmbCustBranchName.Text.Length < 3)
            {
                cmbCustBranchName.Select(cmbCustBranchName.Text.Length, 0);
                return;
            }


            //Singleton yaklaşımı ile bir class yardımı ile context oluştrup Northwind Entitity Kullanıyoruz
            List<Users> user = Singleton.Context.Users.Where(u => u.UserName.Contains(cmbCustBranchName.Text)).Where(u => u.AuthorityId == 2).ToList(); //Lamda Operatoru kullanımı NOT :Müşteri Şirket...
            cmbCustBranchName.DisplayMember = "UserName";
            cmbCustBranchName.ValueMember = "UserId";
            cmbCustBranchName.DataSource = user;

            cmbCustBranchName.SelectedIndex = -1;
            cmbCustBranchName.Text = girilenDegeriSaklayan;
            cmbCustBranchName.Select(cmbCustBranchName.Text.Length, 0); //Karakterin sonununa git belirtilen kadar elaman seç.Substring gibi

            cmbCustBranchName.DroppedDown = true;
            Cursor.Current = Cursors.Default;

            
        }
    }
}
