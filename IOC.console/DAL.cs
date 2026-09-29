using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class DAL:IDAL
    {
        public List<Product> GetProducts()
        {
            //for example sql server 
            return new List<Product>()
            {
                new Product{ ID=1,Name="Kalem",Price=100,Stock=100},
                new Product{ ID=2,Name="silgi",Price=100,Stock=100},
                new Product{ ID=3,Name="defter",Price=100,Stock=100},
                new Product{ ID=4,Name="kitap",Price=100,Stock=100}
            };

        }


        public int Hesapla()
        {
            return 100;
        }


    }
}
