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
    public partial class FormUsersAdd : Form
    {
        int _authorityId;
        public FormUsersAdd(int authorityId)
        {
            InitializeComponent();
            _authorityId = authorityId;
        }

        private void BtnUserSave_Click(object sender, EventArgs e)
        {
            #region Validation
            string notification = "";
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                if (_authorityId == 2)
                {
                    notification += "Bayi Adı Alanı Boş Olamaz.! \n";
                }
                else
                {
                    notification += "Kullanıcı Adı Alanı Boş Olamaz.! \n";
                }
               
            }
            if (string.IsNullOrWhiteSpace(txtUsersFirstName.Text))
            {
                notification += "Ad Alanı Boş Olamaz.! \n";
            }

            if (string.IsNullOrWhiteSpace(txtUserLastName.Text))
            {
                notification += "Soyad Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserPassword.Text))
            {
                notification += "Şifre Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserPhone.Text))
            {
                notification += "Telefon Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserAddress.Text))
            {
                notification += "Adress Alanı Boş Olamaz.! \n";
            }
            if (string.IsNullOrWhiteSpace(txtUserDistrict.Text))
            {
                notification += "İlçe Alanı Boş Olamaz.! \n";
            }

            if (string.IsNullOrWhiteSpace(txtUserCity.Text))
            {
                notification += "İl Alanı Boş Olamaz.! \n";
            }

            if (notification.Length > 0)
            {
                MessageBox.Show(notification);
                return;

            }
            # endregion 

            string password = WinformHelpers.CreateMD5(txtUserPassword.Text);
            string passwordRepeat = WinformHelpers.CreateMD5(txtUserPasswordRepeat.Text);

            string passNotification = "";

            if (password != passwordRepeat)
            {
                passNotification += "Şifreler Uyuşmuyor.! \n";
               
            }

            if (txtUserPassword.Text.Length < 6)
            {
                passNotification += "Şifreniz en az 6 Karakter Olmalıdır.!\n";
            }

            if (txtUserPassword.Text.Length >=14)
            {
                passNotification += "Şifreniz en fazla 14 Karakter Olabilir.!\n";
            }

            if (passNotification.Length > 0)
            {
                MessageBox.Show(passNotification);
                txtUserPassword.Text = "";
                txtUserPasswordRepeat.Text = "";
                return;
            }


            Users user = new Users()
            {
                UserName= txtUserName.Text.Trim(),
                FirstName = txtUsersFirstName.Text,
                LastName = txtUserLastName.Text,
                Phone = int.Parse(txtUserPhone.Text),
                Password = password,
                Address=txtUserAddress.Text,
                District=txtUserDistrict.Text,
                City=txtUserCity.Text,
                AuthorityId=_authorityId,
                Status=true
                
               
                
            };

            //Ürünü veri tabanına kayıt ediyoruz
            Singleton.Context.Users.Add(user);

            //Kotrollu ekleme yapıyoruz
            WinformHelpers.KontrolluKaydet(this);

            if (_authorityId == 3)
            {
                FormLogin frmCust = new FormLogin();
                frmCust.Show();
                this.Hide();
            }

            
        }

        private void FormUsersAdd_Load(object sender, EventArgs e)
        {
            if (_authorityId == 2)
            {
                lblUserName.Text = "Bayi Adı";
                this.Text = "Yeni Bayi";
                btnUserSave.Text = "Kaydet";

            }
        }
    }
}
