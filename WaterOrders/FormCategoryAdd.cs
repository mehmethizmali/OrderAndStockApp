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
    public partial class FormCategoryAdd : Form
    {
        public FormCategoryAdd()
        {
            InitializeComponent();
        }

        private void BtnCategoryAdd_Click(object sender, EventArgs e)
        {
            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                notification += "Lütfen Kategori Adı Giriniz.!\n";

            }

            if (string.IsNullOrWhiteSpace(txtCategoryDescription.Text))
            {
                notification += "Lütfen Kategori Açıklaması Giriniz.!";

            }

            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;
            }



            #endregion

            Categories categories = new Categories()
            {
               
                CategoryName = txtCategoryName.Text,
                Description = txtCategoryDescription.Text
            };

           

            Singleton.Context.Categories.Add(categories);//Veri tabanı yansımasını çağırıyoruz VE tabloya verileri giriyoruz

            //Verileri kontrollü kayıt ediyoruz..
            WinformHelpers.KontrolluKaydet(this);

        }
    }
}
