using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINInvoiceBookBll : BaseMgr<FINInvoiceBook>
	{
        private FINInvoiceBookDataAccess _FINInvoiceBookDataAccess;

        public FINInvoiceBookBll()
        {
            _FINInvoiceBookDataAccess = new FINInvoiceBookDataAccess();
        }
    }
 
}



