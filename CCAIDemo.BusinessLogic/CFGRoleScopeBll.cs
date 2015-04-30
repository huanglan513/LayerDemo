using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGRoleScopeBll : BaseMgr<CFGRoleScope>
	{
        private CFGRoleScopeDataAccess _CFGRoleScopeDataAccess;

        public CFGRoleScopeBll()
        {
            _CFGRoleScopeDataAccess = new CFGRoleScopeDataAccess();
        }
    }
 
}



