using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SysSetBll : BaseMgr<SysSet>
	{
        private SysSetDataAccess _SysSetDataAccess;

        public SysSetBll()
        {
            _SysSetDataAccess = new SysSetDataAccess();
        }
    }
 
}



