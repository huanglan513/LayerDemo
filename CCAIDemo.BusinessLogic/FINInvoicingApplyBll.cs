using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINInvoicingApplyBll : BaseMgr<FINInvoicingApply>
	{
        private FINInvoicingApplyDataAccess _FINInvoicingApplyDataAccess;

        public FINInvoicingApplyBll()
        {
            _FINInvoicingApplyDataAccess = new FINInvoicingApplyDataAccess();
        }
    }
 
}



