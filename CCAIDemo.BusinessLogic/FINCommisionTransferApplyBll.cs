using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCommisionTransferApplyBll : BaseMgr<FINCommisionTransferApply>
	{
        private FINCommisionTransferApplyDataAccess _FINCommisionTransferApplyDataAccess;

        public FINCommisionTransferApplyBll()
        {
            _FINCommisionTransferApplyDataAccess = new FINCommisionTransferApplyDataAccess();
        }
    }
 
}



