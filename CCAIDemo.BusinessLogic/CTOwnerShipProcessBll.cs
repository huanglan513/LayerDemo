using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTOwnerShipProcessBll : BaseMgr<CTOwnerShipProcess>
	{
        private CTOwnerShipProcessDataAccess _CTOwnerShipProcessDataAccess;

        public CTOwnerShipProcessBll()
        {
            _CTOwnerShipProcessDataAccess = new CTOwnerShipProcessDataAccess();
        }
    }
 
}



