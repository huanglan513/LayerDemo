using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGDeptYearAimBll : BaseMgr<CFGDeptYearAim>
	{
        private CFGDeptYearAimDataAccess _CFGDeptYearAimDataAccess;

        public CFGDeptYearAimBll()
        {
            _CFGDeptYearAimDataAccess = new CFGDeptYearAimDataAccess();
        }
    }
 
}



