using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class WFOutOfOfficeSetDetailBll : BaseMgr<WFOutOfOfficeSetDetail>
	{
        private WFOutOfOfficeSetDetailDataAccess _WFOutOfOfficeSetDetailDataAccess;

        public WFOutOfOfficeSetDetailBll()
        {
            _WFOutOfOfficeSetDetailDataAccess = new WFOutOfOfficeSetDetailDataAccess();
        }
    }
 
}



