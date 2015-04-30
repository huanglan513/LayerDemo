using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDepartmentBll : BaseMgr<FDepartment>
	{
        private FDepartmentDataAccess _FDepartmentDataAccess;

        public FDepartmentBll()
        {
            _FDepartmentDataAccess = new FDepartmentDataAccess();
        }
    }
 
}



