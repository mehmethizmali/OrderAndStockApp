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
    public partial class FormUserUpdate : Form
    {
        Users _user;
        int _authority;
        public FormUserUpdate(Users user, int authority)
        {
            {
                InitializeComponent();
                _user = user;
                _authority = authority;

            }

            if (authority == 2)
            {
                lblUserNameUpdate.Text = "Bayi Adı";
                this.Text = "Bayi Güncelle";
            }

          
           

            txtUserNameUpdate.Text = _user.UserName;
            txtUserFirstNameUpdate.Text = _user.FirstName;
            txtUserLastNameUpdate.Text = _user.LastName;
            txtUserPhoneUpdate.Text = _user.Phone.ToString();
            txtUserAddressUpdate.Text = _user.Address;
            txtUserDistrictUpdate.Text = _user.District;
            txtUserCityUpdate.Text = _user.City;
            chckUserContinue.Checked =_user.Status;

        }

        private void FormUserUpdate_Load(object sender, EventArgs e)
        {

        }

        private void BtnUserUpdate_Click(object sender, EventArgs e)
        {
            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(txtUserNameUpdate.Text))
            {
                if (_authority == 2)
                {
                    notification += "Bayi Adı Alanı Boş Olamaz.! \n";
                }
                else
                {
                    notification += "Kullanıcı Adı Alanı Boş Olamaz.! \n";
                }

            }
            if (string.IsNullOrWhiteSpace(txtUserFirstNameUpdate.Text))
            {
                notification += "Ad Alanı Boş Olamaz.! \n";
            }

            if (string.IsNullOrWhiteSpace(txtUserLastNameUpdate.Text))
            {
                notification += "Soyad Alanı Boş Olamaz.! \n";
            }
           
            if (string.IsNullOrWhiteSpace(txtUserPhoneUpdate.Text))
            {
                notification += "Telefon Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserAddressUpdate.Text))
            {
                notification += "Adress Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserDistrictUpdate.Text))
            {
                notification += "İlçe Alanı Boş Olamaz.! \n";
            }

            if (string.IsNullOrWhiteSpace(txtUserCityUpdate.Text))
            {
                notification += "İl Alanı Boş Olamaz.! \n";
            }

            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;

            }
            #endregion





            _user.UserName = txtUserNameUpdate.Text.Trim();
            _user.FirstName = txtUserFirstNameUpdate.Text;
            _user.LastName = txtUserLastNameUpdate.Text;
            _user.Phone = int.Parse(txtUserPhoneUpdate.Text);
            _user.Address = txtUserAddressUpdate.Text;
            _user.District = txtUserDistrictUpdate.Text;
            _user.City = txtUserCityUpdate.Text;
            _user.Status = chckUserContinue.Checked;


            //Kotrollu ekleme yapıyoruz
            WinformHelpers.KontrolluKaydet(this);
        }
    }
}
