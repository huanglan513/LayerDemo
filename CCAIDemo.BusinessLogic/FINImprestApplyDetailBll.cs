using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINImprestApplyDetailBll : BaseMgr<FINImprestApplyDetail>
	{
        private FINImprestApplyDetailDataAccess _FINImprestApplyDetailDataAccess;

        public FINImprestApplyDetailBll()
        {
            _FINImprestApplyDetailDataAccess = new FINImprestApplyDetailDataAccess();
        }
    }
 
}



