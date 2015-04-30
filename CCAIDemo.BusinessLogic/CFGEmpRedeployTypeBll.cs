using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGEmpRedeployTypeBll : BaseMgr<CFGEmpRedeployType>
	{
        private CFGEmpRedeployTypeDataAccess _CFGEmpRedeployTypeDataAccess;

        public CFGEmpRedeployTypeBll()
        {
            _CFGEmpRedeployTypeDataAccess = new CFGEmpRedeployTypeDataAccess();
        }
    }
 
}



