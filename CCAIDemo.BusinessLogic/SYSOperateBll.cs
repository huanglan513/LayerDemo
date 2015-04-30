using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSOperateBll : BaseMgr<SYSOperate>
	{
        private SYSOperateDataAccess _SYSOperateDataAccess;

        public SYSOperateBll()
        {
            _SYSOperateDataAccess = new SYSOperateDataAccess();
        }
    }
 
}



