using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINPaymentApplyDetailsBll : BaseMgr<FINPaymentApplyDetails>
	{
        private FINPaymentApplyDetailsDataAccess _FINPaymentApplyDetailsDataAccess;

        public FINPaymentApplyDetailsBll()
        {
            _FINPaymentApplyDetailsDataAccess = new FINPaymentApplyDetailsDataAccess();
        }
    }
 
}



