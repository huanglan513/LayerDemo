using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FEmployeeBll : BaseMgr<FEmployee>
	{
        private FEmployeeDataAccess _FEmployeeDataAccess;

        public FEmployeeBll()
        {
            _FEmployeeDataAccess = new FEmployeeDataAccess();
        }
    }
 
}



