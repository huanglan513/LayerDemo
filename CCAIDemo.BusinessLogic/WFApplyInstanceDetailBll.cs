using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFApplyInstanceDetailBll : BaseMgr<WFApplyInstanceDetail>
	{
        private WFApplyInstanceDetailDataAccess _WFApplyInstanceDetailDataAccess;

        public WFApplyInstanceDetailBll()
        {
            _WFApplyInstanceDetailDataAccess = new WFApplyInstanceDetailDataAccess();
        }
    }
 
}



