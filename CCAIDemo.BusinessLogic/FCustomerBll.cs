using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FCustomerBll : BaseMgr<FCustomer>
	{
        private FCustomerDataAccess _FCustomerDataAccess;

        public FCustomerBll()
        {
            _FCustomerDataAccess = new FCustomerDataAccess();
        }
    }
 
}



