using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINPaymentApplyBll : BaseMgr<FINPaymentApply>
	{
        private FINPaymentApplyDataAccess _FINPaymentApplyDataAccess;

        public FINPaymentApplyBll()
        {
            _FINPaymentApplyDataAccess = new FINPaymentApplyDataAccess();
        }
    }
 
}



