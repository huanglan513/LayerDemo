using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCheckCommisionInvoiceBll : BaseMgr<FINCheckCommisionInvoice>
	{
        private FINCheckCommisionInvoiceDataAccess _FINCheckCommisionInvoiceDataAccess;

        public FINCheckCommisionInvoiceBll()
        {
            _FINCheckCommisionInvoiceDataAccess = new FINCheckCommisionInvoiceDataAccess();
        }
    }
 
}



