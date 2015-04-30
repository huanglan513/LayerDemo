using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTContractReportReturnBll : BaseMgr<CTContractReportReturn>
	{
        private CTContractReportReturnDataAccess _CTContractReportReturnDataAccess;

        public CTContractReportReturnBll()
        {
            _CTContractReportReturnDataAccess = new CTContractReportReturnDataAccess();
        }
    }
 
}



