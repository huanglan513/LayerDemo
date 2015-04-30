using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class FINReceiptBookBll : BaseMgr<FINReceiptBook>
	{
        private FINReceiptBookDataAccess _FINReceiptBookDataAccess;

        public FINReceiptBookBll()
        {
            _FINReceiptBookDataAccess = new FINReceiptBookDataAccess();
        }
    }
 
}



