using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFAuditHistoryBll : BaseMgr<WFAuditHistory>
	{
        private WFAuditHistoryDataAccess _WFAuditHistoryDataAccess;

        public WFAuditHistoryBll()
        {
            _WFAuditHistoryDataAccess = new WFAuditHistoryDataAccess();
        }
    }
 
}



