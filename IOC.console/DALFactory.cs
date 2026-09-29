using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    public class DALFactory
    {
        public static DAL GetDal()
        {
            return new DAL();   
        }
    }
}
