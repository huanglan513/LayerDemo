using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FAreaBll : BaseMgr<FArea>
	{
        private FAreaDataAccess _FAreaDataAccess;

        public FAreaBll()
        {
            _FAreaDataAccess = new FAreaDataAccess();
        }
    }
 
}



