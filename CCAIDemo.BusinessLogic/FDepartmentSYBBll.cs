using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDepartmentSYBBll : BaseMgr<FDepartmentSYB>
	{
        private FDepartmentSYBDataAccess _FDepartmentSYBDataAccess;

        public FDepartmentSYBBll()
        {
            _FDepartmentSYBDataAccess = new FDepartmentSYBDataAccess();
        }
    }
 
}



