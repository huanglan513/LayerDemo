using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINReceiptCommApplyBll : BaseMgr<FINReceiptCommApply>
	{
        private FINReceiptCommApplyDataAccess _FINReceiptCommApplyDataAccess;

        public FINReceiptCommApplyBll()
        {
            _FINReceiptCommApplyDataAccess = new FINReceiptCommApplyDataAccess();
        }
    }
 
}



