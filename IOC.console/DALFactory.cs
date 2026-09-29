using System;
using System.Collections.Generic;
using System.Text;

namespace IOC.console
{
    public class DALFactory
    {
         static IDAL GetDal()
        {
            return new DAL();   
        }
    }
}
