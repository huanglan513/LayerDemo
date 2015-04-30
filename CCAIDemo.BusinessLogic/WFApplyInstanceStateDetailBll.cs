using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFApplyInstanceStateDetailBll : BaseMgr<WFApplyInstanceStateDetail>
	{
        private WFApplyInstanceStateDetailDataAccess _WFApplyInstanceStateDetailDataAccess;

        public WFApplyInstanceStateDetailBll()
        {
            _WFApplyInstanceStateDetailDataAccess = new WFApplyInstanceStateDetailDataAccess();
        }
    }
 
}



