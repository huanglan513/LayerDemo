using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINAccountFlowHistorySyncToSupplyBll : BaseMgr<FINAccountFlowHistorySyncToSupply>
	{
        private FINAccountFlowHistorySyncToSupplyDataAccess _FINAccountFlowHistorySyncToSupplyDataAccess;

        public FINAccountFlowHistorySyncToSupplyBll()
        {
            _FINAccountFlowHistorySyncToSupplyDataAccess = new FINAccountFlowHistorySyncToSupplyDataAccess();
        }
    }
 
}



