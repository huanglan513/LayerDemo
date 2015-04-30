using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDeptWorkInfoBll : BaseMgr<FDeptWorkInfo>
	{
        private FDeptWorkInfoDataAccess _FDeptWorkInfoDataAccess;

        public FDeptWorkInfoBll()
        {
            _FDeptWorkInfoDataAccess = new FDeptWorkInfoDataAccess();
        }
    }
 
}



