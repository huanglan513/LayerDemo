using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGTradeTypeBll : BaseMgr<CFGTradeType>
	{
        private CFGTradeTypeDataAccess _CFGTradeTypeDataAccess;

        public CFGTradeTypeBll()
        {
            _CFGTradeTypeDataAccess = new CFGTradeTypeDataAccess();
        }
    }
 
}



