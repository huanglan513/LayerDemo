using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FBankAccountBll : BaseMgr<FBankAccount>
	{
        private FBankAccountDataAccess _FBankAccountDataAccess;

        public FBankAccountBll()
        {
            _FBankAccountDataAccess = new FBankAccountDataAccess();
        }
    }
 
}



