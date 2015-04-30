using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTContractCancelApplyBll : BaseMgr<CTContractCancelApply>
	{
        private CTContractCancelApplyDataAccess _CTContractCancelApplyDataAccess;

        public CTContractCancelApplyBll()
        {
            _CTContractCancelApplyDataAccess = new CTContractCancelApplyDataAccess();
        }
    }
 
}



