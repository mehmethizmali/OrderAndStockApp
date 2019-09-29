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
    public partial class FormBranches : Form
    {
        public FormBranches()
        {
            InitializeComponent();
            Load += BayiListeGuncelle;
        }

        private void PctBranchAdd_Click(object sender, EventArgs e)
        {

            FormUsersAdd frm = new FormUsersAdd(2);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += BayiListeGuncelle;
            frm.Show();


           
        }

        public void BayiListeGuncelle()
        {
            lsvBranches.Items.Clear();

            var users = Singleton.Context.Users.Where(u=>u.AuthorityId==2).ToList();

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
                lsvBranches.Items.Add(viewItem);

            }
        }

        public void TumBayiListeFiltrele()
        {
            lsvBranches.Items.Clear();

            List<Users> users;
            if (string.IsNullOrWhiteSpace(txtBranchSearch.Text))
            {
                users = Singleton.Context.Users.ToList();
            }
            else
            {
                string[] kelimeler = lsvBranches.Text.Trim().Split();
                 users = Singleton.Context.Users
                    .Where(u => u.UserName.Contains(txtBranchSearch.Text)).ToList();
            }



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
                lsvBranches.Items.Add(viewItem);

            }
        }

     

        public void BayiListeGuncelle(Object sender,EventArgs e)
        {
            BayiListeGuncelle();

        }

        private void PctBranchEdit_Click(object sender, EventArgs e)
        {
            if (lsvBranches.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğniz Bayiyi Seçiniz.!");
                return;
            }

            var item = lsvBranches.SelectedItems[0];
            Users user = (Users)item.Tag;

            FormUserUpdate frm = new FormUserUpdate(user, 2);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += BayiListeGuncelle;
            frm.Show();
        }

        private void PctBranchRefresh_Click(object sender, EventArgs e)
        {
            BayiListeGuncelle();
            MessageBox.Show("Bayi Listesi Başarıyla Güncellendi..");
        }

        private void PctBranchDelete_Click(object sender, EventArgs e)
        {
            if (lsvBranches.SelectedIndices.Count == 0)
            {
                MessageBox.Show("Lüten Silmek İstediğiniz Bayiyi Seçiniz.!");
                return;
            }
            var item = lsvBranches.SelectedItems[0];
            Users user = (Users)item.Tag;
            Singleton.Context.Users.Remove(user);
            WinformHelpers.KontrolluKaydet();
            BayiListeGuncelle();


        }

        private void TxtBranchSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtBranchSearch.Text.Length < 3)
            {
                return;
            }

            TumBayiListeFiltrele();
        }
    }
}
