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
    public partial class FormCategory : Form
    {
        public FormCategory()
        {
            InitializeComponent();
            Load += CategoryListeGuncelle;
        }

        public void CategoryListeGuncelle()
        {
           lsvCategory.Items.Clear();

            var category = Singleton.Context.Categories.ToList();

            foreach (var item in category)
            {
                string[] degerler = new string[3]
                {
                    item.CategoryId.ToString(),
                    item.CategoryName,
                    item.Description
                };

                ListViewItem viewItem = new ListViewItem(degerler);
                viewItem.Tag = item;//Listview'in tag'ina atıyoruz.Silme Güncelleme işlemlerinde Tag'ı çağırıp veri ile ilgili işlemleri yapmak için
                lsvCategory.Items.Add(viewItem);

            }
        }

        public void CategoryListeGuncelle(Object sender, EventArgs e)
        {
            CategoryListeGuncelle();
        }

        private void PctCategoryAdd_Click(object sender, EventArgs e)
        {
            FormCategoryAdd frm = new FormCategoryAdd();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void PctCategoryDelete_Click(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Silmek İstediğniz Kategoriyi Seçiniz.!");
                return;
            }

            var item = lsvCategory.SelectedItems[0];
            Categories category= (Categories)item.Tag;
            Singleton.Context.Categories.Remove(category);
            WinformHelpers.KontrolluKaydet();
            CategoryListeGuncelle();
        }

        private void PictCustomerEdit_Click(object sender, EventArgs e)
        {
            if (lsvCategory.SelectedItems.Count == 0)
            {
                MessageBox.Show("Lütfen Güncellemek İstediğniz Kategoriyi Seçiniz.!");
                return;
            }

            var item = lsvCategory.SelectedItems[0];
            Categories category = (Categories)item.Tag;
            FormCategoryUpdate frm = new FormCategoryUpdate(category);
            frm.MdiParent = this.MdiParent;
            frm.FormClosed += CategoryListeGuncelle;
            frm.Show();
        }

        private void PctCategoryRefresh_Click(object sender, EventArgs e)
        {
            CategoryListeGuncelle();
            MessageBox.Show("Kategori Listesi Başarı ile Yenilendi..");
        }
    }
}
