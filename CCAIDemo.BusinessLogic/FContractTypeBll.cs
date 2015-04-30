using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FContractTypeBll : BaseMgr<FContractType>
	{
        private FContractTypeDataAccess _FContractTypeDataAccess;

        public FContractTypeBll()
        {
            _FContractTypeDataAccess = new FContractTypeDataAccess();
        }
    }
 
}



