using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSUserAlertListBll : BaseMgr<SYSUserAlertList>
	{
        private SYSUserAlertListDataAccess _SYSUserAlertListDataAccess;

        public SYSUserAlertListBll()
        {
            _SYSUserAlertListDataAccess = new SYSUserAlertListDataAccess();
        }
    }
 
}



