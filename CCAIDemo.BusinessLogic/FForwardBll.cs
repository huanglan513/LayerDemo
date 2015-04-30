using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FForwardBll : BaseMgr<FForward>
	{
        private FForwardDataAccess _FForwardDataAccess;

        public FForwardBll()
        {
            _FForwardDataAccess = new FForwardDataAccess();
        }
    }
 
}



