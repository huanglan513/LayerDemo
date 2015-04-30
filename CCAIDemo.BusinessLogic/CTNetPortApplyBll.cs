using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class CTNetPortApplyBll : BaseMgr<CTNetPortApply>
	{
        private CTNetPortApplyDataAccess _CTNetPortApplyDataAccess;

        public CTNetPortApplyBll()
        {
            _CTNetPortApplyDataAccess = new CTNetPortApplyDataAccess();
        }
    }
 
}



