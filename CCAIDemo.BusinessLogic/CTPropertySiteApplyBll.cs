using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTPropertySiteApplyBll : BaseMgr<CTPropertySiteApply>
	{
        private CTPropertySiteApplyDataAccess _CTPropertySiteApplyDataAccess;

        public CTPropertySiteApplyBll()
        {
            _CTPropertySiteApplyDataAccess = new CTPropertySiteApplyDataAccess();
        }
    }
 
}



