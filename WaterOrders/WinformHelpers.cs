using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterOrders
{
    class WinformHelpers
    {
        public static void KontrolluKaydet(Form form)
        {
            try
            {
                int ess = Singleton.Context.SaveChanges();
                if (ess > 0)
                {
                    MessageBox.Show("İşlem Başarılı..");
                    form.Close();

                }
                else
                {
                    MessageBox.Show("İşlem Başarısız..!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir Hata Oluştu...");
            }
        }
        public static void KontrolluKaydet()
        {
            try
            {
                int ess = Singleton.Context.SaveChanges();
                if (ess > 0)
                {
                    MessageBox.Show("İşlem Başarılı..");
                  

                }
                else
                {
                    MessageBox.Show("İşlem Başarısız..!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bir Hata Oluştu...");
            }
        }

        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
