using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSRoleOperateRightBll : BaseMgr<SYSRoleOperateRight>
	{
        private SYSRoleOperateRightDataAccess _SYSRoleOperateRightDataAccess;

        public SYSRoleOperateRightBll()
        {
            _SYSRoleOperateRightDataAccess = new SYSRoleOperateRightDataAccess();
        }
    }
 
}



