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
    public partial class FormCategoryUpdate : Form
    {
        Categories _category;
        public FormCategoryUpdate(Categories category)
        {
            InitializeComponent();
            _category=category;
        }

        private void FormCategoryUpdate_Load(object sender, EventArgs e)
        {
            txtCategoryName.Text = _category.CategoryName;
            txtCategoryDescription.Text = _category.Description;
        }

        private void BtnCategoryUpdate_Click(object sender, EventArgs e)
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

            _category.CategoryName = txtCategoryName.Text;
            _category.Description = txtCategoryDescription.Text;

            WinformHelpers.KontrolluKaydet(this);
        }
    }
}
