using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCommisionTransferApplyDetailBll : BaseMgr<FINCommisionTransferApplyDetail>
	{
        private FINCommisionTransferApplyDetailDataAccess _FINCommisionTransferApplyDetailDataAccess;

        public FINCommisionTransferApplyDetailBll()
        {
            _FINCommisionTransferApplyDetailDataAccess = new FINCommisionTransferApplyDetailDataAccess();
        }
    }
 
}



