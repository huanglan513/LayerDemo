using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINImprestApplyBll : BaseMgr<FINImprestApply>
	{
        private FINImprestApplyDataAccess _FINImprestApplyDataAccess;

        public FINImprestApplyBll()
        {
            _FINImprestApplyDataAccess = new FINImprestApplyDataAccess();
        }
    }
 
}



