using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINInvoiceCommissionBll : BaseMgr<FINInvoiceCommission>
	{
        private FINInvoiceCommissionDataAccess _FINInvoiceCommissionDataAccess;

        public FINInvoiceCommissionBll()
        {
            _FINInvoiceCommissionDataAccess = new FINInvoiceCommissionDataAccess();
        }
    }
 
}



