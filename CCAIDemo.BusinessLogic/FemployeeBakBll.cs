using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FemployeeBakBll : BaseMgr<FemployeeBak>
	{
        private FemployeeBakDataAccess _FemployeeBakDataAccess;

        public FemployeeBakBll()
        {
            _FemployeeBakDataAccess = new FemployeeBakDataAccess();
        }
    }
 
}



