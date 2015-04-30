using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTAgencyContextChangeApplyBll : BaseMgr<CTAgencyContextChangeApply>
	{
        private CTAgencyContextChangeApplyDataAccess _CTAgencyContextChangeApplyDataAccess;

        public CTAgencyContextChangeApplyBll()
        {
            _CTAgencyContextChangeApplyDataAccess = new CTAgencyContextChangeApplyDataAccess();
        }
    }
 
}



