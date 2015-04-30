using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CCAIDemo.Entity;
using CCAIDemo.DataAccess;

namespace CCAIDemo.BusinessLogic
{
    public class SYSOperateModelBll : BaseMgr<SYSOperateModel>
	{
        private SYSOperateModelDataAccess _SYSOperateModelDataAccess;

        public SYSOperateModelBll()
        {
            _SYSOperateModelDataAccess = new SYSOperateModelDataAccess();
        }
    }
 
}



