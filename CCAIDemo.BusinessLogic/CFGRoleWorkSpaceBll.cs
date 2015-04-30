using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGRoleWorkSpaceBll : BaseMgr<CFGRoleWorkSpace>
	{
        private CFGRoleWorkSpaceDataAccess _CFGRoleWorkSpaceDataAccess;

        public CFGRoleWorkSpaceBll()
        {
            _CFGRoleWorkSpaceDataAccess = new CFGRoleWorkSpaceDataAccess();
        }
    }
 
}



