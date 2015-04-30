using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGTradeAccessoryTypeBll : BaseMgr<CFGTradeAccessoryType>
	{
        private CFGTradeAccessoryTypeDataAccess _CFGTradeAccessoryTypeDataAccess;

        public CFGTradeAccessoryTypeBll()
        {
            _CFGTradeAccessoryTypeDataAccess = new CFGTradeAccessoryTypeDataAccess();
        }
    }
 
}



