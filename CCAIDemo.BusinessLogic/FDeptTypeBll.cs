using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FDeptTypeBll : BaseMgr<FDeptType>
	{
        private FDeptTypeDataAccess _FDeptTypeDataAccess;

        public FDeptTypeBll()
        {
            _FDeptTypeDataAccess = new FDeptTypeDataAccess();
        }
    }
 
}



