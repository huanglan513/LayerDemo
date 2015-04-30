using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCommisionAllocateApplyBll : BaseMgr<FINCommisionAllocateApply>
	{
        private FINCommisionAllocateApplyDataAccess _FINCommisionAllocateApplyDataAccess;

        public FINCommisionAllocateApplyBll()
        {
            _FINCommisionAllocateApplyDataAccess = new FINCommisionAllocateApplyDataAccess();
        }
    }
 
}



