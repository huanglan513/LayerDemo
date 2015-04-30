using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGJobNameToRoleBll : BaseMgr<CFGJobNameToRole>
	{
        private CFGJobNameToRoleDataAccess _CFGJobNameToRoleDataAccess;

        public CFGJobNameToRoleBll()
        {
            _CFGJobNameToRoleDataAccess = new CFGJobNameToRoleDataAccess();
        }
    }
 
}



