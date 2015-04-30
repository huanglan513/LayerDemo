using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CFGCommonAlertTypeBll : BaseMgr<CFGCommonAlertType>
	{
        private CFGCommonAlertTypeDataAccess _CFGCommonAlertTypeDataAccess;

        public CFGCommonAlertTypeBll()
        {
            _CFGCommonAlertTypeDataAccess = new CFGCommonAlertTypeDataAccess();
        }
    }
 
}



