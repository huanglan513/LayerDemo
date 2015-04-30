using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCommisionReturnApplyBll : BaseMgr<FINCommisionReturnApply>
	{
        private FINCommisionReturnApplyDataAccess _FINCommisionReturnApplyDataAccess;

        public FINCommisionReturnApplyBll()
        {
            _FINCommisionReturnApplyDataAccess = new FINCommisionReturnApplyDataAccess();
        }
    }
 
}



