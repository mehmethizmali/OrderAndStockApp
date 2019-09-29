using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterOrders
{
    public static class WinformExtension
    {
        public static void MdiChilAc<F>(this Form form)
           where F : Form, new()
        {
            F frm = new F();
            frm.MdiParent = form;
            frm.Show();
        }


    }
}
