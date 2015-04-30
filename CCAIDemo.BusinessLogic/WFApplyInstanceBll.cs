using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFApplyInstanceBll : BaseMgr<WFApplyInstance>
	{
        private WFApplyInstanceDataAccess _WFApplyInstanceDataAccess;

        public WFApplyInstanceBll()
        {
            _WFApplyInstanceDataAccess = new WFApplyInstanceDataAccess();
        }
    }
 
}



