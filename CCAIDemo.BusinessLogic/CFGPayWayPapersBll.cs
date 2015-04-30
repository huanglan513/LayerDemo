using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGPayWayPapersBll : BaseMgr<CFGPayWayPapers>
	{
        private CFGPayWayPapersDataAccess _CFGPayWayPapersDataAccess;

        public CFGPayWayPapersBll()
        {
            _CFGPayWayPapersDataAccess = new CFGPayWayPapersDataAccess();
        }
    }
 
}



