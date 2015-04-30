using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINImprestBankAccountBll : BaseMgr<FINImprestBankAccount>
	{
        private FINImprestBankAccountDataAccess _FINImprestBankAccountDataAccess;

        public FINImprestBankAccountBll()
        {
            _FINImprestBankAccountDataAccess = new FINImprestBankAccountDataAccess();
        }
    }
 
}



