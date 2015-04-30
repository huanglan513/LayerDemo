using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINInvoiceCommApplyBll : BaseMgr<FINInvoiceCommApply>
	{
        private FINInvoiceCommApplyDataAccess _FINInvoiceCommApplyDataAccess;

        public FINInvoiceCommApplyBll()
        {
            _FINInvoiceCommApplyDataAccess = new FINInvoiceCommApplyDataAccess();
        }
    }
 
}



