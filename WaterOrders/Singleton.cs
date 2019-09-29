using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterOrders
{
    class Singleton
    {
        //Bir nesneden bir tane üreterek istedişğimiz yerden  Ulaşaniliyoruz
        private static WatersDbContext context;

        public static WatersDbContext Context
        {
            get
            {
                if (context == null)
                {
                    context = new WatersDbContext();

                }

                return context;
            }
        }
    }
}
