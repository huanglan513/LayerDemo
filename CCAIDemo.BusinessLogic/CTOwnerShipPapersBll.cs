using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTOwnerShipPapersBll : BaseMgr<CTOwnerShipPapers>
	{
        private CTOwnerShipPapersDataAccess _CTOwnerShipPapersDataAccess;

        public CTOwnerShipPapersBll()
        {
            _CTOwnerShipPapersDataAccess = new CTOwnerShipPapersDataAccess();
        }
    }
 
}



