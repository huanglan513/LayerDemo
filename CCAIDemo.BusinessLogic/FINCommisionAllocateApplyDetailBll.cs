using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCommisionAllocateApplyDetailBll : BaseMgr<FINCommisionAllocateApplyDetail>
	{
        private FINCommisionAllocateApplyDetailDataAccess _FINCommisionAllocateApplyDetailDataAccess;

        public FINCommisionAllocateApplyDetailBll()
        {
            _FINCommisionAllocateApplyDetailDataAccess = new FINCommisionAllocateApplyDetailDataAccess();
        }
    }
 
}



