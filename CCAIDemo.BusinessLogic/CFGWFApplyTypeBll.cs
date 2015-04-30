using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGWFApplyTypeBll : BaseMgr<CFGWFApplyType>
	{
        private CFGWFApplyTypeDataAccess _CFGWFApplyTypeDataAccess;

        public CFGWFApplyTypeBll()
        {
            _CFGWFApplyTypeDataAccess = new CFGWFApplyTypeDataAccess();
        }
    }
 
}



