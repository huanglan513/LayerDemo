using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FEmpWorkInfo0419Bll : BaseMgr<FEmpWorkInfo0419>
	{
        private FEmpWorkInfo0419DataAccess _FEmpWorkInfo0419DataAccess;

        public FEmpWorkInfo0419Bll()
        {
            _FEmpWorkInfo0419DataAccess = new FEmpWorkInfo0419DataAccess();
        }
    }
 
}



