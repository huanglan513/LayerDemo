using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTContractAssistantBll : BaseMgr<CTContractAssistant>
	{
        private CTContractAssistantDataAccess _CTContractAssistantDataAccess;

        public CTContractAssistantBll()
        {
            _CTContractAssistantDataAccess = new CTContractAssistantDataAccess();
        }
    }
 
}


