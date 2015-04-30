using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTOwnerShipTransferBll : BaseMgr<CTOwnerShipTransfer>
	{
        private CTOwnerShipTransferDataAccess _CTOwnerShipTransferDataAccess;

        public CTOwnerShipTransferBll()
        {
            _CTOwnerShipTransferDataAccess = new CTOwnerShipTransferDataAccess();
        }
    }
 
}



