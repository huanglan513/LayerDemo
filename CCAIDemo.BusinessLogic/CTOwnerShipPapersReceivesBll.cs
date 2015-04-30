using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTOwnerShipPapersReceivesBll : BaseMgr<CTOwnerShipPapersReceives>
	{
        private CTOwnerShipPapersReceivesDataAccess _CTOwnerShipPapersReceivesDataAccess;

        public CTOwnerShipPapersReceivesBll()
        {
            _CTOwnerShipPapersReceivesDataAccess = new CTOwnerShipPapersReceivesDataAccess();
        }
    }
 
}



