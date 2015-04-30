using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINInvoiceApplyBll : BaseMgr<FINInvoiceApply>
	{
        private FINInvoiceApplyDataAccess _FINInvoiceApplyDataAccess;

        public FINInvoiceApplyBll()
        {
            _FINInvoiceApplyDataAccess = new FINInvoiceApplyDataAccess();
        }
    }
 
}



