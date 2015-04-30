using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGBizHaltDaysBll : BaseMgr<CFGBizHaltDays>
	{
        private CFGBizHaltDaysDataAccess _CFGBizHaltDaysDataAccess;

        public CFGBizHaltDaysBll()
        {
            _CFGBizHaltDaysDataAccess = new CFGBizHaltDaysDataAccess();
        }
    }
 
}



