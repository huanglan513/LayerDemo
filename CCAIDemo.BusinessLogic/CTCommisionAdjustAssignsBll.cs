using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTCommisionAdjustAssignsBll : BaseMgr<CTCommisionAdjustAssigns>
	{
        private CTCommisionAdjustAssignsDataAccess _CTCommisionAdjustAssignsDataAccess;

        public CTCommisionAdjustAssignsBll()
        {
            _CTCommisionAdjustAssignsDataAccess = new CTCommisionAdjustAssignsDataAccess();
        }
    }
 
}



