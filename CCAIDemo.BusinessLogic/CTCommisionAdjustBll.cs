using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTCommisionAdjustBll : BaseMgr<CTCommisionAdjust>
	{
        private CTCommisionAdjustDataAccess _CTCommisionAdjustDataAccess;

        public CTCommisionAdjustBll()
        {
            _CTCommisionAdjustDataAccess = new CTCommisionAdjustDataAccess();
        }
    }
 
}



