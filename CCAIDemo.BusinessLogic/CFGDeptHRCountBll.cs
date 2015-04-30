using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGDeptHRCountBll : BaseMgr<CFGDeptHRCount>
	{
        private CFGDeptHRCountDataAccess _CFGDeptHRCountDataAccess;

        public CFGDeptHRCountBll()
        {
            _CFGDeptHRCountDataAccess = new CFGDeptHRCountDataAccess();
        }
    }
 
}



