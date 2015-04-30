using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINReceiptBll : BaseMgr<FINReceipt>
	{
        private FINReceiptDataAccess _FINReceiptDataAccess;

        public FINReceiptBll()
        {
            _FINReceiptDataAccess = new FINReceiptDataAccess();
        }
    }
 
}



