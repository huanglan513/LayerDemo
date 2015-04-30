using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINBackupMoneyBankAccountBll : BaseMgr<FINBackupMoneyBankAccount>
	{
        private FINBackupMoneyBankAccountDataAccess _FINBackupMoneyBankAccountDataAccess;

        public FINBackupMoneyBankAccountBll()
        {
            _FINBackupMoneyBankAccountDataAccess = new FINBackupMoneyBankAccountDataAccess();
        }
    }
 
}



