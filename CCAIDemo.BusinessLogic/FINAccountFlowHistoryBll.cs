using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINAccountFlowHistoryBll : BaseMgr<FINAccountFlowHistory>
	{
        private FINAccountFlowHistoryDataAccess _FINAccountFlowHistoryDataAccess;

        public FINAccountFlowHistoryBll()
        {
            _FINAccountFlowHistoryDataAccess = new FINAccountFlowHistoryDataAccess();
        }
    }
 
}



