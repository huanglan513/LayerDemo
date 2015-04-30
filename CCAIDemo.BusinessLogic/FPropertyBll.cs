using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FPropertyBll : BaseMgr<FProperty>
	{
        private FPropertyDataAccess _FPropertyDataAccess;

        public FPropertyBll()
        {
            _FPropertyDataAccess = new FPropertyDataAccess();
        }
    }
 
}



