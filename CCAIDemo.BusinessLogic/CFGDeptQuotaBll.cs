using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGDeptQuotaBll : BaseMgr<CFGDeptQuota>
	{
        private CFGDeptQuotaDataAccess _CFGDeptQuotaDataAccess;

        public CFGDeptQuotaBll()
        {
            _CFGDeptQuotaDataAccess = new CFGDeptQuotaDataAccess();
        }
    }
 
}



