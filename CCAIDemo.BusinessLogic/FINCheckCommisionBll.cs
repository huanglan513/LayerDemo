using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINCheckCommisionBll : BaseMgr<FINCheckCommision>
	{
        private FINCheckCommisionDataAccess _FINCheckCommisionDataAccess;

        public FINCheckCommisionBll()
        {
            _FINCheckCommisionDataAccess = new FINCheckCommisionDataAccess();
        }
    }
 
}



