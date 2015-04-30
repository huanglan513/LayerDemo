using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDepartment0802Bll : BaseMgr<FDepartment0802>
	{
        private FDepartment0802DataAccess _FDepartment0802DataAccess;

        public FDepartment0802Bll()
        {
            _FDepartment0802DataAccess = new FDepartment0802DataAccess();
        }
    }
 
}



