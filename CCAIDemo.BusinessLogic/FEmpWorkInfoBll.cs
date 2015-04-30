using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FEmpWorkInfoBll : BaseMgr<FEmpWorkInfo>
	{
        private FEmpWorkInfoDataAccess _FEmpWorkInfoDataAccess;

        public FEmpWorkInfoBll()
        {
            _FEmpWorkInfoDataAccess = new FEmpWorkInfoDataAccess();
        }
    }
 
}



