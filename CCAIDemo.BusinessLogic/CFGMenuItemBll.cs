using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGMenuItemBll : BaseMgr<CFGMenuItem>
	{
        private CFGMenuItemDataAccess _CFGMenuItemDataAccess;

        public CFGMenuItemBll()
        {
            _CFGMenuItemDataAccess = new CFGMenuItemDataAccess();
        }
    }
 
}



