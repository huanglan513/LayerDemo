using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGPayWayCommisionBll : BaseMgr<CFGPayWayCommision>
	{
        private CFGPayWayCommisionDataAccess _CFGPayWayCommisionDataAccess;

        public CFGPayWayCommisionBll()
        {
            _CFGPayWayCommisionDataAccess = new CFGPayWayCommisionDataAccess();
        }
    }
 
}



