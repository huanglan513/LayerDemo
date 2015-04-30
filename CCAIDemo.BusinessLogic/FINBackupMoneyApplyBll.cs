using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINBackupMoneyApplyBll : BaseMgr<FINBackupMoneyApply>
	{
        private FINBackupMoneyApplyDataAccess _FINBackupMoneyApplyDataAccess;

        public FINBackupMoneyApplyBll()
        {
            _FINBackupMoneyApplyDataAccess = new FINBackupMoneyApplyDataAccess();
        }
    }
 
}



