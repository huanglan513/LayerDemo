using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTExternalCommisionAdjustAssignsBll : BaseMgr<CTExternalCommisionAdjustAssigns>
	{
        private CTExternalCommisionAdjustAssignsDataAccess _CTExternalCommisionAdjustAssignsDataAccess;

        public CTExternalCommisionAdjustAssignsBll()
        {
            _CTExternalCommisionAdjustAssignsDataAccess = new CTExternalCommisionAdjustAssignsDataAccess();
        }
    }
 
}



