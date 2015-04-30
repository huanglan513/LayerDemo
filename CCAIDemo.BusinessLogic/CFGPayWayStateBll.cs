using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGPayWayStateBll : BaseMgr<CFGPayWayState>
	{
        private CFGPayWayStateDataAccess _CFGPayWayStateDataAccess;

        public CFGPayWayStateBll()
        {
            _CFGPayWayStateDataAccess = new CFGPayWayStateDataAccess();
        }
    }
 
}



