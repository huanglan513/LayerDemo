using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFOutOfOfficeSetBll : BaseMgr<WFOutOfOfficeSet>
	{
        private WFOutOfOfficeSetDataAccess _WFOutOfOfficeSetDataAccess;

        public WFOutOfOfficeSetBll()
        {
            _WFOutOfOfficeSetDataAccess = new WFOutOfOfficeSetDataAccess();
        }
    }
 
}



