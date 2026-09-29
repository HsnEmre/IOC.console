using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class OracleDAL : IDAL
    {
        //oracle db
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product{ ID=1,Name="Kalem1",Price=100,Stock=100},
                new Product{ ID=2,Name="silgi1",Price=100,Stock=100},
                new Product{ ID=3,Name="defter1",Price=100,Stock=100},
                new Product{ ID=4,Name="kitap1",Price=100,Stock=100}
            };
        }
    }
}
