using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGSubTradeTypeBll : BaseMgr<CFGSubTradeType>
	{
        private CFGSubTradeTypeDataAccess _CFGSubTradeTypeDataAccess;

        public CFGSubTradeTypeBll()
        {
            _CFGSubTradeTypeDataAccess = new CFGSubTradeTypeDataAccess();
        }
    }
 
}



