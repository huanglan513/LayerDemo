using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTContractBll : BaseMgr<CTContract>
	{
        private CTContractDataAccess _CTContractDataAccess;

        public CTContractBll()
        {
            _CTContractDataAccess = new CTContractDataAccess();
        }
    }
 
}



