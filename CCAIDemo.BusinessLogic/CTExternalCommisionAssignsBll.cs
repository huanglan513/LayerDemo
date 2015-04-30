using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTExternalCommisionAssignsBll : BaseMgr<CTExternalCommisionAssigns>
	{
        private CTExternalCommisionAssignsDataAccess _CTExternalCommisionAssignsDataAccess;

        public CTExternalCommisionAssignsBll()
        {
            _CTExternalCommisionAssignsDataAccess = new CTExternalCommisionAssignsDataAccess();
        }
    }
 
}



