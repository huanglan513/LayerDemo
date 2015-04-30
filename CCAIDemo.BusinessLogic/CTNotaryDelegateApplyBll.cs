using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTNotaryDelegateApplyBll : BaseMgr<CTNotaryDelegateApply>
	{
        private CTNotaryDelegateApplyDataAccess _CTNotaryDelegateApplyDataAccess;

        public CTNotaryDelegateApplyBll()
        {
            _CTNotaryDelegateApplyDataAccess = new CTNotaryDelegateApplyDataAccess();
        }
    }
 
}



