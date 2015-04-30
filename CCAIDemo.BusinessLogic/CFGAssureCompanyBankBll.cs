using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGAssureCompanyBankBll : BaseMgr<CFGAssureCompanyBank>
	{
        private CFGAssureCompanyBankDataAccess _CFGAssureCompanyBankDataAccess;

        public CFGAssureCompanyBankBll()
        {
            _CFGAssureCompanyBankDataAccess = new CFGAssureCompanyBankDataAccess();
        }
    }
 
}



