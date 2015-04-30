using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSUserOpScopeBll : BaseMgr<SYSUserOpScope>
	{
        private SYSUserOpScopeDataAccess _SYSUserOpScopeDataAccess;

        public SYSUserOpScopeBll()
        {
            _SYSUserOpScopeDataAccess = new SYSUserOpScopeDataAccess();
        }
    }
 
}



