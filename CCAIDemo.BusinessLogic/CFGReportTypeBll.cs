using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGReportTypeBll : BaseMgr<CFGReportType>
	{
        private CFGReportTypeDataAccess _CFGReportTypeDataAccess;

        public CFGReportTypeBll()
        {
            _CFGReportTypeDataAccess = new CFGReportTypeDataAccess();
        }
    }
 
}



