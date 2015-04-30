using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CertItemBll : BaseMgr<CertItem>
	{
        private CertItemDataAccess _CertItemDataAccess;

        public CertItemBll()
        {
            _CertItemDataAccess = new CertItemDataAccess();
        }
    }
 
}



