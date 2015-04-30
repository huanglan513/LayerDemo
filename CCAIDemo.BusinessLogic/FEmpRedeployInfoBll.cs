using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FEmpRedeployInfoBll : BaseMgr<FEmpRedeployInfo>
	{
        private FEmpRedeployInfoDataAccess _FEmpRedeployInfoDataAccess;

        public FEmpRedeployInfoBll()
        {
            _FEmpRedeployInfoDataAccess = new FEmpRedeployInfoDataAccess();
        }
    }
 
}



