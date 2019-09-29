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
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            Load += MusteriListeGuncelle;
        }

        private void PctCustomerAdd_Click(object sender, EventArgs e)
        {
            FormUsersAdd frm = new FormUsersAdd(3);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += MusteriListeGuncelle;
            frm.Show();

        }

        public void MusteriListeGuncelle()
        {
            lsvCustomer.Items.Clear();

            var users = Singleton.Context.Users.Where(u => u.AuthorityId == 3).ToList();

            foreach (var item in users)
            {
                string[] degerler = new string[8]
                {
                  item.UserId.ToString(),
                  item.UserName,
                  item.FirstName,
                  item.LastName,
                  item.Phone.ToString(),
                  item.District,
                  item.City,
                  item.Status.ToString()

                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvCustomer.Items.Add(viewItem);

            }
        }

        public void MusteriListeGuncelle(Object sender, EventArgs e)
        {
            MusteriListeGuncelle();

        }


        private void PctCustomerEdit_Click(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğniz Bayiyi Seçiniz.!");
                return;
            }

            var item = lsvCustomer.SelectedItems[0];
            Users user = (Users)item.Tag;

            FormUserUpdate frm = new FormUserUpdate(user, 3);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += MusteriListeGuncelle;
            frm.Show();
        }

        private void PctCustomerRefresh_Click(object sender, EventArgs e)
        {
            MusteriListeGuncelle();
            MessageBox.Show("Müşteri Listesi Başarıyla Güncellendi..");
        }

        private void PctCustomerDelete_Click(object sender, EventArgs e)
        {
            if (lsvCustomer.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lüten Silmek İstediğiniz Müşteriyi Seçiniz.!");
                return;
            }
            var item = lsvCustomer.SelectedItems[0];
            Users user = (Users)item.Tag;
            Singleton.Context.Users.Remove(user);
            WinformHelpers.KontrolluKaydet();
            MusteriListeGuncelle();
        }
    }
}
