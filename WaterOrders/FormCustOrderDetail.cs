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
    public partial class FormCustOrderDetail : Form
    {
        Orders _orders;
        public FormCustOrderDetail(Orders orders)
        {
            InitializeComponent();
            _orders = orders;
        }

        private void FormMyOrderDetail_Load(object sender, EventArgs e)
        {
            txtOrderProductName.Text = _orders.Stocks.Products.ProductName;
            txtOrderBranchName.Text = _orders.ToOrder;
            txtOrderDate.Text = _orders.OrderDate.ToString();
            txtOrderQuantity.Text = _orders.Quantity.ToString();
            txtOrderUnitPrice.Text = _orders.UnitPrice.ToString();
            txtOrderTotalUnit.Text = _orders.TotalUnitPrice.ToString();
            lbl2OrderStatu.Text = _orders.OrderStatu;

            if (lbl2OrderStatu.Text != "Sipariş Alındı")
            {
                btnCancel.Enabled = false;
                btnCancel.BackColor = Color.Gray;
                btnCancel.ForeColor = Color.White;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

            _orders.OrderStatu = "Sipariş İptal Edildi";

            WinformHelpers.KontrolluKaydet(this);

        }
    }
}
