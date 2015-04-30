using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTContractCommisionAssignsBll : BaseMgr<CTContractCommisionAssigns>
	{
        private CTContractCommisionAssignsDataAccess _CTContractCommisionAssignsDataAccess;

        public CTContractCommisionAssignsBll()
        {
            _CTContractCommisionAssignsDataAccess = new CTContractCommisionAssignsDataAccess();
        }
    }
 
}



