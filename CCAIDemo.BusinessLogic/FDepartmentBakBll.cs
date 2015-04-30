using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDepartmentBakBll : BaseMgr<FDepartmentBak>
	{
        private FDepartmentBakDataAccess _FDepartmentBakDataAccess;

        public FDepartmentBakBll()
        {
            _FDepartmentBakDataAccess = new FDepartmentBakDataAccess();
        }
    }
 
}



