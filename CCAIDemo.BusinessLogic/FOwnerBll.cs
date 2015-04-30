using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FOwnerBll : BaseMgr<FOwner>
	{
        private FOwnerDataAccess _FOwnerDataAccess;

        public FOwnerBll()
        {
            _FOwnerDataAccess = new FOwnerDataAccess();
        }
    }
 
}



