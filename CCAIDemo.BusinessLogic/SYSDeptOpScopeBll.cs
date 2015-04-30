using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSDeptOpScopeBll : BaseMgr<SYSDeptOpScope>
	{
        private SYSDeptOpScopeDataAccess _SYSDeptOpScopeDataAccess;

        public SYSDeptOpScopeBll()
        {
            _SYSDeptOpScopeDataAccess = new SYSDeptOpScopeDataAccess();
        }
    }
 
}



