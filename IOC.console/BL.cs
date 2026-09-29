using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    internal class BL
    {
        //private DAL _dal { get;set }
        private IDAL _dal { get; set; }



        public BL(IDAL dal)
        {
            //_dal = new DAL();
            //_dal=DALFactory.GetDal();//ioc implament
            _dal = dal;//di

        }

        public List<Product> GetProducts()
        {

            return _dal.GetProducts();
        }
    }
}
